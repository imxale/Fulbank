using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using MySql.Data.MySqlClient;
using Fulbank.Forms;

namespace Fulbank
{
    public partial class Ecran_Connexion : Form
    {
        // Initialisation d'une nouvelle police d'écriture //
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font myFont;       
        
        public Ecran_Connexion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;            
            FontParam();
            CentrerTexte();
        }
        
        public void FontParam()
        {
            // Importation de la police d'écriture Bungee //
            byte[] fontData = Properties.Resources.Bungee_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Bungee_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Bungee_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            myFont = new Font(fonts.Families[0], 15.0F);

            // Application de la police d'écriture //
            Label_Titre.Font = new Font(myFont.FontFamily, 40, FontStyle.Regular);
            Button_CreerCompte.Font = new Font(myFont.FontFamily, 10, FontStyle.Regular);
            Button_Connexion.Font = new Font(myFont.FontFamily, 15, FontStyle.Regular);
        }
           
        public void CentrerTexte()
        {
            Label_Titre.Left = (this.Width / 2) - (Label_Titre.Width / 2);
            TextBox_Identifiant.Left = (this.Width / 2) - (TextBox_Identifiant.Width / 2);
            TextBox_MDP.Left = (this.Width / 2) - (TextBox_MDP.Width / 2);
            Button_Connexion.Left = (this.Width / 2) - (Button_Connexion.Width / 2);
            RadioButton_AfficherMotDePasse.Left = (this.Width / 2) - (RadioButton_AfficherMotDePasse.Width / 2);
        }

        private void AfficherMotDePasse_CheckedChanged(object sender, EventArgs e)
        {            
            if(RadioButton_AfficherMotDePasse.Checked == true)
            {
                TextBox_MDP.UseSystemPasswordChar = false; 
            }
            else
            {
                TextBox_MDP.UseSystemPasswordChar = true;
            }
                        
        }

        private void Button_Connexion_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person
                {
                    User = TextBox_Identifiant.Text
                };
                if (person.SelectPerson().Rows.Count == 0)
                {
                    MessageBox.Show("Indentifiant incorrect");
                }
                    
                foreach (DataRow dr in person.SelectPerson().Rows)
                {
                    DateTime creationdate = DateTime.Parse(dr["CREATIONDATE"].ToString());
                    person.IdRole = int.Parse(dr["IDROLE"].ToString());
                    person.IdPerson = int.Parse(dr["IDPERSON"].ToString());
                    if (Hash(TextBox_MDP.Text + creationdate.Date.ToString("yyyy-MM-dd")) == dr["PASSWORD"].ToString())
                    {
                        if (Convert.ToBoolean(dr["ISVALID"]))
                        {
                            // Banquier ou Client
                            if (person.IdRole == 1)
                            {
                                Ecran_Euro f_eu = new Ecran_Euro(person);
                                this.Hide();
                                f_eu.ShowDialog();
                                this.Close();
                            }
                            else if (person.IdRole == 2)  // Admin
                            {
                                Ecran_Admin admin_ea = new Ecran_Admin(person);
                                this.Hide();
                                admin_ea.ShowDialog();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Votre compte n'est pas encore valide");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe incorrect");
                    }
                }
            }
            catch
            {
                MessageBox.Show("La connexion a échouée");
            }
        }

        //algorithme de hashage 
        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }

        private void Button_CreerCompte_Click(object sender, EventArgs e)
        {
            //Ouverture de l'écran Inscription //
            Ecran_Register register = new Ecran_Register();
            this.Hide();
            register.ShowDialog();
            this.Close();
        }        
    }
        
}
