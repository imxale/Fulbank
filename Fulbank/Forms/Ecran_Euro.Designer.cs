
namespace Fulbank
{
    partial class Ecran_Euro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 500D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 50D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2000D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ecran_Euro));
            this.Button_Deconnexion = new System.Windows.Forms.Button();
            this.Label_Identifiant = new System.Windows.Forms.Label();
            this.Label_NomPrenom = new System.Windows.Forms.Label();
            this.Panel_EcranEuro = new System.Windows.Forms.Panel();
            this.Button_GererWallet = new System.Windows.Forms.Button();
            this.Button_RDV = new System.Windows.Forms.Button();
            this.Button_AccountCreation = new System.Windows.Forms.Button();
            this.Button_DepotRetrait = new System.Windows.Forms.Button();
            this.Button_Virement = new System.Windows.Forms.Button();
            this.Button_Crypto = new System.Windows.Forms.Button();
            this.Button_Euro = new System.Windows.Forms.Button();
            this.Panel_GererWallet = new System.Windows.Forms.Panel();
            this.button_DeleteWallet = new System.Windows.Forms.Button();
            this.button_ChangeName = new System.Windows.Forms.Button();
            this.label_ChangeWalletName = new System.Windows.Forms.Label();
            this.textBox_ChangeWalletName = new System.Windows.Forms.TextBox();
            this.label_WalletClient = new System.Windows.Forms.Label();
            this.dataGridView_WalletClient = new System.Windows.Forms.DataGridView();
            this.Button_WalletAjout = new System.Windows.Forms.Button();
            this.Label_NomWalletAjout = new System.Windows.Forms.Label();
            this.ListBox_TypeWalletAjout = new System.Windows.Forms.ListBox();
            this.TextBox_NomWalletAjout = new System.Windows.Forms.TextBox();
            this.Panel_DC_Crypto = new System.Windows.Forms.Panel();
            this.Label_TitreData_Droite = new System.Windows.Forms.Label();
            this.Label_TitreData_Gauche = new System.Windows.Forms.Label();
            this.dataGridView_Portefeuille = new System.Windows.Forms.DataGridView();
            this.dataGridView_CoursCrypto = new System.Windows.Forms.DataGridView();
            this.groupBox_Crypto = new System.Windows.Forms.GroupBox();
            this.Button_ValiderCrypto_Vente = new System.Windows.Forms.Button();
            this.Button_ValiderCrypto_Achat = new System.Windows.Forms.Button();
            this.TextBox_QTECrypto = new System.Windows.Forms.TextBox();
            this.Label_NomCrypto_Acheter = new System.Windows.Forms.Label();
            this.Label_CurrentAccount = new System.Windows.Forms.Label();
            this.Panel_DC_Euro = new System.Windows.Forms.Panel();
            this.Label_HistoriqueTransactions = new System.Windows.Forms.Label();
            this.dataGridView_HistoriqueTransaction = new System.Windows.Forms.DataGridView();
            this.idTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WalletName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chart_RevenuesMois = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chart_DepensesMois = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Label_DC_Solde = new System.Windows.Forms.Label();
            this.Label_DC_NumeroCompte = new System.Windows.Forms.Label();
            this.Chart_Depenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Panel_CreationCompte = new System.Windows.Forms.Panel();
            this.Label_TitreCreationCompte = new System.Windows.Forms.Label();
            this.Label_ChoixTypeCompte = new System.Windows.Forms.Label();
            this.Button_ValiderCreationCompte = new System.Windows.Forms.Button();
            this.ListBox_ChoixTypeCompte = new System.Windows.Forms.ListBox();
            this.Panel_RDV = new System.Windows.Forms.Panel();
            this.GroupBox_Conseiller = new System.Windows.Forms.GroupBox();
            this.Label_Conseiller = new System.Windows.Forms.Label();
            this.Label_NOMConseiller = new System.Windows.Forms.Label();
            this.Button_RDVEnvoyer = new System.Windows.Forms.Button();
            this.RichTextBox_RaisonRDV = new System.Windows.Forms.RichTextBox();
            this.ListBox_RaisonRDV = new System.Windows.Forms.ListBox();
            this.Panel_ChoixCompte = new System.Windows.Forms.Panel();
            this.Panel_Compte3 = new System.Windows.Forms.Panel();
            this.Label_Solde3 = new System.Windows.Forms.Label();
            this.Label_NumeroCarte3 = new System.Windows.Forms.Label();
            this.Label_SoldeTexte3 = new System.Windows.Forms.Label();
            this.Label_NomCompte3 = new System.Windows.Forms.Label();
            this.Label_NumeroCompte3 = new System.Windows.Forms.Label();
            this.Panel_Compte2 = new System.Windows.Forms.Panel();
            this.Label_Solde2 = new System.Windows.Forms.Label();
            this.Label_NumeroCarte2 = new System.Windows.Forms.Label();
            this.Label_SoldeTexte2 = new System.Windows.Forms.Label();
            this.Label_NomCompte2 = new System.Windows.Forms.Label();
            this.Label_NumeroCompte2 = new System.Windows.Forms.Label();
            this.Panel_Compte1 = new System.Windows.Forms.Panel();
            this.Label_Solde1 = new System.Windows.Forms.Label();
            this.Label_NumeroCarte1 = new System.Windows.Forms.Label();
            this.Label_SoldeTexte1 = new System.Windows.Forms.Label();
            this.Label_NomCompte1 = new System.Windows.Forms.Label();
            this.Label_NumeroCompte1 = new System.Windows.Forms.Label();
            this.Panel_DepotRetrait = new System.Windows.Forms.Panel();
            this.label_Solde_Accout_DebRet = new System.Windows.Forms.Label();
            this.button_DebitRetrait = new System.Windows.Forms.Button();
            this.Label_TitreDepotRetrait = new System.Windows.Forms.Label();
            this.RadioButton_Retrait = new System.Windows.Forms.RadioButton();
            this.RadioButton_Depot = new System.Windows.Forms.RadioButton();
            this.Label_MontantDebitRetrait = new System.Windows.Forms.Label();
            this.TextBox_Montant = new System.Windows.Forms.TextBox();
            this.ListBox_Compte = new System.Windows.Forms.ListBox();
            this.Panel_Virement = new System.Windows.Forms.Panel();
            this.Label_TitreVirement = new System.Windows.Forms.Label();
            this.Label_AjouterNom = new System.Windows.Forms.Label();
            this.Button_Ajouter = new System.Windows.Forms.Button();
            this.TextBox_AjouterNom = new System.Windows.Forms.TextBox();
            this.TextBox_AjouterIdentifiant = new System.Windows.Forms.TextBox();
            this.Label_AjouterIdentifiant = new System.Windows.Forms.Label();
            this.Label_AjouterBeneficiaire = new System.Windows.Forms.Label();
            this.Label_SoldeVirement = new System.Windows.Forms.Label();
            this.ListBox_CompteDestinataire = new System.Windows.Forms.ListBox();
            this.Button_ValiderVirement = new System.Windows.Forms.Button();
            this.Label_MontantVirement = new System.Windows.Forms.Label();
            this.TextBox_MontantVirement = new System.Windows.Forms.TextBox();
            this.ListBox_CompteExpediteur = new System.Windows.Forms.ListBox();
            this.Label_Role = new System.Windows.Forms.Label();
            this.listBox_recipientList = new System.Windows.Forms.ListBox();
            this.button_DeleteRecipient = new System.Windows.Forms.Button();
            this.Panel_EcranEuro.SuspendLayout();
            this.Panel_GererWallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WalletClient)).BeginInit();
            this.Panel_DC_Crypto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Portefeuille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CoursCrypto)).BeginInit();
            this.groupBox_Crypto.SuspendLayout();
            this.Panel_DC_Euro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HistoriqueTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_RevenuesMois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_DepensesMois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Depenses)).BeginInit();
            this.Panel_CreationCompte.SuspendLayout();
            this.Panel_RDV.SuspendLayout();
            this.GroupBox_Conseiller.SuspendLayout();
            this.Panel_ChoixCompte.SuspendLayout();
            this.Panel_Compte3.SuspendLayout();
            this.Panel_Compte2.SuspendLayout();
            this.Panel_Compte1.SuspendLayout();
            this.Panel_DepotRetrait.SuspendLayout();
            this.Panel_Virement.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Deconnexion
            // 
            this.Button_Deconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Deconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Button_Deconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Deconnexion.ForeColor = System.Drawing.Color.White;
            this.Button_Deconnexion.Location = new System.Drawing.Point(1163, 12);
            this.Button_Deconnexion.Name = "Button_Deconnexion";
            this.Button_Deconnexion.Size = new System.Drawing.Size(188, 59);
            this.Button_Deconnexion.TabIndex = 0;
            this.Button_Deconnexion.Text = "Déconnexion";
            this.Button_Deconnexion.UseVisualStyleBackColor = false;
            this.Button_Deconnexion.Click += new System.EventHandler(this.Button_Deconnexion_Click);
            // 
            // Label_Identifiant
            // 
            this.Label_Identifiant.AutoSize = true;
            this.Label_Identifiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Label_Identifiant.ForeColor = System.Drawing.Color.White;
            this.Label_Identifiant.Location = new System.Drawing.Point(12, 12);
            this.Label_Identifiant.Name = "Label_Identifiant";
            this.Label_Identifiant.Size = new System.Drawing.Size(53, 13);
            this.Label_Identifiant.TabIndex = 1;
            this.Label_Identifiant.Text = "Identifiant";
            // 
            // Label_NomPrenom
            // 
            this.Label_NomPrenom.AutoSize = true;
            this.Label_NomPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Label_NomPrenom.ForeColor = System.Drawing.Color.White;
            this.Label_NomPrenom.Location = new System.Drawing.Point(12, 58);
            this.Label_NomPrenom.Name = "Label_NomPrenom";
            this.Label_NomPrenom.Size = new System.Drawing.Size(65, 13);
            this.Label_NomPrenom.TabIndex = 2;
            this.Label_NomPrenom.Text = "NomPrenom";
            // 
            // Panel_EcranEuro
            // 
            this.Panel_EcranEuro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_EcranEuro.AutoScroll = true;
            this.Panel_EcranEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Panel_EcranEuro.Controls.Add(this.Button_GererWallet);
            this.Panel_EcranEuro.Controls.Add(this.Button_RDV);
            this.Panel_EcranEuro.Controls.Add(this.Button_AccountCreation);
            this.Panel_EcranEuro.Controls.Add(this.Button_DepotRetrait);
            this.Panel_EcranEuro.Controls.Add(this.Button_Virement);
            this.Panel_EcranEuro.Controls.Add(this.Button_Crypto);
            this.Panel_EcranEuro.Controls.Add(this.Button_Euro);
            this.Panel_EcranEuro.Controls.Add(this.Panel_Virement);
            this.Panel_EcranEuro.Controls.Add(this.Panel_GererWallet);
            this.Panel_EcranEuro.Controls.Add(this.Panel_DC_Crypto);
            this.Panel_EcranEuro.Controls.Add(this.Panel_DC_Euro);
            this.Panel_EcranEuro.Controls.Add(this.Panel_CreationCompte);
            this.Panel_EcranEuro.Controls.Add(this.Panel_RDV);
            this.Panel_EcranEuro.Controls.Add(this.Panel_ChoixCompte);
            this.Panel_EcranEuro.Controls.Add(this.Panel_DepotRetrait);
            this.Panel_EcranEuro.Location = new System.Drawing.Point(15, 253);
            this.Panel_EcranEuro.Name = "Panel_EcranEuro";
            this.Panel_EcranEuro.Size = new System.Drawing.Size(1330, 483);
            this.Panel_EcranEuro.TabIndex = 3;
            // 
            // Button_GererWallet
            // 
            this.Button_GererWallet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_GererWallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.Button_GererWallet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_GererWallet.Location = new System.Drawing.Point(735, 16);
            this.Button_GererWallet.Name = "Button_GererWallet";
            this.Button_GererWallet.Size = new System.Drawing.Size(102, 23);
            this.Button_GererWallet.TabIndex = 27;
            this.Button_GererWallet.Text = "Gérer vos Wallet";
            this.Button_GererWallet.UseVisualStyleBackColor = false;
            this.Button_GererWallet.Visible = false;
            this.Button_GererWallet.Click += new System.EventHandler(this.Button_GererWallet_Click);
            // 
            // Button_RDV
            // 
            this.Button_RDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_RDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.Button_RDV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_RDV.Location = new System.Drawing.Point(876, 16);
            this.Button_RDV.Name = "Button_RDV";
            this.Button_RDV.Size = new System.Drawing.Size(102, 23);
            this.Button_RDV.TabIndex = 24;
            this.Button_RDV.Text = "Prendre un RDV";
            this.Button_RDV.UseVisualStyleBackColor = false;
            this.Button_RDV.Click += new System.EventHandler(this.Button_RDV_Click);
            // 
            // Button_AccountCreation
            // 
            this.Button_AccountCreation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_AccountCreation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.Button_AccountCreation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_AccountCreation.Location = new System.Drawing.Point(1000, 16);
            this.Button_AccountCreation.Name = "Button_AccountCreation";
            this.Button_AccountCreation.Size = new System.Drawing.Size(102, 23);
            this.Button_AccountCreation.TabIndex = 23;
            this.Button_AccountCreation.Text = "Créer un compte";
            this.Button_AccountCreation.UseVisualStyleBackColor = false;
            this.Button_AccountCreation.Click += new System.EventHandler(this.Button_AccountCreation_Click);
            // 
            // Button_DepotRetrait
            // 
            this.Button_DepotRetrait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_DepotRetrait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.Button_DepotRetrait.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_DepotRetrait.Location = new System.Drawing.Point(1119, 16);
            this.Button_DepotRetrait.Name = "Button_DepotRetrait";
            this.Button_DepotRetrait.Size = new System.Drawing.Size(102, 23);
            this.Button_DepotRetrait.TabIndex = 5;
            this.Button_DepotRetrait.Text = "Dépot - Retrait";
            this.Button_DepotRetrait.UseVisualStyleBackColor = false;
            this.Button_DepotRetrait.Click += new System.EventHandler(this.Button_DepotRetrait_Click);
            // 
            // Button_Virement
            // 
            this.Button_Virement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Virement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.Button_Virement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Virement.Location = new System.Drawing.Point(1236, 16);
            this.Button_Virement.Name = "Button_Virement";
            this.Button_Virement.Size = new System.Drawing.Size(75, 23);
            this.Button_Virement.TabIndex = 4;
            this.Button_Virement.Text = "Virement";
            this.Button_Virement.UseVisualStyleBackColor = false;
            this.Button_Virement.Click += new System.EventHandler(this.Button_Virement_Click);
            // 
            // Button_Crypto
            // 
            this.Button_Crypto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.Button_Crypto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Crypto.Location = new System.Drawing.Point(134, 16);
            this.Button_Crypto.Name = "Button_Crypto";
            this.Button_Crypto.Size = new System.Drawing.Size(75, 23);
            this.Button_Crypto.TabIndex = 3;
            this.Button_Crypto.Text = "Crypto";
            this.Button_Crypto.UseVisualStyleBackColor = false;
            this.Button_Crypto.Click += new System.EventHandler(this.Button_Crypto_Click);
            // 
            // Button_Euro
            // 
            this.Button_Euro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.Button_Euro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Euro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Euro.Location = new System.Drawing.Point(14, 16);
            this.Button_Euro.Name = "Button_Euro";
            this.Button_Euro.Size = new System.Drawing.Size(75, 23);
            this.Button_Euro.TabIndex = 2;
            this.Button_Euro.Text = "Euro";
            this.Button_Euro.UseVisualStyleBackColor = false;
            this.Button_Euro.Click += new System.EventHandler(this.Button_Euro_Click);
            // 
            // Panel_GererWallet
            // 
            this.Panel_GererWallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_GererWallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.Panel_GererWallet.Controls.Add(this.button_DeleteWallet);
            this.Panel_GererWallet.Controls.Add(this.button_ChangeName);
            this.Panel_GererWallet.Controls.Add(this.label_ChangeWalletName);
            this.Panel_GererWallet.Controls.Add(this.textBox_ChangeWalletName);
            this.Panel_GererWallet.Controls.Add(this.label_WalletClient);
            this.Panel_GererWallet.Controls.Add(this.dataGridView_WalletClient);
            this.Panel_GererWallet.Controls.Add(this.Button_WalletAjout);
            this.Panel_GererWallet.Controls.Add(this.Label_NomWalletAjout);
            this.Panel_GererWallet.Controls.Add(this.ListBox_TypeWalletAjout);
            this.Panel_GererWallet.Controls.Add(this.TextBox_NomWalletAjout);
            this.Panel_GererWallet.Location = new System.Drawing.Point(14, 56);
            this.Panel_GererWallet.Name = "Panel_GererWallet";
            this.Panel_GererWallet.Size = new System.Drawing.Size(1297, 387);
            this.Panel_GererWallet.TabIndex = 28;
            this.Panel_GererWallet.Visible = false;
            // 
            // button_DeleteWallet
            // 
            this.button_DeleteWallet.Location = new System.Drawing.Point(1002, 107);
            this.button_DeleteWallet.Name = "button_DeleteWallet";
            this.button_DeleteWallet.Size = new System.Drawing.Size(115, 23);
            this.button_DeleteWallet.TabIndex = 9;
            this.button_DeleteWallet.Text = "Supprimer";
            this.button_DeleteWallet.UseVisualStyleBackColor = true;
            this.button_DeleteWallet.Click += new System.EventHandler(this.button_DeleteWallet_Click);
            // 
            // button_ChangeName
            // 
            this.button_ChangeName.Location = new System.Drawing.Point(1002, 68);
            this.button_ChangeName.Name = "button_ChangeName";
            this.button_ChangeName.Size = new System.Drawing.Size(115, 23);
            this.button_ChangeName.TabIndex = 8;
            this.button_ChangeName.Text = "Changer le nom";
            this.button_ChangeName.UseVisualStyleBackColor = true;
            this.button_ChangeName.Click += new System.EventHandler(this.button_ChangeName_Click);
            // 
            // label_ChangeWalletName
            // 
            this.label_ChangeWalletName.AutoSize = true;
            this.label_ChangeWalletName.Location = new System.Drawing.Point(879, 50);
            this.label_ChangeWalletName.Name = "label_ChangeWalletName";
            this.label_ChangeWalletName.Size = new System.Drawing.Size(78, 13);
            this.label_ChangeWalletName.TabIndex = 7;
            this.label_ChangeWalletName.Text = "Modifier le nom";
            // 
            // textBox_ChangeWalletName
            // 
            this.textBox_ChangeWalletName.Location = new System.Drawing.Point(879, 70);
            this.textBox_ChangeWalletName.Name = "textBox_ChangeWalletName";
            this.textBox_ChangeWalletName.Size = new System.Drawing.Size(100, 20);
            this.textBox_ChangeWalletName.TabIndex = 6;
            // 
            // label_WalletClient
            // 
            this.label_WalletClient.AutoSize = true;
            this.label_WalletClient.Location = new System.Drawing.Point(367, 30);
            this.label_WalletClient.Name = "label_WalletClient";
            this.label_WalletClient.Size = new System.Drawing.Size(62, 13);
            this.label_WalletClient.TabIndex = 5;
            this.label_WalletClient.Text = "Liste Wallet";
            // 
            // dataGridView_WalletClient
            // 
            this.dataGridView_WalletClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_WalletClient.Location = new System.Drawing.Point(370, 49);
            this.dataGridView_WalletClient.Name = "dataGridView_WalletClient";
            this.dataGridView_WalletClient.Size = new System.Drawing.Size(447, 289);
            this.dataGridView_WalletClient.TabIndex = 4;
            this.dataGridView_WalletClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_WalletClient_CellClick);
            // 
            // Button_WalletAjout
            // 
            this.Button_WalletAjout.Location = new System.Drawing.Point(131, 209);
            this.Button_WalletAjout.Name = "Button_WalletAjout";
            this.Button_WalletAjout.Size = new System.Drawing.Size(75, 23);
            this.Button_WalletAjout.TabIndex = 3;
            this.Button_WalletAjout.Text = "Ajouter";
            this.Button_WalletAjout.UseVisualStyleBackColor = true;
            this.Button_WalletAjout.Click += new System.EventHandler(this.Button_WalletAjout_Click);
            // 
            // Label_NomWalletAjout
            // 
            this.Label_NomWalletAjout.AutoSize = true;
            this.Label_NomWalletAjout.Location = new System.Drawing.Point(60, 73);
            this.Label_NomWalletAjout.Name = "Label_NomWalletAjout";
            this.Label_NomWalletAjout.Size = new System.Drawing.Size(77, 13);
            this.Label_NomWalletAjout.TabIndex = 2;
            this.Label_NomWalletAjout.Text = "Nom du Wallet";
            // 
            // ListBox_TypeWalletAjout
            // 
            this.ListBox_TypeWalletAjout.FormattingEnabled = true;
            this.ListBox_TypeWalletAjout.Location = new System.Drawing.Point(177, 89);
            this.ListBox_TypeWalletAjout.Name = "ListBox_TypeWalletAjout";
            this.ListBox_TypeWalletAjout.Size = new System.Drawing.Size(120, 95);
            this.ListBox_TypeWalletAjout.TabIndex = 1;
            // 
            // TextBox_NomWalletAjout
            // 
            this.TextBox_NomWalletAjout.Location = new System.Drawing.Point(63, 89);
            this.TextBox_NomWalletAjout.Name = "TextBox_NomWalletAjout";
            this.TextBox_NomWalletAjout.Size = new System.Drawing.Size(100, 20);
            this.TextBox_NomWalletAjout.TabIndex = 0;
            // 
            // Panel_DC_Crypto
            // 
            this.Panel_DC_Crypto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_DC_Crypto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.Panel_DC_Crypto.Controls.Add(this.Label_TitreData_Droite);
            this.Panel_DC_Crypto.Controls.Add(this.Label_TitreData_Gauche);
            this.Panel_DC_Crypto.Controls.Add(this.dataGridView_Portefeuille);
            this.Panel_DC_Crypto.Controls.Add(this.dataGridView_CoursCrypto);
            this.Panel_DC_Crypto.Controls.Add(this.groupBox_Crypto);
            this.Panel_DC_Crypto.Controls.Add(this.Label_CurrentAccount);
            this.Panel_DC_Crypto.Location = new System.Drawing.Point(14, 56);
            this.Panel_DC_Crypto.Name = "Panel_DC_Crypto";
            this.Panel_DC_Crypto.Size = new System.Drawing.Size(1297, 387);
            this.Panel_DC_Crypto.TabIndex = 22;
            this.Panel_DC_Crypto.Visible = false;
            // 
            // Label_TitreData_Droite
            // 
            this.Label_TitreData_Droite.AutoSize = true;
            this.Label_TitreData_Droite.Location = new System.Drawing.Point(841, 48);
            this.Label_TitreData_Droite.Name = "Label_TitreData_Droite";
            this.Label_TitreData_Droite.Size = new System.Drawing.Size(102, 13);
            this.Label_TitreData_Droite.TabIndex = 21;
            this.Label_TitreData_Droite.Text = "Contenu Portefeuille";
            // 
            // Label_TitreData_Gauche
            // 
            this.Label_TitreData_Gauche.AutoSize = true;
            this.Label_TitreData_Gauche.Location = new System.Drawing.Point(39, 49);
            this.Label_TitreData_Gauche.Name = "Label_TitreData_Gauche";
            this.Label_TitreData_Gauche.Size = new System.Drawing.Size(67, 13);
            this.Label_TitreData_Gauche.TabIndex = 20;
            this.Label_TitreData_Gauche.Text = "Cours Crypto";
            // 
            // dataGridView_Portefeuille
            // 
            this.dataGridView_Portefeuille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Portefeuille.Location = new System.Drawing.Point(839, 65);
            this.dataGridView_Portefeuille.Name = "dataGridView_Portefeuille";
            this.dataGridView_Portefeuille.Size = new System.Drawing.Size(434, 284);
            this.dataGridView_Portefeuille.TabIndex = 19;
            this.dataGridView_Portefeuille.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Portefeuille_CellContentClick_1);
            // 
            // dataGridView_CoursCrypto
            // 
            this.dataGridView_CoursCrypto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CoursCrypto.Location = new System.Drawing.Point(35, 65);
            this.dataGridView_CoursCrypto.Name = "dataGridView_CoursCrypto";
            this.dataGridView_CoursCrypto.Size = new System.Drawing.Size(386, 284);
            this.dataGridView_CoursCrypto.TabIndex = 18;
            this.dataGridView_CoursCrypto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CoursCrypto_CellClick);
            // 
            // groupBox_Crypto
            // 
            this.groupBox_Crypto.Controls.Add(this.Button_ValiderCrypto_Vente);
            this.groupBox_Crypto.Controls.Add(this.Button_ValiderCrypto_Achat);
            this.groupBox_Crypto.Controls.Add(this.TextBox_QTECrypto);
            this.groupBox_Crypto.Controls.Add(this.Label_NomCrypto_Acheter);
            this.groupBox_Crypto.Location = new System.Drawing.Point(466, 73);
            this.groupBox_Crypto.Name = "groupBox_Crypto";
            this.groupBox_Crypto.Size = new System.Drawing.Size(332, 246);
            this.groupBox_Crypto.TabIndex = 17;
            this.groupBox_Crypto.TabStop = false;
            // 
            // Button_ValiderCrypto_Vente
            // 
            this.Button_ValiderCrypto_Vente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(52)))), ((int)(((byte)(228)))));
            this.Button_ValiderCrypto_Vente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_ValiderCrypto_Vente.Location = new System.Drawing.Point(164, 138);
            this.Button_ValiderCrypto_Vente.Name = "Button_ValiderCrypto_Vente";
            this.Button_ValiderCrypto_Vente.Size = new System.Drawing.Size(75, 23);
            this.Button_ValiderCrypto_Vente.TabIndex = 16;
            this.Button_ValiderCrypto_Vente.Text = "Vendre";
            this.Button_ValiderCrypto_Vente.UseVisualStyleBackColor = false;
            this.Button_ValiderCrypto_Vente.Click += new System.EventHandler(this.Button_ValiderCrypto_Vente_Click);
            // 
            // Button_ValiderCrypto_Achat
            // 
            this.Button_ValiderCrypto_Achat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(52)))), ((int)(((byte)(228)))));
            this.Button_ValiderCrypto_Achat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_ValiderCrypto_Achat.Location = new System.Drawing.Point(76, 138);
            this.Button_ValiderCrypto_Achat.Name = "Button_ValiderCrypto_Achat";
            this.Button_ValiderCrypto_Achat.Size = new System.Drawing.Size(75, 23);
            this.Button_ValiderCrypto_Achat.TabIndex = 15;
            this.Button_ValiderCrypto_Achat.Text = "Acheter";
            this.Button_ValiderCrypto_Achat.UseVisualStyleBackColor = false;
            this.Button_ValiderCrypto_Achat.Click += new System.EventHandler(this.Button_ValiderCrypto_Achat_Click);
            // 
            // TextBox_QTECrypto
            // 
            this.TextBox_QTECrypto.Location = new System.Drawing.Point(113, 91);
            this.TextBox_QTECrypto.Name = "TextBox_QTECrypto";
            this.TextBox_QTECrypto.Size = new System.Drawing.Size(100, 20);
            this.TextBox_QTECrypto.TabIndex = 5;
            // 
            // Label_NomCrypto_Acheter
            // 
            this.Label_NomCrypto_Acheter.AutoSize = true;
            this.Label_NomCrypto_Acheter.Location = new System.Drawing.Point(148, 68);
            this.Label_NomCrypto_Acheter.Name = "Label_NomCrypto_Acheter";
            this.Label_NomCrypto_Acheter.Size = new System.Drawing.Size(29, 13);
            this.Label_NomCrypto_Acheter.TabIndex = 9;
            this.Label_NomCrypto_Acheter.Text = "QTE";
            // 
            // Label_CurrentAccount
            // 
            this.Label_CurrentAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_CurrentAccount.AutoSize = true;
            this.Label_CurrentAccount.ForeColor = System.Drawing.Color.White;
            this.Label_CurrentAccount.Location = new System.Drawing.Point(463, 59);
            this.Label_CurrentAccount.Name = "Label_CurrentAccount";
            this.Label_CurrentAccount.Size = new System.Drawing.Size(123, 13);
            this.Label_CurrentAccount.TabIndex = 0;
            this.Label_CurrentAccount.Text = "Solde compte courrant : ";
            this.Label_CurrentAccount.Visible = false;
            // 
            // Panel_DC_Euro
            // 
            this.Panel_DC_Euro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_DC_Euro.AutoScroll = true;
            this.Panel_DC_Euro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.Panel_DC_Euro.Controls.Add(this.Label_HistoriqueTransactions);
            this.Panel_DC_Euro.Controls.Add(this.dataGridView_HistoriqueTransaction);
            this.Panel_DC_Euro.Controls.Add(this.Chart_RevenuesMois);
            this.Panel_DC_Euro.Controls.Add(this.Chart_DepensesMois);
            this.Panel_DC_Euro.Controls.Add(this.Label_DC_Solde);
            this.Panel_DC_Euro.Controls.Add(this.Label_DC_NumeroCompte);
            this.Panel_DC_Euro.Controls.Add(this.Chart_Depenses);
            this.Panel_DC_Euro.Location = new System.Drawing.Point(14, 56);
            this.Panel_DC_Euro.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_DC_Euro.Name = "Panel_DC_Euro";
            this.Panel_DC_Euro.Size = new System.Drawing.Size(1297, 387);
            this.Panel_DC_Euro.TabIndex = 21;
            this.Panel_DC_Euro.Visible = false;
            // 
            // Label_HistoriqueTransactions
            // 
            this.Label_HistoriqueTransactions.AutoSize = true;
            this.Label_HistoriqueTransactions.Location = new System.Drawing.Point(128, 46);
            this.Label_HistoriqueTransactions.Name = "Label_HistoriqueTransactions";
            this.Label_HistoriqueTransactions.Size = new System.Drawing.Size(138, 13);
            this.Label_HistoriqueTransactions.TabIndex = 9;
            this.Label_HistoriqueTransactions.Text = "Historique des Transactions";
            // 
            // dataGridView_HistoriqueTransaction
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dataGridView_HistoriqueTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_HistoriqueTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_HistoriqueTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_HistoriqueTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.dataGridView_HistoriqueTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_HistoriqueTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_HistoriqueTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_HistoriqueTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_HistoriqueTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HistoriqueTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransaction,
            this.TerminalName,
            this.WalletName,
            this.Amount,
            this.DateTrans,
            this.Action,
            this.NameDest,
            this.Account});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_HistoriqueTransaction.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_HistoriqueTransaction.GridColor = System.Drawing.Color.Black;
            this.dataGridView_HistoriqueTransaction.Location = new System.Drawing.Point(125, 69);
            this.dataGridView_HistoriqueTransaction.Name = "dataGridView_HistoriqueTransaction";
            this.dataGridView_HistoriqueTransaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_HistoriqueTransaction.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dataGridView_HistoriqueTransaction.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_HistoriqueTransaction.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.dataGridView_HistoriqueTransaction.Size = new System.Drawing.Size(1097, 292);
            this.dataGridView_HistoriqueTransaction.TabIndex = 8;
            // 
            // idTransaction
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idTransaction.DefaultCellStyle = dataGridViewCellStyle3;
            this.idTransaction.HeaderText = "Numéro Transaction";
            this.idTransaction.Name = "idTransaction";
            this.idTransaction.Visible = false;
            // 
            // TerminalName
            // 
            this.TerminalName.HeaderText = "Nom Terminal";
            this.TerminalName.Name = "TerminalName";
            this.TerminalName.Visible = false;
            // 
            // WalletName
            // 
            this.WalletName.HeaderText = "Nom Wallet";
            this.WalletName.Name = "WalletName";
            this.WalletName.Visible = false;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Montant";
            this.Amount.Name = "Amount";
            this.Amount.Visible = false;
            // 
            // DateTrans
            // 
            this.DateTrans.HeaderText = "Date Oppération";
            this.DateTrans.Name = "DateTrans";
            this.DateTrans.Visible = false;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Visible = false;
            // 
            // NameDest
            // 
            this.NameDest.HeaderText = "Nom destinataire";
            this.NameDest.Name = "NameDest";
            this.NameDest.Visible = false;
            // 
            // Account
            // 
            this.Account.HeaderText = "Nom Compte";
            this.Account.Name = "Account";
            this.Account.Visible = false;
            // 
            // Chart_RevenuesMois
            // 
            this.Chart_RevenuesMois.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Chart_RevenuesMois.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_RevenuesMois.Legends.Add(legend1);
            this.Chart_RevenuesMois.Location = new System.Drawing.Point(558, 1241);
            this.Chart_RevenuesMois.Name = "Chart_RevenuesMois";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart_RevenuesMois.Series.Add(series1);
            this.Chart_RevenuesMois.Size = new System.Drawing.Size(263, 300);
            this.Chart_RevenuesMois.TabIndex = 7;
            this.Chart_RevenuesMois.Text = "Dépenses";
            // 
            // Chart_DepensesMois
            // 
            this.Chart_DepensesMois.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.Chart_DepensesMois.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart_DepensesMois.Legends.Add(legend2);
            this.Chart_DepensesMois.Location = new System.Drawing.Point(408, 806);
            this.Chart_DepensesMois.Margin = new System.Windows.Forms.Padding(2);
            this.Chart_DepensesMois.Name = "Chart_DepensesMois";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Chart_DepensesMois.Series.Add(series2);
            this.Chart_DepensesMois.Size = new System.Drawing.Size(615, 322);
            this.Chart_DepensesMois.TabIndex = 6;
            this.Chart_DepensesMois.Text = "Dépense";
            // 
            // Label_DC_Solde
            // 
            this.Label_DC_Solde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_DC_Solde.AutoSize = true;
            this.Label_DC_Solde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Label_DC_Solde.ForeColor = System.Drawing.Color.White;
            this.Label_DC_Solde.Location = new System.Drawing.Point(568, 210);
            this.Label_DC_Solde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_DC_Solde.Name = "Label_DC_Solde";
            this.Label_DC_Solde.Size = new System.Drawing.Size(34, 13);
            this.Label_DC_Solde.TabIndex = 4;
            this.Label_DC_Solde.Text = "Solde";
            // 
            // Label_DC_NumeroCompte
            // 
            this.Label_DC_NumeroCompte.AutoSize = true;
            this.Label_DC_NumeroCompte.ForeColor = System.Drawing.Color.White;
            this.Label_DC_NumeroCompte.Location = new System.Drawing.Point(2, 3);
            this.Label_DC_NumeroCompte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_DC_NumeroCompte.Name = "Label_DC_NumeroCompte";
            this.Label_DC_NumeroCompte.Size = new System.Drawing.Size(64, 13);
            this.Label_DC_NumeroCompte.TabIndex = 1;
            this.Label_DC_NumeroCompte.Text = "N° Compte: ";
            // 
            // Chart_Depenses
            // 
            this.Chart_Depenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart_Depenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Chart_Depenses.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.Chart_Depenses.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Name = "Legend1";
            this.Chart_Depenses.Legends.Add(legend3);
            this.Chart_Depenses.Location = new System.Drawing.Point(261, 418);
            this.Chart_Depenses.Margin = new System.Windows.Forms.Padding(2);
            this.Chart_Depenses.Name = "Chart_Depenses";
            this.Chart_Depenses.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Dépenses";
            dataPoint1.AxisLabel = "";
            dataPoint1.Label = "Voiture \\n#PERCENT";
            dataPoint2.AxisLabel = "";
            dataPoint2.Label = "Course \\n#PERCENT";
            dataPoint3.AxisLabel = "";
            dataPoint3.Label = "Voyage \\n#PERCENT";
            series3.Points.Add(dataPoint1);
            series3.Points.Add(dataPoint2);
            series3.Points.Add(dataPoint3);
            this.Chart_Depenses.Series.Add(series3);
            this.Chart_Depenses.Size = new System.Drawing.Size(762, 328);
            this.Chart_Depenses.TabIndex = 2;
            this.Chart_Depenses.Text = "Dépenses";
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Dépenses";
            title1.Text = "Dépenses";
            this.Chart_Depenses.Titles.Add(title1);
            // 
            // Panel_CreationCompte
            // 
            this.Panel_CreationCompte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_CreationCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.Panel_CreationCompte.Controls.Add(this.Label_TitreCreationCompte);
            this.Panel_CreationCompte.Controls.Add(this.Label_ChoixTypeCompte);
            this.Panel_CreationCompte.Controls.Add(this.Button_ValiderCreationCompte);
            this.Panel_CreationCompte.Controls.Add(this.ListBox_ChoixTypeCompte);
            this.Panel_CreationCompte.Location = new System.Drawing.Point(14, 56);
            this.Panel_CreationCompte.Name = "Panel_CreationCompte";
            this.Panel_CreationCompte.Size = new System.Drawing.Size(1297, 387);
            this.Panel_CreationCompte.TabIndex = 25;
            this.Panel_CreationCompte.Visible = false;
            // 
            // Label_TitreCreationCompte
            // 
            this.Label_TitreCreationCompte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_TitreCreationCompte.AutoSize = true;
            this.Label_TitreCreationCompte.BackColor = System.Drawing.Color.Transparent;
            this.Label_TitreCreationCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TitreCreationCompte.ForeColor = System.Drawing.Color.White;
            this.Label_TitreCreationCompte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label_TitreCreationCompte.Location = new System.Drawing.Point(555, 13);
            this.Label_TitreCreationCompte.Name = "Label_TitreCreationCompte";
            this.Label_TitreCreationCompte.Size = new System.Drawing.Size(277, 39);
            this.Label_TitreCreationCompte.TabIndex = 29;
            this.Label_TitreCreationCompte.Text = "Créer un Compte";
            this.Label_TitreCreationCompte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_ChoixTypeCompte
            // 
            this.Label_ChoixTypeCompte.AutoSize = true;
            this.Label_ChoixTypeCompte.Location = new System.Drawing.Point(630, 137);
            this.Label_ChoixTypeCompte.Name = "Label_ChoixTypeCompte";
            this.Label_ChoixTypeCompte.Size = new System.Drawing.Size(72, 13);
            this.Label_ChoixTypeCompte.TabIndex = 3;
            this.Label_ChoixTypeCompte.Text = "Choix Compte";
            // 
            // Button_ValiderCreationCompte
            // 
            this.Button_ValiderCreationCompte.Location = new System.Drawing.Point(630, 290);
            this.Button_ValiderCreationCompte.Name = "Button_ValiderCreationCompte";
            this.Button_ValiderCreationCompte.Size = new System.Drawing.Size(75, 23);
            this.Button_ValiderCreationCompte.TabIndex = 2;
            this.Button_ValiderCreationCompte.Text = "Valider";
            this.Button_ValiderCreationCompte.UseVisualStyleBackColor = true;
            this.Button_ValiderCreationCompte.Click += new System.EventHandler(this.Button_ValiderCreationCompte_Click_1);
            // 
            // ListBox_ChoixTypeCompte
            // 
            this.ListBox_ChoixTypeCompte.FormattingEnabled = true;
            this.ListBox_ChoixTypeCompte.Items.AddRange(new object[] {
            "Compte Courant",
            "Compte Epargne"});
            this.ListBox_ChoixTypeCompte.Location = new System.Drawing.Point(607, 167);
            this.ListBox_ChoixTypeCompte.Name = "ListBox_ChoixTypeCompte";
            this.ListBox_ChoixTypeCompte.Size = new System.Drawing.Size(120, 95);
            this.ListBox_ChoixTypeCompte.TabIndex = 0;
            // 
            // Panel_RDV
            // 
            this.Panel_RDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_RDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.Panel_RDV.Controls.Add(this.GroupBox_Conseiller);
            this.Panel_RDV.Controls.Add(this.Button_RDVEnvoyer);
            this.Panel_RDV.Controls.Add(this.RichTextBox_RaisonRDV);
            this.Panel_RDV.Controls.Add(this.ListBox_RaisonRDV);
            this.Panel_RDV.Location = new System.Drawing.Point(14, 56);
            this.Panel_RDV.Name = "Panel_RDV";
            this.Panel_RDV.Size = new System.Drawing.Size(1297, 387);
            this.Panel_RDV.TabIndex = 26;
            this.Panel_RDV.Visible = false;
            // 
            // GroupBox_Conseiller
            // 
            this.GroupBox_Conseiller.AutoSize = true;
            this.GroupBox_Conseiller.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox_Conseiller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupBox_Conseiller.Controls.Add(this.Label_Conseiller);
            this.GroupBox_Conseiller.Controls.Add(this.Label_NOMConseiller);
            this.GroupBox_Conseiller.Cursor = System.Windows.Forms.Cursors.Default;
            this.GroupBox_Conseiller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox_Conseiller.Location = new System.Drawing.Point(394, 46);
            this.GroupBox_Conseiller.Name = "GroupBox_Conseiller";
            this.GroupBox_Conseiller.Size = new System.Drawing.Size(191, 53);
            this.GroupBox_Conseiller.TabIndex = 5;
            this.GroupBox_Conseiller.TabStop = false;
            // 
            // Label_Conseiller
            // 
            this.Label_Conseiller.AutoSize = true;
            this.Label_Conseiller.Location = new System.Drawing.Point(2, 24);
            this.Label_Conseiller.Name = "Label_Conseiller";
            this.Label_Conseiller.Size = new System.Drawing.Size(85, 13);
            this.Label_Conseiller.TabIndex = 0;
            this.Label_Conseiller.Text = "Votre conseiller :";
            // 
            // Label_NOMConseiller
            // 
            this.Label_NOMConseiller.AutoSize = true;
            this.Label_NOMConseiller.Location = new System.Drawing.Point(86, 24);
            this.Label_NOMConseiller.Name = "Label_NOMConseiller";
            this.Label_NOMConseiller.Size = new System.Drawing.Size(99, 13);
            this.Label_NOMConseiller.TabIndex = 1;
            this.Label_NOMConseiller.Text = "NOMCONSEILLER";
            // 
            // Button_RDVEnvoyer
            // 
            this.Button_RDVEnvoyer.Location = new System.Drawing.Point(450, 306);
            this.Button_RDVEnvoyer.Name = "Button_RDVEnvoyer";
            this.Button_RDVEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.Button_RDVEnvoyer.TabIndex = 4;
            this.Button_RDVEnvoyer.Text = "Envoyer";
            this.Button_RDVEnvoyer.UseVisualStyleBackColor = true;
            this.Button_RDVEnvoyer.Click += new System.EventHandler(this.Button_RDVEnvoyer_Click);
            // 
            // RichTextBox_RaisonRDV
            // 
            this.RichTextBox_RaisonRDV.Location = new System.Drawing.Point(299, 190);
            this.RichTextBox_RaisonRDV.MaxLength = 255;
            this.RichTextBox_RaisonRDV.Name = "RichTextBox_RaisonRDV";
            this.RichTextBox_RaisonRDV.Size = new System.Drawing.Size(352, 91);
            this.RichTextBox_RaisonRDV.TabIndex = 3;
            this.RichTextBox_RaisonRDV.Text = "";
            // 
            // ListBox_RaisonRDV
            // 
            this.ListBox_RaisonRDV.FormattingEnabled = true;
            this.ListBox_RaisonRDV.Items.AddRange(new object[] {
            "Liste raison"});
            this.ListBox_RaisonRDV.Location = new System.Drawing.Point(404, 117);
            this.ListBox_RaisonRDV.Name = "ListBox_RaisonRDV";
            this.ListBox_RaisonRDV.Size = new System.Drawing.Size(159, 56);
            this.ListBox_RaisonRDV.TabIndex = 2;
            // 
            // Panel_ChoixCompte
            // 
            this.Panel_ChoixCompte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_ChoixCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Panel_ChoixCompte.Controls.Add(this.Panel_Compte3);
            this.Panel_ChoixCompte.Controls.Add(this.Panel_Compte2);
            this.Panel_ChoixCompte.Controls.Add(this.Panel_Compte1);
            this.Panel_ChoixCompte.Location = new System.Drawing.Point(14, 56);
            this.Panel_ChoixCompte.Name = "Panel_ChoixCompte";
            this.Panel_ChoixCompte.Size = new System.Drawing.Size(1297, 387);
            this.Panel_ChoixCompte.TabIndex = 7;
            // 
            // Panel_Compte3
            // 
            this.Panel_Compte3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.Panel_Compte3.Controls.Add(this.Label_Solde3);
            this.Panel_Compte3.Controls.Add(this.Label_NumeroCarte3);
            this.Panel_Compte3.Controls.Add(this.Label_SoldeTexte3);
            this.Panel_Compte3.Controls.Add(this.Label_NomCompte3);
            this.Panel_Compte3.Controls.Add(this.Label_NumeroCompte3);
            this.Panel_Compte3.Location = new System.Drawing.Point(580, 16);
            this.Panel_Compte3.Name = "Panel_Compte3";
            this.Panel_Compte3.Size = new System.Drawing.Size(253, 268);
            this.Panel_Compte3.TabIndex = 3;
            // 
            // Label_Solde3
            // 
            this.Label_Solde3.AutoSize = true;
            this.Label_Solde3.ForeColor = System.Drawing.Color.White;
            this.Label_Solde3.Location = new System.Drawing.Point(86, 112);
            this.Label_Solde3.Name = "Label_Solde3";
            this.Label_Solde3.Size = new System.Drawing.Size(31, 13);
            this.Label_Solde3.TabIndex = 7;
            this.Label_Solde3.Text = "1500";
            this.Label_Solde3.Click += new System.EventHandler(this.Label_Solde3_Click);
            // 
            // Label_NumeroCarte3
            // 
            this.Label_NumeroCarte3.AutoSize = true;
            this.Label_NumeroCarte3.ForeColor = System.Drawing.Color.White;
            this.Label_NumeroCarte3.Location = new System.Drawing.Point(7, 135);
            this.Label_NumeroCarte3.Name = "Label_NumeroCarte3";
            this.Label_NumeroCarte3.Size = new System.Drawing.Size(44, 13);
            this.Label_NumeroCarte3.TabIndex = 6;
            this.Label_NumeroCarte3.Text = "N°Carte";
            this.Label_NumeroCarte3.Click += new System.EventHandler(this.Label_NumeroCarte3_Click);
            // 
            // Label_SoldeTexte3
            // 
            this.Label_SoldeTexte3.AutoSize = true;
            this.Label_SoldeTexte3.ForeColor = System.Drawing.Color.White;
            this.Label_SoldeTexte3.Location = new System.Drawing.Point(7, 112);
            this.Label_SoldeTexte3.Name = "Label_SoldeTexte3";
            this.Label_SoldeTexte3.Size = new System.Drawing.Size(80, 13);
            this.Label_SoldeTexte3.TabIndex = 5;
            this.Label_SoldeTexte3.Text = "Solde en Euro :";
            // 
            // Label_NomCompte3
            // 
            this.Label_NomCompte3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_NomCompte3.AutoSize = true;
            this.Label_NomCompte3.Font = new System.Drawing.Font("Candara", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NomCompte3.ForeColor = System.Drawing.Color.White;
            this.Label_NomCompte3.Location = new System.Drawing.Point(44, 8);
            this.Label_NomCompte3.Name = "Label_NomCompte3";
            this.Label_NomCompte3.Size = new System.Drawing.Size(161, 33);
            this.Label_NomCompte3.TabIndex = 4;
            this.Label_NomCompte3.Text = "NomCompte";
            this.Label_NomCompte3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_NomCompte3.Click += new System.EventHandler(this.Label_NomCompte3_Click);
            // 
            // Label_NumeroCompte3
            // 
            this.Label_NumeroCompte3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_NumeroCompte3.AutoSize = true;
            this.Label_NumeroCompte3.ForeColor = System.Drawing.Color.White;
            this.Label_NumeroCompte3.Location = new System.Drawing.Point(7, 89);
            this.Label_NumeroCompte3.Name = "Label_NumeroCompte3";
            this.Label_NumeroCompte3.Size = new System.Drawing.Size(55, 13);
            this.Label_NumeroCompte3.TabIndex = 0;
            this.Label_NumeroCompte3.Text = "N°Compte";
            // 
            // Panel_Compte2
            // 
            this.Panel_Compte2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.Panel_Compte2.Controls.Add(this.Label_Solde2);
            this.Panel_Compte2.Controls.Add(this.Label_NumeroCarte2);
            this.Panel_Compte2.Controls.Add(this.Label_SoldeTexte2);
            this.Panel_Compte2.Controls.Add(this.Label_NomCompte2);
            this.Panel_Compte2.Controls.Add(this.Label_NumeroCompte2);
            this.Panel_Compte2.Location = new System.Drawing.Point(296, 16);
            this.Panel_Compte2.Name = "Panel_Compte2";
            this.Panel_Compte2.Size = new System.Drawing.Size(253, 268);
            this.Panel_Compte2.TabIndex = 2;
            // 
            // Label_Solde2
            // 
            this.Label_Solde2.AutoSize = true;
            this.Label_Solde2.ForeColor = System.Drawing.Color.White;
            this.Label_Solde2.Location = new System.Drawing.Point(86, 112);
            this.Label_Solde2.Name = "Label_Solde2";
            this.Label_Solde2.Size = new System.Drawing.Size(31, 13);
            this.Label_Solde2.TabIndex = 7;
            this.Label_Solde2.Text = "1500";
            this.Label_Solde2.Click += new System.EventHandler(this.Label_Solde2_Click);
            // 
            // Label_NumeroCarte2
            // 
            this.Label_NumeroCarte2.AutoSize = true;
            this.Label_NumeroCarte2.ForeColor = System.Drawing.Color.White;
            this.Label_NumeroCarte2.Location = new System.Drawing.Point(7, 135);
            this.Label_NumeroCarte2.Name = "Label_NumeroCarte2";
            this.Label_NumeroCarte2.Size = new System.Drawing.Size(44, 13);
            this.Label_NumeroCarte2.TabIndex = 6;
            this.Label_NumeroCarte2.Text = "N°Carte";
            this.Label_NumeroCarte2.Click += new System.EventHandler(this.Label_NumeroCarte2_Click);
            // 
            // Label_SoldeTexte2
            // 
            this.Label_SoldeTexte2.AutoSize = true;
            this.Label_SoldeTexte2.ForeColor = System.Drawing.Color.White;
            this.Label_SoldeTexte2.Location = new System.Drawing.Point(7, 112);
            this.Label_SoldeTexte2.Name = "Label_SoldeTexte2";
            this.Label_SoldeTexte2.Size = new System.Drawing.Size(80, 13);
            this.Label_SoldeTexte2.TabIndex = 5;
            this.Label_SoldeTexte2.Text = "Solde en Euro :";
            this.Label_SoldeTexte2.Click += new System.EventHandler(this.Label_SoldeTexte2_Click);
            // 
            // Label_NomCompte2
            // 
            this.Label_NomCompte2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_NomCompte2.AutoSize = true;
            this.Label_NomCompte2.Font = new System.Drawing.Font("Candara", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NomCompte2.ForeColor = System.Drawing.Color.White;
            this.Label_NomCompte2.Location = new System.Drawing.Point(44, 8);
            this.Label_NomCompte2.Name = "Label_NomCompte2";
            this.Label_NomCompte2.Size = new System.Drawing.Size(161, 33);
            this.Label_NomCompte2.TabIndex = 4;
            this.Label_NomCompte2.Text = "NomCompte";
            this.Label_NomCompte2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_NomCompte2.Click += new System.EventHandler(this.Label_NomCompte2_Click);
            // 
            // Label_NumeroCompte2
            // 
            this.Label_NumeroCompte2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_NumeroCompte2.AutoSize = true;
            this.Label_NumeroCompte2.ForeColor = System.Drawing.Color.White;
            this.Label_NumeroCompte2.Location = new System.Drawing.Point(7, 89);
            this.Label_NumeroCompte2.Name = "Label_NumeroCompte2";
            this.Label_NumeroCompte2.Size = new System.Drawing.Size(55, 13);
            this.Label_NumeroCompte2.TabIndex = 0;
            this.Label_NumeroCompte2.Text = "N°Compte";
            // 
            // Panel_Compte1
            // 
            this.Panel_Compte1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.Panel_Compte1.Controls.Add(this.Label_Solde1);
            this.Panel_Compte1.Controls.Add(this.Label_NumeroCarte1);
            this.Panel_Compte1.Controls.Add(this.Label_SoldeTexte1);
            this.Panel_Compte1.Controls.Add(this.Label_NomCompte1);
            this.Panel_Compte1.Controls.Add(this.Label_NumeroCompte1);
            this.Panel_Compte1.Location = new System.Drawing.Point(13, 16);
            this.Panel_Compte1.Name = "Panel_Compte1";
            this.Panel_Compte1.Size = new System.Drawing.Size(253, 268);
            this.Panel_Compte1.TabIndex = 1;
            // 
            // Label_Solde1
            // 
            this.Label_Solde1.AutoSize = true;
            this.Label_Solde1.ForeColor = System.Drawing.Color.White;
            this.Label_Solde1.Location = new System.Drawing.Point(86, 112);
            this.Label_Solde1.Name = "Label_Solde1";
            this.Label_Solde1.Size = new System.Drawing.Size(31, 13);
            this.Label_Solde1.TabIndex = 7;
            this.Label_Solde1.Text = "1500";
            this.Label_Solde1.Click += new System.EventHandler(this.Label_Solde1_Click);
            // 
            // Label_NumeroCarte1
            // 
            this.Label_NumeroCarte1.AutoSize = true;
            this.Label_NumeroCarte1.ForeColor = System.Drawing.Color.White;
            this.Label_NumeroCarte1.Location = new System.Drawing.Point(7, 135);
            this.Label_NumeroCarte1.Name = "Label_NumeroCarte1";
            this.Label_NumeroCarte1.Size = new System.Drawing.Size(44, 13);
            this.Label_NumeroCarte1.TabIndex = 6;
            this.Label_NumeroCarte1.Text = "N°Carte";
            // 
            // Label_SoldeTexte1
            // 
            this.Label_SoldeTexte1.AutoSize = true;
            this.Label_SoldeTexte1.ForeColor = System.Drawing.Color.White;
            this.Label_SoldeTexte1.Location = new System.Drawing.Point(7, 112);
            this.Label_SoldeTexte1.Name = "Label_SoldeTexte1";
            this.Label_SoldeTexte1.Size = new System.Drawing.Size(80, 13);
            this.Label_SoldeTexte1.TabIndex = 5;
            this.Label_SoldeTexte1.Text = "Solde en Euro :";
            this.Label_SoldeTexte1.Click += new System.EventHandler(this.Label_SoldeTexte1_Click);
            // 
            // Label_NomCompte1
            // 
            this.Label_NomCompte1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_NomCompte1.AutoSize = true;
            this.Label_NomCompte1.Font = new System.Drawing.Font("Candara", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NomCompte1.ForeColor = System.Drawing.Color.White;
            this.Label_NomCompte1.Location = new System.Drawing.Point(44, 8);
            this.Label_NomCompte1.Name = "Label_NomCompte1";
            this.Label_NomCompte1.Size = new System.Drawing.Size(161, 33);
            this.Label_NomCompte1.TabIndex = 4;
            this.Label_NomCompte1.Text = "NomCompte";
            this.Label_NomCompte1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_NomCompte1.Click += new System.EventHandler(this.Label_NomCompte_Click);
            // 
            // Label_NumeroCompte1
            // 
            this.Label_NumeroCompte1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_NumeroCompte1.AutoSize = true;
            this.Label_NumeroCompte1.ForeColor = System.Drawing.Color.White;
            this.Label_NumeroCompte1.Location = new System.Drawing.Point(7, 89);
            this.Label_NumeroCompte1.Name = "Label_NumeroCompte1";
            this.Label_NumeroCompte1.Size = new System.Drawing.Size(55, 13);
            this.Label_NumeroCompte1.TabIndex = 0;
            this.Label_NumeroCompte1.Text = "N°Compte";
            // 
            // Panel_DepotRetrait
            // 
            this.Panel_DepotRetrait.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_DepotRetrait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.Panel_DepotRetrait.Controls.Add(this.label_Solde_Accout_DebRet);
            this.Panel_DepotRetrait.Controls.Add(this.button_DebitRetrait);
            this.Panel_DepotRetrait.Controls.Add(this.Label_TitreDepotRetrait);
            this.Panel_DepotRetrait.Controls.Add(this.RadioButton_Retrait);
            this.Panel_DepotRetrait.Controls.Add(this.RadioButton_Depot);
            this.Panel_DepotRetrait.Controls.Add(this.Label_MontantDebitRetrait);
            this.Panel_DepotRetrait.Controls.Add(this.TextBox_Montant);
            this.Panel_DepotRetrait.Controls.Add(this.ListBox_Compte);
            this.Panel_DepotRetrait.Location = new System.Drawing.Point(14, 56);
            this.Panel_DepotRetrait.Name = "Panel_DepotRetrait";
            this.Panel_DepotRetrait.Size = new System.Drawing.Size(1297, 387);
            this.Panel_DepotRetrait.TabIndex = 6;
            this.Panel_DepotRetrait.Visible = false;
            // 
            // label_Solde_Accout_DebRet
            // 
            this.label_Solde_Accout_DebRet.AutoSize = true;
            this.label_Solde_Accout_DebRet.Location = new System.Drawing.Point(367, 176);
            this.label_Solde_Accout_DebRet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Solde_Accout_DebRet.Name = "label_Solde_Accout_DebRet";
            this.label_Solde_Accout_DebRet.Size = new System.Drawing.Size(34, 13);
            this.label_Solde_Accout_DebRet.TabIndex = 24;
            this.label_Solde_Accout_DebRet.Text = "Solde";
            // 
            // button_DebitRetrait
            // 
            this.button_DebitRetrait.Location = new System.Drawing.Point(548, 284);
            this.button_DebitRetrait.Margin = new System.Windows.Forms.Padding(2);
            this.button_DebitRetrait.Name = "button_DebitRetrait";
            this.button_DebitRetrait.Size = new System.Drawing.Size(66, 25);
            this.button_DebitRetrait.TabIndex = 23;
            this.button_DebitRetrait.Text = "Valider";
            this.button_DebitRetrait.UseVisualStyleBackColor = true;
            this.button_DebitRetrait.Click += new System.EventHandler(this.button_DebitRetrait_Click);
            // 
            // Label_TitreDepotRetrait
            // 
            this.Label_TitreDepotRetrait.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_TitreDepotRetrait.AutoSize = true;
            this.Label_TitreDepotRetrait.BackColor = System.Drawing.Color.Transparent;
            this.Label_TitreDepotRetrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TitreDepotRetrait.ForeColor = System.Drawing.Color.White;
            this.Label_TitreDepotRetrait.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label_TitreDepotRetrait.Location = new System.Drawing.Point(480, 20);
            this.Label_TitreDepotRetrait.Name = "Label_TitreDepotRetrait";
            this.Label_TitreDepotRetrait.Size = new System.Drawing.Size(237, 39);
            this.Label_TitreDepotRetrait.TabIndex = 22;
            this.Label_TitreDepotRetrait.Text = "Dépot - Retrait";
            this.Label_TitreDepotRetrait.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RadioButton_Retrait
            // 
            this.RadioButton_Retrait.AutoSize = true;
            this.RadioButton_Retrait.Location = new System.Drawing.Point(808, 198);
            this.RadioButton_Retrait.Name = "RadioButton_Retrait";
            this.RadioButton_Retrait.Size = new System.Drawing.Size(56, 17);
            this.RadioButton_Retrait.TabIndex = 21;
            this.RadioButton_Retrait.TabStop = true;
            this.RadioButton_Retrait.Text = "Retrait";
            this.RadioButton_Retrait.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Depot
            // 
            this.RadioButton_Depot.AutoSize = true;
            this.RadioButton_Depot.Location = new System.Drawing.Point(808, 174);
            this.RadioButton_Depot.Name = "RadioButton_Depot";
            this.RadioButton_Depot.Size = new System.Drawing.Size(54, 17);
            this.RadioButton_Depot.TabIndex = 20;
            this.RadioButton_Depot.TabStop = true;
            this.RadioButton_Depot.Text = "Dépot";
            this.RadioButton_Depot.UseVisualStyleBackColor = true;
            // 
            // Label_MontantDebitRetrait
            // 
            this.Label_MontantDebitRetrait.AutoSize = true;
            this.Label_MontantDebitRetrait.Location = new System.Drawing.Point(555, 174);
            this.Label_MontantDebitRetrait.Name = "Label_MontantDebitRetrait";
            this.Label_MontantDebitRetrait.Size = new System.Drawing.Size(46, 13);
            this.Label_MontantDebitRetrait.TabIndex = 18;
            this.Label_MontantDebitRetrait.Text = "Montant";
            // 
            // TextBox_Montant
            // 
            this.TextBox_Montant.Location = new System.Drawing.Point(535, 203);
            this.TextBox_Montant.Name = "TextBox_Montant";
            this.TextBox_Montant.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Montant.TabIndex = 15;
            // 
            // ListBox_Compte
            // 
            this.ListBox_Compte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ListBox_Compte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_Compte.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListBox_Compte.ForeColor = System.Drawing.Color.White;
            this.ListBox_Compte.FormattingEnabled = true;
            this.ListBox_Compte.Location = new System.Drawing.Point(195, 174);
            this.ListBox_Compte.Name = "ListBox_Compte";
            this.ListBox_Compte.Size = new System.Drawing.Size(159, 41);
            this.ListBox_Compte.TabIndex = 14;
            this.ListBox_Compte.SelectedIndexChanged += new System.EventHandler(this.ListBox_Compte_SelectedIndexChanged);
            // 
            // Panel_Virement
            // 
            this.Panel_Virement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Virement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.Panel_Virement.Controls.Add(this.button_DeleteRecipient);
            this.Panel_Virement.Controls.Add(this.listBox_recipientList);
            this.Panel_Virement.Controls.Add(this.Label_TitreVirement);
            this.Panel_Virement.Controls.Add(this.Label_AjouterNom);
            this.Panel_Virement.Controls.Add(this.Button_Ajouter);
            this.Panel_Virement.Controls.Add(this.TextBox_AjouterNom);
            this.Panel_Virement.Controls.Add(this.TextBox_AjouterIdentifiant);
            this.Panel_Virement.Controls.Add(this.Label_AjouterIdentifiant);
            this.Panel_Virement.Controls.Add(this.Label_AjouterBeneficiaire);
            this.Panel_Virement.Controls.Add(this.Label_SoldeVirement);
            this.Panel_Virement.Controls.Add(this.ListBox_CompteDestinataire);
            this.Panel_Virement.Controls.Add(this.Button_ValiderVirement);
            this.Panel_Virement.Controls.Add(this.Label_MontantVirement);
            this.Panel_Virement.Controls.Add(this.TextBox_MontantVirement);
            this.Panel_Virement.Controls.Add(this.ListBox_CompteExpediteur);
            this.Panel_Virement.Location = new System.Drawing.Point(14, 56);
            this.Panel_Virement.Name = "Panel_Virement";
            this.Panel_Virement.Size = new System.Drawing.Size(1291, 387);
            this.Panel_Virement.TabIndex = 20;
            this.Panel_Virement.Visible = false;
            // 
            // Label_TitreVirement
            // 
            this.Label_TitreVirement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_TitreVirement.AutoSize = true;
            this.Label_TitreVirement.BackColor = System.Drawing.Color.Transparent;
            this.Label_TitreVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TitreVirement.ForeColor = System.Drawing.Color.White;
            this.Label_TitreVirement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label_TitreVirement.Location = new System.Drawing.Point(541, 31);
            this.Label_TitreVirement.Name = "Label_TitreVirement";
            this.Label_TitreVirement.Size = new System.Drawing.Size(153, 39);
            this.Label_TitreVirement.TabIndex = 28;
            this.Label_TitreVirement.Text = "Virement";
            this.Label_TitreVirement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_AjouterNom
            // 
            this.Label_AjouterNom.AutoSize = true;
            this.Label_AjouterNom.Location = new System.Drawing.Point(1017, 190);
            this.Label_AjouterNom.Name = "Label_AjouterNom";
            this.Label_AjouterNom.Size = new System.Drawing.Size(29, 13);
            this.Label_AjouterNom.TabIndex = 27;
            this.Label_AjouterNom.Text = "Nom";
            // 
            // Button_Ajouter
            // 
            this.Button_Ajouter.Location = new System.Drawing.Point(1070, 258);
            this.Button_Ajouter.Name = "Button_Ajouter";
            this.Button_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Button_Ajouter.TabIndex = 26;
            this.Button_Ajouter.Text = "Ajouter";
            this.Button_Ajouter.UseVisualStyleBackColor = true;
            this.Button_Ajouter.Click += new System.EventHandler(this.Button_Ajouter_Click);
            // 
            // TextBox_AjouterNom
            // 
            this.TextBox_AjouterNom.Location = new System.Drawing.Point(990, 213);
            this.TextBox_AjouterNom.Name = "TextBox_AjouterNom";
            this.TextBox_AjouterNom.Size = new System.Drawing.Size(100, 20);
            this.TextBox_AjouterNom.TabIndex = 25;
            // 
            // TextBox_AjouterIdentifiant
            // 
            this.TextBox_AjouterIdentifiant.Location = new System.Drawing.Point(1122, 213);
            this.TextBox_AjouterIdentifiant.Name = "TextBox_AjouterIdentifiant";
            this.TextBox_AjouterIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.TextBox_AjouterIdentifiant.TabIndex = 24;
            // 
            // Label_AjouterIdentifiant
            // 
            this.Label_AjouterIdentifiant.AutoSize = true;
            this.Label_AjouterIdentifiant.Location = new System.Drawing.Point(1119, 193);
            this.Label_AjouterIdentifiant.Name = "Label_AjouterIdentifiant";
            this.Label_AjouterIdentifiant.Size = new System.Drawing.Size(97, 13);
            this.Label_AjouterIdentifiant.TabIndex = 23;
            this.Label_AjouterIdentifiant.Text = "Numéro de compte";
            // 
            // Label_AjouterBeneficiaire
            // 
            this.Label_AjouterBeneficiaire.AutoSize = true;
            this.Label_AjouterBeneficiaire.Location = new System.Drawing.Point(1067, 133);
            this.Label_AjouterBeneficiaire.Name = "Label_AjouterBeneficiaire";
            this.Label_AjouterBeneficiaire.Size = new System.Drawing.Size(113, 13);
            this.Label_AjouterBeneficiaire.TabIndex = 22;
            this.Label_AjouterBeneficiaire.Text = "Ajouter un Bénéficiaire";
            // 
            // Label_SoldeVirement
            // 
            this.Label_SoldeVirement.AutoSize = true;
            this.Label_SoldeVirement.Location = new System.Drawing.Point(85, 171);
            this.Label_SoldeVirement.Name = "Label_SoldeVirement";
            this.Label_SoldeVirement.Size = new System.Drawing.Size(34, 13);
            this.Label_SoldeVirement.TabIndex = 21;
            this.Label_SoldeVirement.Text = "Solde";
            // 
            // ListBox_CompteDestinataire
            // 
            this.ListBox_CompteDestinataire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_CompteDestinataire.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListBox_CompteDestinataire.FormattingEnabled = true;
            this.ListBox_CompteDestinataire.Location = new System.Drawing.Point(370, 188);
            this.ListBox_CompteDestinataire.Name = "ListBox_CompteDestinataire";
            this.ListBox_CompteDestinataire.Size = new System.Drawing.Size(161, 93);
            this.ListBox_CompteDestinataire.TabIndex = 20;
            // 
            // Button_ValiderVirement
            // 
            this.Button_ValiderVirement.Location = new System.Drawing.Point(261, 239);
            this.Button_ValiderVirement.Name = "Button_ValiderVirement";
            this.Button_ValiderVirement.Size = new System.Drawing.Size(75, 23);
            this.Button_ValiderVirement.TabIndex = 19;
            this.Button_ValiderVirement.Text = "Valider";
            this.Button_ValiderVirement.UseVisualStyleBackColor = true;
            this.Button_ValiderVirement.Click += new System.EventHandler(this.Button_ValiderVirement_Click);
            // 
            // Label_MontantVirement
            // 
            this.Label_MontantVirement.AutoSize = true;
            this.Label_MontantVirement.Location = new System.Drawing.Point(272, 171);
            this.Label_MontantVirement.Name = "Label_MontantVirement";
            this.Label_MontantVirement.Size = new System.Drawing.Size(46, 13);
            this.Label_MontantVirement.TabIndex = 18;
            this.Label_MontantVirement.Text = "Montant";
            // 
            // TextBox_MontantVirement
            // 
            this.TextBox_MontantVirement.Location = new System.Drawing.Point(247, 210);
            this.TextBox_MontantVirement.Name = "TextBox_MontantVirement";
            this.TextBox_MontantVirement.Size = new System.Drawing.Size(100, 20);
            this.TextBox_MontantVirement.TabIndex = 15;
            // 
            // ListBox_CompteExpediteur
            // 
            this.ListBox_CompteExpediteur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_CompteExpediteur.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListBox_CompteExpediteur.FormattingEnabled = true;
            this.ListBox_CompteExpediteur.Location = new System.Drawing.Point(57, 190);
            this.ListBox_CompteExpediteur.Name = "ListBox_CompteExpediteur";
            this.ListBox_CompteExpediteur.Size = new System.Drawing.Size(161, 93);
            this.ListBox_CompteExpediteur.TabIndex = 14;
            this.ListBox_CompteExpediteur.SelectedIndexChanged += new System.EventHandler(this.ListBox_CompteExpediteur_SelectedIndexChanged);
            // 
            // Label_Role
            // 
            this.Label_Role.AutoSize = true;
            this.Label_Role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Label_Role.ForeColor = System.Drawing.Color.White;
            this.Label_Role.Location = new System.Drawing.Point(12, 143);
            this.Label_Role.Name = "Label_Role";
            this.Label_Role.Size = new System.Drawing.Size(29, 13);
            this.Label_Role.TabIndex = 4;
            this.Label_Role.Text = "Role";
            // 
            // listBox_recipientList
            // 
            this.listBox_recipientList.FormattingEnabled = true;
            this.listBox_recipientList.Location = new System.Drawing.Point(607, 188);
            this.listBox_recipientList.Name = "listBox_recipientList";
            this.listBox_recipientList.Size = new System.Drawing.Size(157, 95);
            this.listBox_recipientList.TabIndex = 29;
            // 
            // button_DeleteRecipient
            // 
            this.button_DeleteRecipient.Location = new System.Drawing.Point(652, 296);
            this.button_DeleteRecipient.Name = "button_DeleteRecipient";
            this.button_DeleteRecipient.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteRecipient.TabIndex = 30;
            this.button_DeleteRecipient.Text = "Supprimer";
            this.button_DeleteRecipient.UseVisualStyleBackColor = true;
            this.button_DeleteRecipient.Click += new System.EventHandler(this.button_DeleteRecipient_Click);
            // 
            // Ecran_Euro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.Label_Role);
            this.Controls.Add(this.Label_NomPrenom);
            this.Controls.Add(this.Label_Identifiant);
            this.Controls.Add(this.Button_Deconnexion);
            this.Controls.Add(this.Panel_EcranEuro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ecran_Euro";
            this.Text = "Euro";
            this.Panel_EcranEuro.ResumeLayout(false);
            this.Panel_GererWallet.ResumeLayout(false);
            this.Panel_GererWallet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WalletClient)).EndInit();
            this.Panel_DC_Crypto.ResumeLayout(false);
            this.Panel_DC_Crypto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Portefeuille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CoursCrypto)).EndInit();
            this.groupBox_Crypto.ResumeLayout(false);
            this.groupBox_Crypto.PerformLayout();
            this.Panel_DC_Euro.ResumeLayout(false);
            this.Panel_DC_Euro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HistoriqueTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_RevenuesMois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_DepensesMois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Depenses)).EndInit();
            this.Panel_CreationCompte.ResumeLayout(false);
            this.Panel_CreationCompte.PerformLayout();
            this.Panel_RDV.ResumeLayout(false);
            this.Panel_RDV.PerformLayout();
            this.GroupBox_Conseiller.ResumeLayout(false);
            this.GroupBox_Conseiller.PerformLayout();
            this.Panel_ChoixCompte.ResumeLayout(false);
            this.Panel_Compte3.ResumeLayout(false);
            this.Panel_Compte3.PerformLayout();
            this.Panel_Compte2.ResumeLayout(false);
            this.Panel_Compte2.PerformLayout();
            this.Panel_Compte1.ResumeLayout(false);
            this.Panel_Compte1.PerformLayout();
            this.Panel_DepotRetrait.ResumeLayout(false);
            this.Panel_DepotRetrait.PerformLayout();
            this.Panel_Virement.ResumeLayout(false);
            this.Panel_Virement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Deconnexion;
        private System.Windows.Forms.Label Label_Identifiant;
        private System.Windows.Forms.Label Label_NomPrenom;
        private System.Windows.Forms.Panel Panel_EcranEuro;
        private System.Windows.Forms.Button Button_Crypto;
        private System.Windows.Forms.Button Button_Euro;
        private System.Windows.Forms.Panel Panel_Compte1;
        private System.Windows.Forms.Label Label_NumeroCarte1;
        private System.Windows.Forms.Label Label_SoldeTexte1;
        private System.Windows.Forms.Label Label_NomCompte1;
        private System.Windows.Forms.Label Label_NumeroCompte1;
        private System.Windows.Forms.Button Button_DepotRetrait;
        private System.Windows.Forms.Button Button_Virement;
        private System.Windows.Forms.Panel Panel_DepotRetrait;
        private System.Windows.Forms.Label Label_MontantDebitRetrait;
        private System.Windows.Forms.TextBox TextBox_Montant;
        private System.Windows.Forms.Panel Panel_ChoixCompte;
        private System.Windows.Forms.Panel Panel_Virement;
        private System.Windows.Forms.ListBox ListBox_CompteDestinataire;
        private System.Windows.Forms.Button Button_ValiderVirement;
        private System.Windows.Forms.Label Label_MontantVirement;
        private System.Windows.Forms.TextBox TextBox_MontantVirement;
        private System.Windows.Forms.ListBox ListBox_CompteExpediteur;
        private System.Windows.Forms.Panel Panel_DC_Euro;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Depenses;
        private System.Windows.Forms.Label Label_DC_NumeroCompte;
        private System.Windows.Forms.Label Label_DC_Solde;
        private System.Windows.Forms.Label Label_Role;
        private System.Windows.Forms.Panel Panel_DC_Crypto;
        private System.Windows.Forms.Label Label_CurrentAccount;
        private System.Windows.Forms.Button Button_ValiderCrypto_Achat;
        private System.Windows.Forms.Label Label_NomCrypto_Acheter;
        private System.Windows.Forms.TextBox TextBox_QTECrypto;
        private System.Windows.Forms.RadioButton RadioButton_Retrait;
        private System.Windows.Forms.RadioButton RadioButton_Depot;
        private System.Windows.Forms.Label Label_Solde1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_DepensesMois;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_RevenuesMois;
        private System.Windows.Forms.Label Label_TitreDepotRetrait;
        private System.Windows.Forms.ListBox ListBox_Compte;
        private System.Windows.Forms.Button Button_AccountCreation;
        private System.Windows.Forms.Button Button_RDV;
        private System.Windows.Forms.Button button_DebitRetrait;
        private System.Windows.Forms.Panel Panel_Compte3;
        private System.Windows.Forms.Label Label_Solde3;
        private System.Windows.Forms.Label Label_NumeroCarte3;
        private System.Windows.Forms.Label Label_SoldeTexte3;
        private System.Windows.Forms.Label Label_NomCompte3;
        private System.Windows.Forms.Label Label_NumeroCompte3;
        private System.Windows.Forms.Panel Panel_Compte2;
        private System.Windows.Forms.Label Label_Solde2;
        private System.Windows.Forms.Label Label_NumeroCarte2;
        private System.Windows.Forms.Label Label_SoldeTexte2;
        private System.Windows.Forms.Label Label_NomCompte2;
        private System.Windows.Forms.Label Label_NumeroCompte2;
        private System.Windows.Forms.Label label_Solde_Accout_DebRet;
        private System.Windows.Forms.DataGridView dataGridView_HistoriqueTransaction;
        private System.Windows.Forms.Label Label_HistoriqueTransactions;
        private System.Windows.Forms.Panel Panel_CreationCompte;
        private System.Windows.Forms.Label Label_ChoixTypeCompte;
        private System.Windows.Forms.Button Button_ValiderCreationCompte;
        private System.Windows.Forms.ListBox ListBox_ChoixTypeCompte;
        private System.Windows.Forms.Label Label_SoldeVirement;
        private System.Windows.Forms.Panel Panel_RDV;
        private System.Windows.Forms.RichTextBox RichTextBox_RaisonRDV;
        private System.Windows.Forms.ListBox ListBox_RaisonRDV;
        private System.Windows.Forms.Label Label_NOMConseiller;
        private System.Windows.Forms.Label Label_Conseiller;
        private System.Windows.Forms.Button Button_RDVEnvoyer;
        private System.Windows.Forms.GroupBox GroupBox_Conseiller;
        private System.Windows.Forms.Button Button_Ajouter;
        private System.Windows.Forms.TextBox TextBox_AjouterNom;
        private System.Windows.Forms.TextBox TextBox_AjouterIdentifiant;
        private System.Windows.Forms.Label Label_AjouterIdentifiant;
        private System.Windows.Forms.Label Label_AjouterBeneficiaire;
        private System.Windows.Forms.Label Label_AjouterNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WalletName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.Label Label_TitreVirement;
        private System.Windows.Forms.Label Label_TitreCreationCompte;
        private System.Windows.Forms.Label Label_TitreData_Droite;
        private System.Windows.Forms.Label Label_TitreData_Gauche;
        private System.Windows.Forms.DataGridView dataGridView_Portefeuille;
        private System.Windows.Forms.DataGridView dataGridView_CoursCrypto;
        private System.Windows.Forms.GroupBox groupBox_Crypto;
        private System.Windows.Forms.Button Button_GererWallet;
        private System.Windows.Forms.Panel Panel_GererWallet;
        private System.Windows.Forms.Button Button_WalletAjout;
        private System.Windows.Forms.Label Label_NomWalletAjout;
        private System.Windows.Forms.ListBox ListBox_TypeWalletAjout;
        private System.Windows.Forms.TextBox TextBox_NomWalletAjout;
        private System.Windows.Forms.Button Button_ValiderCrypto_Vente;
        private System.Windows.Forms.Button button_DeleteWallet;
        private System.Windows.Forms.Button button_ChangeName;
        private System.Windows.Forms.Label label_ChangeWalletName;
        private System.Windows.Forms.TextBox textBox_ChangeWalletName;
        private System.Windows.Forms.Label label_WalletClient;
        private System.Windows.Forms.DataGridView dataGridView_WalletClient;
        private System.Windows.Forms.Button button_DeleteRecipient;
        private System.Windows.Forms.ListBox listBox_recipientList;
    }
}