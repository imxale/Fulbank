using System;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Fulbank
{
    public partial class Ecran_Euro : Form
    {
        // Initialisation d'une nouvelle police d'écriture //
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font myFont;
        // FIN ICI //

        Person person;
        Role role = new Role();
        CurrentAccount Currentaccount = new CurrentAccount();
        HomeLoanPlan Homeloanplan = new HomeLoanPlan();
        SavingAccount Savingaccount = new SavingAccount();
        Transaction transaction = new Transaction();
        Recipient aRecipient = new Recipient();
        IAccount BankAccount;
        public Ecran_Euro(Person aPerson)
        {
            
            InitializeComponent();
            Panel_EcranEuro.BringToFront();
            this.person = aPerson;

            Currentaccount.IdPerson = person.IdPerson; 
            Savingaccount.IdPerson = person.IdPerson;
            Homeloanplan.IdPerson = person.IdPerson;
            transaction.IdPerson = person.IdPerson;
            
            Data_Show();
            SetPoliceEcriture();
            DisplayAccount();
            DisplayAccountVirement(); // 
            ListBox_ChoixTypeCompte.Items.Clear();
            AccountChoice(); // Afficher les comptes qui peuvent êtres crées
            SelectCurrentAccount(); // Selectionne le compte courrant
            SelectSavingAccount(); // Selectionne le Livret Épargne
            SelectHomeloanPlan(); // Selectionne le compte épargen logement         
            Show_Account_Data(); // Afficher les détails des comptes dans les pannels
            CentrerText(); // Centrer le text de la page
            WaitChargementPage();

            this.WindowState = FormWindowState.Maximized; //Plein écran

            // Test Graphique //
            string per = "\n#PERCENT";
            Chart_Depenses.Series["Dépenses"].Points.AddXY("Mcdo" + per, 1000);
            Chart_Depenses.Series["Dépenses"].Points.AddXY("Sport" + per, 500);
            Chart_Depenses.Series["Dépenses"].Points.AddXY("Maison" + per, 2000);

            // Ajout historique transaction //

            /*dataGridView_HistoriqueTransaction.Rows.Add(1,"Add","Revenue Pro","20-09-2021","+ 35,50€");
            dataGridView_HistoriqueTransaction.Rows.Add(2,"Remove","Restaurant","20-09-2021","- 50€");*/

            dataGridView_HistoriqueTransaction.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_HistoriqueTransaction.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public async Task WaitChargementPage()
        {
            await Task.Delay(50);
            Console.WriteLine("testDealy");
            CentrerPanel();
        }

        public void CentrerText()
        {

            Label_NomCompte1.Left = (Panel_Compte1.Width / 2) - (Label_NomCompte1.Width / 2);
            //Label_NumeroCompte1.Left = (Panel_Compte1.Width / 2) - (Label_NumeroCompte1.Width / 2);
            Label_NomCompte2.Left = (Panel_Compte2.Width / 2) - (Label_NomCompte2.Width / 2);
            //Label_NumeroCompte2.Left = (Panel_Compte2.Width / 2) - (Label_NumeroCompte2.Width / 2);
            Label_NomCompte3.Left = (Panel_Compte3.Width / 2) - (Label_NomCompte3.Width / 2);
            //Label_NumeroCompte3.Left = (Panel_Compte3.Width / 2) - (Label_NumeroCompte3.Width / 2);

            /*Label_NumeroCompte1.Top = ((Panel_Compte1.Height / 2) - (Label_NumeroCompte1.Height / 2)) + Label_NomCompte1.Height;
            Label_NumeroCompte2.Top = ((Panel_Compte2.Height / 2) - (Label_NumeroCompte2.Height / 2)) + Label_NomCompte2.Height;
            Label_NumeroCompte3.Top = ((Panel_Compte3.Height / 2) - (Label_NumeroCompte3.Height / 2)) + Label_NomCompte3.Height;
            */
            Label_NomWallet.Left = (Panel_DC_Crypto.Width / 2) - (Label_NomWallet.Width / 2);

            Label_DC_NomCompte.Left = (Panel_DC_Euro.Width / 2) - (Label_DC_NomCompte.Width / 2);
            Chart_Depenses.Left = (Panel_DC_Euro.Width / 2) - (Chart_Depenses.Width / 2);
            Chart_DepensesMois.Left = (Panel_DC_Euro.Width / 2) - (Chart_DepensesMois.Width / 2);
            Chart_RevenuesMois.Left = (Panel_DC_Euro.Width / 2) - (Chart_RevenuesMois.Width / 2);
            dataGridView_HistoriqueTransaction.Left = (Panel_DC_Euro.Width / 2) - (dataGridView_HistoriqueTransaction.Width / 2);

            ListBox_RaisonRDV.Left = (Panel_RDV.Width / 2) - (ListBox_RaisonRDV.Width / 2);
            RichTextBox_RaisonRDV.Left = (Panel_RDV.Width / 2) - (RichTextBox_RaisonRDV.Width / 2);
            Button_RDVEnvoyer.Left = (Panel_RDV.Width / 2) - (Button_RDVEnvoyer.Width / 2);
            GroupBox_Conseiller.Left = (Panel_RDV.Width / 2) - (GroupBox_Conseiller.Width / 2);
            /*Label_Conseiller.Left = (Panel_RDV.Width / 2) - (Label_Conseiller.Width / 2);
            Label_NOMConseiller.Left = (Panel_RDV.Width / 2) - (Label_NOMConseiller.Width / 2);*/

            Label_TitreDepotRetrait.Left = (Panel_DepotRetrait.Width / 2) - (Label_TitreDepotRetrait.Width / 2);
            Label_TitreDepotRetrait.Top = 0;

            Label_TitreVirement.Left = (Panel_Virement.Width / 2) - (Label_TitreVirement.Width / 2);
            Label_TitreVirement.Top = 0;

            Label_TitreCreationCompte.Left = (Panel_CreationCompte.Width / 2) - (Label_TitreCreationCompte.Width / 2);
            Label_TitreCreationCompte.Top = 0;
        }

        public void SetPoliceEcriture()
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
            Button_Deconnexion.Font = new Font(myFont.FontFamily, 15, FontStyle.Regular);
            Label_Identifiant.Font = new Font(myFont.FontFamily, 10, FontStyle.Regular);
            Label_NomPrenom.Font = new Font(myFont.FontFamily, 10, FontStyle.Regular);
            Label_Role.Font = new Font(myFont.FontFamily, 10, FontStyle.Regular);
            Label_TitreDepotRetrait.Font = new Font(myFont.FontFamily, 35, FontStyle.Regular);
            Label_TitreVirement.Font = new Font(myFont.FontFamily, 35, FontStyle.Regular);
            Label_TitreCreationCompte.Font = new Font(myFont.FontFamily, 35, FontStyle.Regular);
        }

        // Afficher les données de l'utilisateur
        public void Data_Show()
        {
            SelectData();
            Label_Identifiant.Text = " Identifiant : " + person.IdPerson.ToString();
            Label_NomPrenom.Text = "Nom : " + person.Name + "\nPrénom : " + person.Fname;
            Label_Role.Text = "Role : " + role.Name;
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

        private void Button_Crypto_Click(object sender, EventArgs e)
        {
            // Déclaration des couleurs violettes // 
            var DarkPurple = "#6F34E4";
            var ColorDarkPurple = System.Drawing.ColorTranslator.FromHtml(DarkPurple);
            var LightPurple = "#9872E4";
            var ColorLightPurple = System.Drawing.ColorTranslator.FromHtml(LightPurple);

            // Application couleurs //
            Label_Identifiant.BackColor = ColorDarkPurple;
            Label_NomPrenom.BackColor = ColorDarkPurple;
            Label_Role.BackColor = ColorDarkPurple;
            Button_Deconnexion.BackColor = ColorDarkPurple;
            Panel_EcranEuro.BackColor = ColorDarkPurple;
            Panel_Compte1.BackColor = ColorLightPurple;
            Panel_ChoixCompte.BackColor = ColorDarkPurple;
            this.BackColor = ColorLightPurple;

            // Affichage de l'écran Crypto //
            Button_DepotRetrait.Visible = false;
            Button_Virement.Visible = false;
            Button_AccountCreation.Visible = false;
            Button_RDV.Visible = false;

            Panel_ChoixCompte.BringToFront();
            Panel_ChoixCompte.Visible = true;
            /*Show_Crypro_Data();*/

            /*Crypto_info_Selector();*/
            //Label_NomCompte.Text = wallet.Name;
        }

        private void Button_Euro_Click(object sender, EventArgs e)
        {
            // Déclaration des couleurs bleus // 
            var DarBlue = "#224399";
            var ColorDarkBlue = System.Drawing.ColorTranslator.FromHtml(DarBlue);
            var LightBlue = "#80c2ec";
            var ColorLightBlue = System.Drawing.ColorTranslator.FromHtml(LightBlue);

            // Application couleurs //
            Label_Identifiant.BackColor = ColorDarkBlue;
            Label_NomPrenom.BackColor = ColorDarkBlue;
            Label_Role.BackColor = ColorDarkBlue;
            Button_Deconnexion.BackColor = ColorDarkBlue;
            Panel_EcranEuro.BackColor = ColorDarkBlue;
            Panel_Compte1.BackColor = ColorLightBlue;
            Panel_ChoixCompte.BackColor = ColorDarkBlue;
            this.BackColor = ColorLightBlue;

            // Affichage de l'écran Euro //
            Button_DepotRetrait.Visible = true;
            Button_Virement.Visible = true;
            Button_AccountCreation.Visible = true;
            Button_RDV.Visible = true;

            Panel_ChoixCompte.BringToFront();
            Panel_ChoixCompte.Visible = true;

            ListBox_ChoixForfait.Items.Clear();
            
            Show_Account_Data();
            CentrerPanel();
        }

        // Affiche les données du compte courrant
        public void Show_Account_Data()
        {
            Panel_Compte1.Visible = false;
            Panel_Compte2.Visible = false;
            Panel_Compte3.Visible = false;

            if (Currentaccount.IdAccount != 0)
            {
                Label_NomCompte1.Text = "Compte Courrant";
                Label_NumeroCompte1.Text = "N° " + Currentaccount.IdAccount;
                Label_Solde1.Text = Currentaccount.Balance.ToString();
                Panel_Compte1.Visible = true;
            }
            if (Savingaccount.IdAccount != 0)
            {
                Label_NomCompte2.Text = "Livret d'Épargne";
                Label_NumeroCompte2.Text = "N° " + Savingaccount.IdAccount;
                Label_Solde2.Text = Savingaccount.Balance.ToString();
                Panel_Compte2.Visible = true;
            }
            if (Homeloanplan.IdAccount != 0)
            {
                Label_NomCompte3.Text = "Compte Épargne\nLogement";
                Label_NumeroCompte3.Text = "N° " + Homeloanplan.IdAccount;
                Label_Solde3.Text = Homeloanplan.Balance.ToString();
                Panel_Compte3.Visible = true;
            }
        }

        public void CentrerPanel()
        {
            //3 Panel true
            if (Panel_Compte1.Visible == true & Panel_Compte2.Visible == true & Panel_Compte3.Visible == true)
            {
                Panel_Compte1.Location = new Point(13, 16);
                Panel_Compte2.Location = new Point(296, 16);
                Panel_Compte3.Location = new Point(580, 16);
            }
            //Panel 1 true
            else if (Panel_Compte1.Visible == true & Panel_Compte2.Visible == false & Panel_Compte3.Visible == false)
            {
                Panel_Compte1.Location = new Point(13, 16);
            }
            //Panel 2 true
            else if (Panel_Compte2.Visible == true & Panel_Compte1.Visible == false & Panel_Compte3.Visible == false)
            {
                Panel_Compte2.Location = new Point(13, 16);
            }
            //Panel 3 true
            else if (Panel_Compte3.Visible == true & Panel_Compte1.Visible == false & Panel_Compte2.Visible == false)
            {
                Panel_Compte3.Location = new Point(13, 16);
                Console.WriteLine("test Panel 3 true");
            }
            //Panel 1 & 2 true
            else if (Panel_Compte1.Visible == true & Panel_Compte2.Visible == true & Panel_Compte3.Visible == false)
            {
                Panel_Compte1.Location = new Point(13, 16);
                Panel_Compte2.Location = new Point(296, 16);
            }
            //Panel 1 & 3 true
            else if (Panel_Compte1.Visible == true & Panel_Compte3.Visible == true & Panel_Compte2.Visible == false)
            {
                Panel_Compte1.Location = new Point(13, 16);
                Panel_Compte3.Location = new Point(296, 16);
            }
            //Panel 2 & 3 true
            else if (Panel_Compte2.Visible == true & Panel_Compte3.Visible == true & Panel_Compte1.Visible == false)
            {
                Panel_Compte2.Location = new Point(13, 16);
                Panel_Compte3.Location = new Point(296, 16);
            }

            Console.WriteLine("test156654");
            //13; 16
            //296; 16
            //580; 16
            Console.WriteLine(Panel_Compte1.Location);
            Console.WriteLine(Panel_Compte2.Location);
            Console.WriteLine(Panel_Compte3.Location);
            Console.WriteLine("Id CompteCourant" + Currentaccount.IdAccount + " Id CompteEpargne" + Savingaccount.IdAccount + " Id Logement" + Homeloanplan.IdAccount);
        }
        /*
         public void Show_Crypro_Data()
         {
             Label_NomCompte.Text = "Wallet Bitcoin";
             Label_NumeroCompte.Text = "Wallet 1";
             Label_Solde.Text = Currentaccount.Balance.ToString();
         }*/

        private void Color_Account()
        {
            // Affichage du panel Euro ou Crypto en fonction de la couleur d'arrière plan //
            var LightPurple = "#9872E4";
            var ColorLightPurple = System.Drawing.ColorTranslator.FromHtml(LightPurple);

            if (this.BackColor != ColorLightPurple)
            {
                Panel_DC_Euro.BringToFront();
                Panel_DC_Euro.Visible = true;
            }
            else
            {
                Panel_DC_Crypto.BringToFront();
                Panel_DC_Crypto.Visible = true;
            }
        }

        private void Label_NomCompte_Click(object sender, EventArgs e)
        {
            Color_Account();
            transaction.IdAccountSender = Currentaccount.IdAccount;
            transaction.IdPerson = person.IdPerson;
            DisplayTransactions(); // Afficher les transactions de l'utilisateur
        }

        private void Label_NomCompte2_Click_1(object sender, EventArgs e)
        {
            Color_Account();
        }

        private void Label_NomCompte3_Click_1(object sender, EventArgs e)
        {
            Color_Account();
        }

        private void Button_DepotRetrait_Click(object sender, EventArgs e)
        {
            // Affichage du panel Depot Retrait //
            Panel_DepotRetrait.BringToFront();
            Panel_DepotRetrait.Visible = true;
        }

        private void Button_Virement_Click(object sender, EventArgs e)
        {
            // Affichage du panel Virement //
            Panel_Virement.BringToFront();
            Panel_Virement.Visible = true;
        }

        private void Button_Deconnexion_Click(object sender, EventArgs e)
        {
            // Deconnexion du compte et ouverture de l'écran connexion //
            Ecran_Connexion ecran_Connexion = new Ecran_Connexion();
            this.Hide();
            ecran_Connexion.ShowDialog();
            this.Close();
        }

        private void SelectCurrentAccount()
        {
            foreach (DataRow dr in Currentaccount.selectTheAccount().Rows)
            {
                Currentaccount.IdAccount = int.Parse(dr["IDACCOUNT"].ToString());
                Currentaccount.Balance = float.Parse(dr["BALANCE"].ToString());
                Currentaccount.Cap = int.Parse(dr["CAP"].ToString());
            }
        }

        private void SelectSavingAccount()
        {
            foreach (DataRow dr in Savingaccount.selectTheAccount().Rows)
            {
                Savingaccount.IdAccount = int.Parse(dr["IDACCOUNT"].ToString());
                Savingaccount.Balance = float.Parse(dr["BALANCE"].ToString());
                Savingaccount.Cap = int.Parse(dr["CAP"].ToString());
            }
        }

        private void SelectHomeloanPlan()
        {
            foreach (DataRow dr in Homeloanplan.selectTheAccount().Rows)
            {
                Homeloanplan.IdAccount = int.Parse(dr["IDACCOUNT"].ToString());
                Homeloanplan.Balance = float.Parse(dr["BALANCE"].ToString());
                Homeloanplan.Cap = int.Parse(dr["CAP"].ToString());
            }
        }

        public void DisplayAccount()
        {
            if (person.SelectCurrentAccount().Rows.Count == 1)
            {
                ListBox_Compte.Items.Add("Compte courrant");
            }
            if (person.SelectSavingAccount().Rows.Count == 1)
            {
                ListBox_Compte.Items.Add("Livret d'épargne");
            }
            if (person.SelectHomeloanplan().Rows.Count == 1)
            {
                ListBox_Compte.Items.Add("Compte épargne logement");
            }
        }

        // Cette procédure insert dans la base de données les données des retraits et des dépots et met à jour le solde des comptes
        public void Debit_RetraitTransac()
        {
            string selectedAccount = ListBox_Compte.SelectedItem.ToString();
            transaction.IdTerminal = 1;
            transaction.Amount = float.Parse(TextBox_Montant.Text);
            transaction.IdPerson = person.IdPerson;

            switch (selectedAccount)
            {
                case "Compte courrant":
                    BankAccount = new CurrentAccount();
                    BankAccount.Balance = Currentaccount.Balance;
                    transaction.IdAccountSender = Currentaccount.IdAccount;
                    Debit_Retrait();
                    Currentaccount.Balance = BankAccount.Balance;
                    break;
                case "Livret d'épargne":
                    BankAccount = new SavingAccount();
                    BankAccount.Balance = Savingaccount.Balance;
                    transaction.IdAccountSender = Savingaccount.IdAccount;
                    Debit_Retrait();
                    Savingaccount.Balance = BankAccount.Balance;
                    break;
                case "Compte épargne logement":
                    BankAccount = new HomeLoanPlan();
                    BankAccount.Balance = Homeloanplan.Balance;
                    transaction.IdAccountSender = Homeloanplan.IdAccount;
                    Debit_Retrait();
                    Homeloanplan.Balance = BankAccount.Balance;
                    break;
                default:
                    break;
            }
        }

        public void Debit_Retrait()
        {
            if (RadioButton_Depot.Checked)
            {
                BankAccount.Deposit(transaction.Amount);
                transaction.Action = RadioButton_Depot.Text;
                MessageBox.Show("Transaction effectuée");
            }
            else if (RadioButton_Retrait.Checked)
            {
                BankAccount.Withdrawal(transaction.Amount);
                transaction.Action = RadioButton_Retrait.Text;
                MessageBox.Show("Transaction effectuée");
            }
            BankAccount.IdPerson = person.IdPerson;
            BankAccount.UpdateBalance();
            transaction.InsertTransaction();
        }

        // Ajouter un label qui affiche quand la transac a été effectuée
        // Bouton qui effectue un dépot ou un retrait
        private void button_DebitRetrait_Click(object sender, EventArgs e)
        {
            try
            {
                Debit_RetraitTransac();
                TextBox_Montant.Clear(); // Vide le input qui contient le montant de la transaction
                UpdateListeComptesDepRet(); // Actualise le solde des comptes
            }
            catch
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }

        
        // Module de virement
        private void VirementTransac()
        {
            string selectedAccountRece = ListBox_CompteExpediteur.SelectedItem.ToString();
            string selectedAccountDest = ListBox_CompteDestinataire.SelectedItem.ToString();
            transaction.IdTerminal = 1;
            transaction.Amount = float.Parse(TextBox_MontantVirement.Text);
            transaction.Action = "Virement";
            switch (selectedAccountRece)
            {
                case "Compte courrant":
                    if (selectedAccountDest == "Livret d'épargne")
                    {
                        Savingaccount.Deposit(transaction.Amount);
                        Savingaccount.UpdateBalance(); // Mettre a jour la balance du compte du destinataire
                        transaction.IdReceiver = Savingaccount.IdAccount;
                    }
                    else if (selectedAccountDest == "Compte épargne logement")
                    {
                        Homeloanplan.Deposit(transaction.Amount);
                        Homeloanplan.UpdateBalance(); // Mettre a jour la balance du compte du destinataire
                        transaction.IdReceiver = Homeloanplan.IdAccount;
                    }
                    else
                    {
                        // A terminer // Non fonctionnel !!!
                        aRecipient.Name = selectedAccountDest;
                        foreach (DataRow dr in aRecipient.SelectRecipientByName().Rows)
                        {
                            transaction.IdReceiver = int.Parse(dr["ACCOUNTNUMBER"].ToString());
                            transaction.InsertTransaction();
                        }
                        AccountByType();
                        BankAccount.IdAccount = transaction.IdReceiver;
                        foreach (DataRow dr in BankAccount.selectaAccountById().Rows)
                        {
                            BankAccount.Balance = int.Parse(dr["BALANCE"].ToString());                            
                        }                                                                    
                        BankAccount.Deposit(transaction.Amount);
                        BankAccount.UpdateBalance2();
                    }
                    SelectCurrentAccount();
                    Currentaccount.Withdrawal(transaction.Amount);
                    Currentaccount.UpdateBalance();  // Mettre a jour la balance du compte de l'expediteur
                    // Currentaccount.IdPerson = transaction.IdReceiver;
                    // Currentaccount.IdPerson = person.IdPerson;
                    transaction.IdAccountSender = Currentaccount.IdAccount; // Enregistrer l'id du compte débité
                    transaction.InsertTransaction();
                    break;
                case "Livret d'épargne":
                    if (selectedAccountDest == "Compte courrant")
                    {
                        Currentaccount.Deposit(transaction.Amount);
                        Currentaccount.UpdateBalance(); // Mettre a jour la balance du compte du destinataire
                        transaction.IdReceiver = Currentaccount.IdAccount;
                    }
                    else if (selectedAccountDest == "Compte épargne logement")
                    {
                        Homeloanplan.Deposit(transaction.Amount);
                        Homeloanplan.UpdateBalance(); // Mettre a jour la balance du compte du destinataire
                        transaction.IdReceiver = Homeloanplan.IdAccount;
                    }
                    else
                    {
                        aRecipient.Name = selectedAccountDest;
                        foreach (DataRow dr in aRecipient.SelectRecipientByName().Rows)
                        {
                            transaction.IdReceiver = int.Parse(dr["ACCOUNTNUMBER"].ToString());
                            transaction.InsertTransaction();
                        }
                        // Selectionner la balance du compte a qui faire le virement
                        AccountByType();
                        BankAccount.IdAccount = transaction.IdReceiver;
                        foreach (DataRow dr in BankAccount.selectaAccountById().Rows)
                        {
                            BankAccount.Balance = int.Parse(dr["BALANCE"].ToString());
                        }
                        BankAccount.Deposit(transaction.Amount);
                        BankAccount.UpdateBalance2();
                    }
                    SelectSavingAccount();
                    Savingaccount.Withdrawal(transaction.Amount);
                    Savingaccount.UpdateBalance();
                    // Savingaccount.IdPerson = transaction.IdReceiver;
                    // Savingaccount.IdPerson = person.IdPerson;
                    transaction.IdAccountSender = Savingaccount.IdAccount;
                    transaction.InsertTransaction();
                    break;
                case "Compte épargne logement":
                    if (selectedAccountDest == "Compte courrant")
                    {
                        Currentaccount.Deposit(transaction.Amount);
                        Currentaccount.UpdateBalance(); // Mettre a jour la balance du compte du destinataire
                        transaction.IdReceiver = Currentaccount.IdAccount;
                    }
                    else if (selectedAccountDest == "Livret d'épargne")
                    {
                        Savingaccount.Deposit(transaction.Amount);
                        Savingaccount.UpdateBalance(); // Mettre a jour la balance du compte du destinataire
                        transaction.IdReceiver = Savingaccount.IdAccount;
                    }
                    else
                    {
                        aRecipient.Name = selectedAccountDest;
                        foreach (DataRow dr in aRecipient.SelectRecipientByName().Rows)
                        {
                            transaction.IdReceiver = int.Parse(dr["ACCOUNTNUMBER"].ToString());
                            transaction.InsertTransaction();
                        }
                        // Selectionner la balance du compte a qui faire le virement
                        AccountByType();
                        BankAccount.IdAccount = transaction.IdReceiver;
                        foreach (DataRow dr in BankAccount.selectaAccountById().Rows)
                        {
                            BankAccount.Balance = int.Parse(dr["BALANCE"].ToString());
                        }
                        BankAccount.Deposit(transaction.Amount);
                        BankAccount.UpdateBalance2();
                    }
                    SelectHomeloanPlan();
                    Homeloanplan.Withdrawal(transaction.Amount);
                    Homeloanplan.UpdateBalance();
                    // Homeloanplan.IdPerson = transaction.IdReceiver;
                    // Homeloanplan.IdPerson = person.IdPerson;
                    transaction.IdAccountSender = Homeloanplan.IdAccount;
                    transaction.InsertTransaction();
                    break;
                default:                    
                    break;
            }
        }

        // Procédure pour attribuer le type de compte à l'interface
        private void AccountByType()
        {
            int id = 0;
            foreach (DataRow dr in aRecipient.SelectIdType().Rows)
            {
                id = int.Parse(dr["IDACCOUNTTYPE"].ToString());
            }            
            switch (id)
            {
                case 1:
                    BankAccount = new CurrentAccount();
                    break;
                case 2:
                    BankAccount = new SavingAccount();
                    break;
                case 3:
                    BankAccount = new HomeLoanPlan();
                    break;
            }
        }
        private void Button_ValiderVirement_Click(object sender, EventArgs e)
        {
            try
            {
                VirementTransac();
                UpdateListeComptesVirements();
                TextBox_MontantVirement.Clear(); // Vider le champs avec le montant du virement précedement effectué
                MessageBox.Show("Virement effectué");
            }
            catch
            {
                MessageBox.Show("Problème lors du virement");
            }
        }

        private void UpdateListeComptesVirements()
        {
            string aItem = ListBox_CompteExpediteur.SelectedItem.ToString();
            switch (aItem)
            {
                case "Compte courrant":
                    Label_SoldeVirement.Text = "Solde : " + Currentaccount.Balance; // Afficher le solde du compte                                    
                    break;
                case "Livret d'épargne":
                    Label_SoldeVirement.Text = "Solde : " + Savingaccount.Balance; // Afficher le solde du compte                    
                    break;
                case "Compte épargne logement":
                    Label_SoldeVirement.Text = "Solde : " + Homeloanplan.Balance; // Afficher le solde du compte
                    break;
                default:
                    break;
            }
        }

        // Affiche les transactions effectuées sur le compte courrant
        private void DisplayTransactions()
        {
            dataGridView_HistoriqueTransaction.DataSource = null;
            transaction.IdAccountSender = Currentaccount.IdAccount;
            transaction.SelectTransactionFor();
            dataGridView_HistoriqueTransaction.DataSource = transaction.SelectTransactionFor();
        }

        private void DisplayAccountVirement()
        {
            if (person.SelectCurrentAccount().Rows.Count == 1)
            {
                ListBox_CompteExpediteur.Items.Add("Compte courrant");
            }
            if (person.SelectSavingAccount().Rows.Count == 1)
            {
                ListBox_CompteExpediteur.Items.Add("Livret d'épargne");
            }
            if (person.SelectHomeloanplan().Rows.Count == 1)
            {
                ListBox_CompteExpediteur.Items.Add("Compte épargne logement");
            }
        }

        private void DisplayAccountVirementDes()
        {
            if (person.SelectCurrentAccount().Rows.Count == 1)
            {
                ListBox_CompteDestinataire.Items.Add("Compte courrant");
            }
            if (person.SelectSavingAccount().Rows.Count == 1)
            {
                ListBox_CompteDestinataire.Items.Add("Livret d'épargne");
            }
            if (person.SelectHomeloanplan().Rows.Count == 1)
            {
                ListBox_CompteDestinataire.Items.Add("Compte épargne logement");
            }

            // Sélectionner tous les bénéficiaires créés qui ont comme IDPERSON l'ID de l'user

            aRecipient.IdPerson = person.IdPerson;
            foreach (DataRow dr in aRecipient.SelectAllRecipientFor().Rows)
            {
                ListBox_CompteDestinataire.Items.Add(dr["NAME"].ToString());
            }
        }

        // Ne pas afficher le compte sélectionné dans le ListBox des virements
        private void DeleteSelectedAccount()
        {
            string selectedItem = ListBox_CompteExpediteur.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Compte courrant":
                    ListBox_CompteDestinataire.Items.Clear();
                    DisplayAccountVirementDes();
                    ListBox_CompteDestinataire.Items.Remove("Compte courrant");
                    break;
                case "Livret d'épargne":
                    ListBox_CompteDestinataire.Items.Clear();
                    DisplayAccountVirementDes();
                    ListBox_CompteDestinataire.Items.Remove("Livret d'épargne");
                    break;
                case "Compte épargne logement":
                    ListBox_CompteDestinataire.Items.Clear();
                    DisplayAccountVirementDes();
                    ListBox_CompteDestinataire.Items.Remove("Compte épargne logement");
                    break;
                default:
                    break;
            }
        }

        private void ListBox_CompteExpediteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListeComptesVirements();
            DeleteSelectedAccount();
        }

        // Met à jour l'affichage du solde des comptes dans le panel Dépot-Retrait
        private void UpdateListeComptesDepRet()
        {
            string aItem = ListBox_Compte.SelectedItem.ToString();
            switch (aItem)
            {
                case "Compte courrant":
                    label_Solde_Accout_DebRet.Text = "Solde : " + Currentaccount.Balance; // Afficher le solde du compte                                    
                    break;
                case "Livret d'épargne":
                    label_Solde_Accout_DebRet.Text = "Solde : " + Savingaccount.Balance; // Afficher le solde du compte                    
                    break;
                case "Compte épargne logement":
                    label_Solde_Accout_DebRet.Text = "Solde : " + Homeloanplan.Balance; // Afficher le solde du compte
                    break;
                default:
                    break;
            }
        }

        // Affiche le solde du compte sélectionné dans le textBox du panel Dépot-Retrait
        private void ListBox_Compte_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListeComptesDepRet();
        }

        private void Button_AccountCreation_Click(object sender, EventArgs e)
        {
            Panel_CreationCompte.BringToFront();
            Panel_CreationCompte.Visible = true;
        }

        public void AccountChoice()
        {
            ListBox_ChoixTypeCompte.Items.Clear();
            if (person.SelectCurrentAccount().Rows.Count == 0)
            {
                ListBox_ChoixTypeCompte.Items.Add("Compte courrant");
            }
            if (person.SelectSavingAccount().Rows.Count == 0)
            {
                ListBox_ChoixTypeCompte.Items.Add("Livret d'épargne");
            }
            if (person.SelectHomeloanplan().Rows.Count == 0)
            {
                ListBox_ChoixTypeCompte.Items.Add("Compte épargne logement");
            }
        }

        private IAccount NewAccount;

        private void CreateAccount()
        {
            NewAccount.IdPerson = person.IdPerson;
            NewAccount.Cap = 0;
            NewAccount.Balance = 0;
            NewAccount.CreateBankAccount();
        }
        private void Button_ValiderCreationCompte_Click_1(object sender, EventArgs e)
        {
            try
            {
                string selectedAccount = ListBox_ChoixTypeCompte.SelectedItem.ToString();
                if (selectedAccount == "Compte courrant")
                {
                    NewAccount = new CurrentAccount();
                    CreateAccount();
                }
                else if (selectedAccount == "Livret d'épargne")
                {
                    NewAccount = new SavingAccount();
                    CreateAccount();
                }
                else if (selectedAccount == "Compte épargne logement")
                {
                    NewAccount = new HomeLoanPlan();
                    CreateAccount();
                }
                MessageBox.Show("Compte crée");
                SelectCurrentAccount();
                SelectSavingAccount();
                SelectHomeloanPlan();
                DisplayAccount();
                DisplayAccountVirement(); // Actualiser Comptes virements
                AccountChoice(); // Actualiser la liste des comptes disponnibles à créer
                Show_Account_Data();
            }
            catch
            {
                MessageBox.Show("Erreur de création de compte");
            }

        }

        private void Button_RDV_Click(object sender, EventArgs e)
        {
            Panel_RDV.BringToFront();
            Panel_RDV.Visible = true;
        }

        private void Label_Solde1_Click(object sender, EventArgs e)
        {

        }

        private void Label_SoldeTexte2_Click(object sender, EventArgs e)
        {

        }

        private void Label_NumeroCarte2_Click(object sender, EventArgs e)
        {

        }

        private void Label_Solde2_Click(object sender, EventArgs e)
        {

        }

        private void Label_SoldeTexte1_Click(object sender, EventArgs e)
        {

        }

        private void Label_Solde3_Click(object sender, EventArgs e)
        {

        }

        private void Label_NumeroCarte3_Click(object sender, EventArgs e)
        {

        }

        private void Button_Ajouter_Click(object sender, EventArgs e)
        {            
            aRecipient.Name = TextBox_AjouterNom.Text;
            aRecipient.AccountNumber = int.Parse(TextBox_AjouterIdentifiant.Text);
            aRecipient.IdPerson = person.IdPerson;

            // Vérifier que le compte n'existe pas déjà

            if(aRecipient.Name != "Compte courrant" && aRecipient.Name != "Livret d'épargne" && aRecipient.Name != "Compte épargne logement")
            {
                foreach (DataRow dr in aRecipient.SelectAllRecipient().Rows)
                {
                    if (dr["NAME"].ToString() != aRecipient.Name)
                    {
                        aRecipient.InsertRecipient();
                    }
                    else
                    {
                        MessageBox.Show("Le nom ne peut pas être celui d'un compte existant");
                    }
                }
            }
            else
            {
                MessageBox.Show("Le nom ne peut pas être celui d'un compte existant");
            }            
        }
    }
}
