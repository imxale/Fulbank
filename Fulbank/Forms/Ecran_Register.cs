using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Fulbank
{
    public partial class Ecran_Register : Form
    {
        public Ecran_Register()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            CentrerText();
        }

        /*protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Rect = new Rectangle(0, 0, Label_Titre.Width, Label_Titre.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);//haut gauche
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);//haut droite
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);//bas droite
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);//bas gauche
            Label_Titre.Region = new Region(GraphPath);
        }*/

        public void CentrerText()
        {
            Label_Titre.Left = (this.Width / 2) - (Label_Titre.Width / 2);
            name.Left = (this.Width / 2) - (name.Width / 2);
            firstname.Left = (this.Width / 2) - (firstname.Width / 2);
            birthday.Left = (this.Width / 2) - (birthday.Width / 2);
            email.Left = (this.Width / 2) - (email.Width / 2);
            adress.Left = (this.Width / 2) - (adress.Width / 2);
            city.Left = (this.Width / 2) - (city.Width / 2);
            postal.Left = (this.Width / 2) - (postal.Width / 2);
            user_name.Left = (this.Width / 2) - (user_name.Width / 2);
            password.Left = (this.Width / 2) - (password.Width / 2);
            password_check.Left = (this.Width / 2) - (password_check.Width / 2);
            CreateAccount.Left = (this.Width / 2) - (CreateAccount.Width / 2);
        }

        static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void CreateAccount_Click_1(object sender, EventArgs e)
        {
            //Création d'un compte utilisateur             
            try
            {
                if (password.Text == password_check.Text)
                {
                    Person person = new Person();                                                 

                    //Initialisation du resultat du test de l'utilisateur a faux 
                    bool result = false;
                    bool resultEmail = false;


                    //Vérifie si le pseudo n'existe pas déjà
                    if (IsValidEmail(email.Text) == true)
                    {
                        resultEmail = true;

                        foreach (DataRow dr in person.SelectPersonName().Rows)
                        {
                            if (user_name.Text == dr["USER"].ToString())
                            {
                                result = true;
                                break;
                            }
                        }
                        if (result == false && resultEmail == true)
                        {
                            person.Name = name.Text; //.ToUpper();
                            person.Fname = firstname.Text; //.Substring(0, 1).ToUpper() + firstname.Text.Substring(1, firstname.Text.Length - 1).ToLower();
                            person.Birth = birthday.Value;
                            person.Mail = email.Text;
                            person.Address = adress.Text;
                            person.City = city.Text;
                            person.Postal = int.Parse(postal.Text);
                            person.User = user_name.Text;
                            person.Password = password.Text;
                            person.InsertUser();
                            MessageBox.Show("Votre compte est en attente de validation");
                            Ecran_Connexion ec = new Ecran_Connexion();
                            this.Hide();
                            ec.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("L'utilisateur entré existe déjà");
                        }
                    }
                    else
                    {
                        resultEmail = false;
                        MessageBox.Show("Adresse mail invalide");
                    }
                }
                else
                {
                    MessageBox.Show("Les mots de passe sont différents");
                }
            }
            catch
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }
    }
}