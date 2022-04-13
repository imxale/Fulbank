using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulbank.Forms
{
    public partial class Ecran_Admin : Form
    {
        // Initialisation d'une nouvelle police d'écriture //
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font myFont;

        Person person;
        Role role = new Role();
        Transaction transaction = new Transaction();
        RendezVous rendezVous = new RendezVous();

        public Ecran_Admin(Person aPerson)
        {
            InitializeComponent();
            this.person = aPerson;
            this.WindowState = FormWindowState.Maximized;
            FontParam();
            CentrerTexte();
            Label_NomPanel.Text = "Transactions";
            Panel_Transaction.BringToFront();
            Panel_Transaction.Visible = true;
            DisplayTransactions();
            Data_Show();
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
            Button_DeconnexionAdmin.Font = new Font(myFont.FontFamily, 15, FontStyle.Regular);
            Label_IdentifiantAdmin.Font = new Font(myFont.FontFamily, 10, FontStyle.Regular);
            Label_NomPrenomAdmin.Font = new Font(myFont.FontFamily, 10, FontStyle.Regular);
            Label_RoleAdmin.Font = new Font(myFont.FontFamily, 10, FontStyle.Regular);

            Label_NomPanel.Font = new Font(myFont.FontFamily, 10, FontStyle.Regular);
            Label_Precedent.Font = new Font(myFont.FontFamily, 20, FontStyle.Regular);
            Label_Suivant.Font = new Font(myFont.FontFamily, 20, FontStyle.Regular);

            Label_Modification.Font = new Font(myFont.FontFamily, 10, FontStyle.Regular);
        }

        public void CentrerTexte()
        {
            /*Label_Titre.Left = (this.Width / 2) - (Label_Titre.Width / 2);
            TextBox_Identifiant.Left = (this.Width / 2) - (TextBox_Identifiant.Width / 2);
            TextBox_MDP.Left = (this.Width / 2) - (TextBox_MDP.Width / 2);
            Button_Connexion.Left = (this.Width / 2) - (Button_Connexion.Width / 2);
            RadioButton_AfficherMotDePasse.Left = (this.Width / 2) - (RadioButton_AfficherMotDePasse.Width / 2);*/
            dataGridView_OuvertCompte.Left = (Panel_OuvertCompte.Width / 2) - (dataGridView_OuvertCompte.Width / 2);
            dataGridView_RDV.Left = (Panel_RDV.Width / 2) - (dataGridView_RDV.Width / 2);
            dataGridView_Transaction.Left = (Panel_Transaction.Width / 2) - (dataGridView_Transaction.Width / 2);

            dataGridView_OuvertCompte.Top = 20;
            dataGridView_RDV.Top = (Panel_RDV.Height / 2) - (dataGridView_RDV.Height / 2);
            dataGridView_Transaction.Top = (Panel_Transaction.Height / 2) - (dataGridView_Transaction.Height / 2);

            Label_NomPanel.Left = (this.Width / 2) - (Label_NomPanel.Width / 2);
            Label_Precedent.Left = ((this.Width / 2) - (Label_Precedent.Width / 2)) - Label_NomPanel.Width;
            Label_Suivant.Left = ((this.Width / 2) - (Label_Suivant.Width / 2)) + Label_NomPanel.Width;
            Label_Modification.Left = ((Panel_OuvertCompte.Width / 2) - (Label_Modification.Width / 2));

            Label_NomPanel.Top = 160;
            Label_Suivant.Top = 145;
            Label_Precedent.Top = 145;
            Label_Modification.Top = 265;

            dataGridView_Transaction.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Transaction.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            groupBox_ModifAdmin.Left = ((Panel_OuvertCompte.Width / 2) - (groupBox_ModifAdmin.Width / 2));
            TextBox_Nom.Left = 10;
            //TextBox_DateNaissance.Left = 10;
            dateTime_DNaissance.Left = 10;
            TextBox_Adresse.Left = 10;
            TextBox_CP.Left = 10;

            TextBox_Prenom.Left = groupBox_ModifAdmin.Width - TextBox_Prenom.Width - 10;
            TextBox_Mail.Left = groupBox_ModifAdmin.Width - TextBox_Mail.Width - 10;
            TextBox_Ville.Left = groupBox_ModifAdmin.Width - TextBox_Ville.Width - 10;
            TextBox_User.Left = groupBox_ModifAdmin.Width - TextBox_User.Width - 10;

            Button_Modifier.Left = ((groupBox_ModifAdmin.Width / 2) - (Button_Modifier.Width / 2));
        }

        private void Label_Suivant_Click(object sender, EventArgs e)
        {
            string trans = "Transactions";
            string rdv = "Rendez-vous";
            string compte = "Comptes";

            switch (Label_NomPanel.Text)
            {
                case "Transactions":
                    Label_NomPanel.Text = rdv;
                    Panel_RDV.Visible = true;
                    Panel_OuvertCompte.Visible = false;
                    Panel_Transaction.Visible = false;
                    Panel_RDV.BringToFront();
                    DisplayRDV();
                    break;
                case "Rendez-vous":
                    Label_NomPanel.Text = compte;
                    Panel_OuvertCompte.Visible = true;
                    Panel_RDV.Visible = false;
                    Panel_Transaction.Visible = false;
                    Panel_OuvertCompte.BringToFront();
                    DisplayPersonAdmin();
                    break;
                case "Comptes":
                    Label_NomPanel.Text = trans;
                    Panel_Transaction.Visible = true;
                    Panel_OuvertCompte.Visible = false;
                    Panel_RDV.Visible = false;
                    Panel_Transaction.BringToFront();
                    DisplayTransactions();
                    break;
            }
        }

        private void Label_Precedent_Click(object sender, EventArgs e)
        {
            string trans = "Transactions";
            string rdv = "Rendez-vous";
            string compte = "Comptes";

            switch (Label_NomPanel.Text)
            {
                case "Transactions":
                    Label_NomPanel.Text = compte;
                    Panel_OuvertCompte.Visible = true;
                    Panel_RDV.Visible = false;
                    Panel_Transaction.Visible = false;
                    Panel_OuvertCompte.BringToFront();
                    DisplayPersonAdmin();
                    break;
                case "Rendez-vous":
                    Label_NomPanel.Text = trans;
                    Panel_Transaction.Visible = true;
                    Panel_OuvertCompte.Visible = false;
                    Panel_RDV.Visible = false;
                    Panel_Transaction.BringToFront();
                    DisplayTransactions();
                    break;
                case "Comptes":
                    Label_NomPanel.Text = rdv;
                    Panel_RDV.Visible = true;
                    Panel_OuvertCompte.Visible = false;
                    Panel_Transaction.Visible = false;
                    Panel_RDV.BringToFront();
                    DisplayRDV();
                    break;
            }
        }

        private void DisplayTransactions()
        {
            dataGridView_Transaction.DataSource = null;
            dataGridView_Transaction.DataSource = transaction.SelectTransaction();
        }

        private void DisplayPersonAdmin()
        {
            dataGridView_OuvertCompte.DataSource = null;
            dataGridView_OuvertCompte.DataSource = person.SelectPersonAdmin();
        }

        private void DisplayRDV()
        {
            dataGridView_RDV.DataSource = null;
            dataGridView_RDV.DataSource = rendezVous.SelectRDV();
        }

        // Afficher les données de l'utilisateur
        public void Data_Show()
        {
            SelectData();
            Label_IdentifiantAdmin.Text = " Identifiant : " + person.IdPerson.ToString();
            Label_NomPrenomAdmin.Text = "Nom : " + person.Name + "\nPrénom : " + person.Fname;
            Label_RoleAdmin.Text = "Role : " + role.Name;
        }

        // Selectionner le role de l'utilisateur
        public void SelectData()
        {
            foreach (DataRow dr in person.SelectPerson().Rows)
            {
                role.IdRole = int.Parse(dr["IDROLE"].ToString());
                person.IdPerson = int.Parse(dr["IDPERSON"].ToString());
                person.Name = dr["NAME"].ToString();
                person.Fname = dr["FNAME"].ToString();
            }

            foreach (DataRow dr in role.SelectRole().Rows)
            {
                role.Name = dr["NAME"].ToString();
            }
        }

        private void Button_UpdatePerson_Click(object sender, EventArgs e)
        {
            for (int i = 0 ; i < dataGridView_OuvertCompte.Rows.Count-1; i++)
            {
                string data = dataGridView_OuvertCompte[13, i].Value.ToString();
                Console.WriteLine(data);
                /*for(int y = 1 ; y < dataGridView_OuvertCompte.Columns.Count; y++)
                {
                    string data = dataGridView_OuvertCompte[y, i].Value.ToString();
                    Console.WriteLine(data);                    
                }*/
            }
            //person.UpdatePerson();
        }

        private void Button_DeconnexionAdmin_Click(object sender, EventArgs e)
        {
            // Deconnexion du compte et ouverture de l'écran connexion //
            Ecran_Connexion ecran_Connexion = new Ecran_Connexion();
            this.Hide();
            ecran_Connexion.ShowDialog();
            this.Close();
        }

        /* Récupérer les informations des USERS dans les TEXTBOX */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //int colonne = e.ColumnIndex;
                int ligne = e.RowIndex;

                string id = dataGridView_OuvertCompte[1, ligne].Value.ToString();
                string nom = dataGridView_OuvertCompte[3, ligne].Value.ToString();
                string prenom = dataGridView_OuvertCompte[4, ligne].Value.ToString();
                DateTime date = (DateTime)dataGridView_OuvertCompte[5, ligne].Value;
                string mail = dataGridView_OuvertCompte[6, ligne].Value.ToString();
                string adresse = dataGridView_OuvertCompte[7, ligne].Value.ToString();
                string ville = dataGridView_OuvertCompte[8, ligne].Value.ToString();
                string CP = dataGridView_OuvertCompte[9, ligne].Value.ToString();
                string user = dataGridView_OuvertCompte[10, ligne].Value.ToString();

                TextBox_IdPerson.Text = id;
                TextBox_Nom.Text = nom;
                TextBox_Prenom.Text = prenom;
                //TextBox_DateNaissance.Text = date;
                dateTime_DNaissance.Value = date;
                TextBox_Mail.Text = mail;
                TextBox_Adresse.Text = adresse;
                TextBox_Ville.Text = ville;
                TextBox_CP.Text = CP;
                TextBox_User.Text = user;
            }
            catch (Exception)
            {
                MessageBox.Show("Sélectionnez une case remplie");
            }
        }

        /* Envoie des informations à la BDD */
        private void Button_Modifier_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.IdPerson = int.Parse(TextBox_IdPerson.Text);
            person.Name = TextBox_Nom.Text;
            person.Fname = TextBox_Prenom.Text;
            person.Birth = dateTime_DNaissance.Value;
            person.Mail = TextBox_Mail.Text;
            person.Address = TextBox_Adresse.Text;
            person.City = TextBox_Ville.Text;
            person.Postal = int.Parse(TextBox_CP.Text);
            person.User = TextBox_User.Text;
            //Console.WriteLine(person.Name);
            person.UpdatePerson();
            DisplayPersonAdmin();
        }
    }
}
