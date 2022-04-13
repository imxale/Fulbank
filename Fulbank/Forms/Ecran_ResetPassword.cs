using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulbank.Forms
{
    
    public partial class Ecran_ResetPassword : Form
    {
        Person aPerson = new Person();
        public Ecran_ResetPassword()
        {
            InitializeComponent();
        }

        public string randomcode;

        private void button_envoyer_Click(object sender, EventArgs e)
        {
            // string from, pass, messagebody;
            Random random = new Random();
            randomcode = random.Next(999999).ToString();
            MessageBox.Show(randomcode);
            MailMessage message = new MailMessage();
            string to = (textBox_email.Text).ToString();
            var from = "fulbank28@gmail.com";
            var pass = "8f$CLpE5XzzAPD";
            var messagebody = $"Votre code secret : {randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "Reinitialisation de mot de passe";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code secret envoyé");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if(randomcode == textBox_codeSecret.Text && textBox_password.Text == textBox_confirmpassword.Text)
            {
                try
                {
                    aPerson.Mail = textBox_email.Text;
                    aPerson.Password = textBox_password.Text;
                    aPerson.ResetPassword();
                    MessageBox.Show("Votre mot de passe à été réinitialisé");
                    Ecran_Connexion ecran_Connexion = new Ecran_Connexion();
                    this.Hide();
                    ecran_Connexion.ShowDialog();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Code secret ou mot de passe incorrect");
            }
        }
    }
}
