
namespace Fulbank.Forms
{
    partial class Ecran_Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ecran_Admin));
            this.Label_RoleAdmin = new System.Windows.Forms.Label();
            this.Label_NomPrenomAdmin = new System.Windows.Forms.Label();
            this.Label_IdentifiantAdmin = new System.Windows.Forms.Label();
            this.Panel_Transaction = new System.Windows.Forms.Panel();
            this.dataGridView_Transaction = new System.Windows.Forms.DataGridView();
            this.test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label_Suivant = new System.Windows.Forms.Label();
            this.Label_Precedent = new System.Windows.Forms.Label();
            this.Label_NomPanel = new System.Windows.Forms.Label();
            this.Panel_RDV = new System.Windows.Forms.Panel();
            this.dataGridView_RDV = new System.Windows.Forms.DataGridView();
            this.Panel_OuvertCompte = new System.Windows.Forms.Panel();
            this.groupBox_ModifAdmin = new System.Windows.Forms.GroupBox();
            this.dateTime_DNaissance = new System.Windows.Forms.DateTimePicker();
            this.Label_DateNaissance = new System.Windows.Forms.Label();
            this.Label_Nom = new System.Windows.Forms.Label();
            this.Button_Modifier = new System.Windows.Forms.Button();
            this.TextBox_IdPerson = new System.Windows.Forms.TextBox();
            this.Label_Adresse = new System.Windows.Forms.Label();
            this.TextBox_User = new System.Windows.Forms.TextBox();
            this.Label_CP = new System.Windows.Forms.Label();
            this.TextBox_Ville = new System.Windows.Forms.TextBox();
            this.Label_Prenom = new System.Windows.Forms.Label();
            this.TextBox_Mail = new System.Windows.Forms.TextBox();
            this.Label_Mail = new System.Windows.Forms.Label();
            this.TextBox_Prenom = new System.Windows.Forms.TextBox();
            this.Label_Ville = new System.Windows.Forms.Label();
            this.TextBox_CP = new System.Windows.Forms.TextBox();
            this.Label_User = new System.Windows.Forms.Label();
            this.TextBox_Adresse = new System.Windows.Forms.TextBox();
            this.TextBox_Nom = new System.Windows.Forms.TextBox();
            this.Label_Modification = new System.Windows.Forms.Label();
            this.dataGridView_OuvertCompte = new System.Windows.Forms.DataGridView();
            this.Compte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_DeconnexionAdmin = new System.Windows.Forms.Button();
            this.Panel_Transaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Transaction)).BeginInit();
            this.Panel_RDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RDV)).BeginInit();
            this.Panel_OuvertCompte.SuspendLayout();
            this.groupBox_ModifAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OuvertCompte)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_RoleAdmin
            // 
            this.Label_RoleAdmin.AutoSize = true;
            this.Label_RoleAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Label_RoleAdmin.ForeColor = System.Drawing.Color.White;
            this.Label_RoleAdmin.Location = new System.Drawing.Point(12, 142);
            this.Label_RoleAdmin.Name = "Label_RoleAdmin";
            this.Label_RoleAdmin.Size = new System.Drawing.Size(29, 13);
            this.Label_RoleAdmin.TabIndex = 7;
            this.Label_RoleAdmin.Text = "Role";
            // 
            // Label_NomPrenomAdmin
            // 
            this.Label_NomPrenomAdmin.AutoSize = true;
            this.Label_NomPrenomAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Label_NomPrenomAdmin.ForeColor = System.Drawing.Color.White;
            this.Label_NomPrenomAdmin.Location = new System.Drawing.Point(12, 57);
            this.Label_NomPrenomAdmin.Name = "Label_NomPrenomAdmin";
            this.Label_NomPrenomAdmin.Size = new System.Drawing.Size(65, 13);
            this.Label_NomPrenomAdmin.TabIndex = 6;
            this.Label_NomPrenomAdmin.Text = "NomPrenom";
            // 
            // Label_IdentifiantAdmin
            // 
            this.Label_IdentifiantAdmin.AutoSize = true;
            this.Label_IdentifiantAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Label_IdentifiantAdmin.ForeColor = System.Drawing.Color.White;
            this.Label_IdentifiantAdmin.Location = new System.Drawing.Point(12, 11);
            this.Label_IdentifiantAdmin.Name = "Label_IdentifiantAdmin";
            this.Label_IdentifiantAdmin.Size = new System.Drawing.Size(53, 13);
            this.Label_IdentifiantAdmin.TabIndex = 5;
            this.Label_IdentifiantAdmin.Text = "Identifiant";
            // 
            // Panel_Transaction
            // 
            this.Panel_Transaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Transaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Panel_Transaction.Controls.Add(this.dataGridView_Transaction);
            this.Panel_Transaction.Location = new System.Drawing.Point(15, 191);
            this.Panel_Transaction.Name = "Panel_Transaction";
            this.Panel_Transaction.Size = new System.Drawing.Size(1330, 483);
            this.Panel_Transaction.TabIndex = 9;
            this.Panel_Transaction.Visible = false;
            // 
            // dataGridView_Transaction
            // 
            this.dataGridView_Transaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Transaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Transaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.dataGridView_Transaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Transaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Transaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Transaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Transaction.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Transaction.Location = new System.Drawing.Point(28, 27);
            this.dataGridView_Transaction.Name = "dataGridView_Transaction";
            this.dataGridView_Transaction.RowHeadersVisible = false;
            this.dataGridView_Transaction.RowHeadersWidth = 51;
            this.dataGridView_Transaction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Transaction.Size = new System.Drawing.Size(1265, 441);
            this.dataGridView_Transaction.TabIndex = 0;
            // 
            // test
            // 
            this.test.HeaderText = "Column1";
            this.test.MinimumWidth = 6;
            this.test.Name = "test";
            this.test.Visible = false;
            // 
            // Label_Suivant
            // 
            this.Label_Suivant.AutoSize = true;
            this.Label_Suivant.ForeColor = System.Drawing.Color.White;
            this.Label_Suivant.Location = new System.Drawing.Point(750, 57);
            this.Label_Suivant.Name = "Label_Suivant";
            this.Label_Suivant.Size = new System.Drawing.Size(13, 13);
            this.Label_Suivant.TabIndex = 10;
            this.Label_Suivant.Text = ">";
            this.Label_Suivant.Click += new System.EventHandler(this.Label_Suivant_Click);
            // 
            // Label_Precedent
            // 
            this.Label_Precedent.AutoSize = true;
            this.Label_Precedent.ForeColor = System.Drawing.Color.White;
            this.Label_Precedent.Location = new System.Drawing.Point(538, 57);
            this.Label_Precedent.Name = "Label_Precedent";
            this.Label_Precedent.Size = new System.Drawing.Size(13, 13);
            this.Label_Precedent.TabIndex = 11;
            this.Label_Precedent.Text = "<";
            this.Label_Precedent.Click += new System.EventHandler(this.Label_Precedent_Click);
            // 
            // Label_NomPanel
            // 
            this.Label_NomPanel.BackColor = System.Drawing.Color.Transparent;
            this.Label_NomPanel.ForeColor = System.Drawing.Color.White;
            this.Label_NomPanel.Location = new System.Drawing.Point(557, 57);
            this.Label_NomPanel.Name = "Label_NomPanel";
            this.Label_NomPanel.Size = new System.Drawing.Size(187, 33);
            this.Label_NomPanel.TabIndex = 12;
            this.Label_NomPanel.Text = "NomPanel";
            this.Label_NomPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_RDV
            // 
            this.Panel_RDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_RDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Panel_RDV.Controls.Add(this.dataGridView_RDV);
            this.Panel_RDV.Location = new System.Drawing.Point(15, 191);
            this.Panel_RDV.Name = "Panel_RDV";
            this.Panel_RDV.Size = new System.Drawing.Size(1330, 483);
            this.Panel_RDV.TabIndex = 13;
            this.Panel_RDV.Visible = false;
            // 
            // dataGridView_RDV
            // 
            this.dataGridView_RDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_RDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RDV.Location = new System.Drawing.Point(28, 27);
            this.dataGridView_RDV.Name = "dataGridView_RDV";
            this.dataGridView_RDV.RowHeadersWidth = 51;
            this.dataGridView_RDV.Size = new System.Drawing.Size(1265, 441);
            this.dataGridView_RDV.TabIndex = 0;
            // 
            // Panel_OuvertCompte
            // 
            this.Panel_OuvertCompte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_OuvertCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Panel_OuvertCompte.Controls.Add(this.groupBox_ModifAdmin);
            this.Panel_OuvertCompte.Controls.Add(this.Label_Modification);
            this.Panel_OuvertCompte.Controls.Add(this.dataGridView_OuvertCompte);
            this.Panel_OuvertCompte.Location = new System.Drawing.Point(15, 191);
            this.Panel_OuvertCompte.Name = "Panel_OuvertCompte";
            this.Panel_OuvertCompte.Size = new System.Drawing.Size(1330, 484);
            this.Panel_OuvertCompte.TabIndex = 14;
            this.Panel_OuvertCompte.Visible = false;
            // 
            // groupBox_ModifAdmin
            // 
            this.groupBox_ModifAdmin.Controls.Add(this.dateTime_DNaissance);
            this.groupBox_ModifAdmin.Controls.Add(this.Label_DateNaissance);
            this.groupBox_ModifAdmin.Controls.Add(this.Label_Nom);
            this.groupBox_ModifAdmin.Controls.Add(this.Button_Modifier);
            this.groupBox_ModifAdmin.Controls.Add(this.TextBox_IdPerson);
            this.groupBox_ModifAdmin.Controls.Add(this.Label_Adresse);
            this.groupBox_ModifAdmin.Controls.Add(this.TextBox_User);
            this.groupBox_ModifAdmin.Controls.Add(this.Label_CP);
            this.groupBox_ModifAdmin.Controls.Add(this.TextBox_Ville);
            this.groupBox_ModifAdmin.Controls.Add(this.Label_Prenom);
            this.groupBox_ModifAdmin.Controls.Add(this.TextBox_Mail);
            this.groupBox_ModifAdmin.Controls.Add(this.Label_Mail);
            this.groupBox_ModifAdmin.Controls.Add(this.TextBox_Prenom);
            this.groupBox_ModifAdmin.Controls.Add(this.Label_Ville);
            this.groupBox_ModifAdmin.Controls.Add(this.TextBox_CP);
            this.groupBox_ModifAdmin.Controls.Add(this.Label_User);
            this.groupBox_ModifAdmin.Controls.Add(this.TextBox_Adresse);
            this.groupBox_ModifAdmin.Controls.Add(this.TextBox_Nom);
            this.groupBox_ModifAdmin.Location = new System.Drawing.Point(409, 314);
            this.groupBox_ModifAdmin.Name = "groupBox_ModifAdmin";
            this.groupBox_ModifAdmin.Size = new System.Drawing.Size(399, 166);
            this.groupBox_ModifAdmin.TabIndex = 20;
            this.groupBox_ModifAdmin.TabStop = false;
            // 
            // dateTime_DNaissance
            // 
            this.dateTime_DNaissance.CustomFormat = "dd-MM-yyyy";
            this.dateTime_DNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_DNaissance.Location = new System.Drawing.Point(9, 50);
            this.dateTime_DNaissance.Name = "dateTime_DNaissance";
            this.dateTime_DNaissance.Size = new System.Drawing.Size(100, 20);
            this.dateTime_DNaissance.TabIndex = 21;
            this.dateTime_DNaissance.Value = new System.DateTime(2022, 3, 7, 10, 29, 45, 0);
            // 
            // Label_DateNaissance
            // 
            this.Label_DateNaissance.AutoSize = true;
            this.Label_DateNaissance.ForeColor = System.Drawing.Color.White;
            this.Label_DateNaissance.Location = new System.Drawing.Point(115, 51);
            this.Label_DateNaissance.Name = "Label_DateNaissance";
            this.Label_DateNaissance.Size = new System.Drawing.Size(98, 13);
            this.Label_DateNaissance.TabIndex = 3;
            this.Label_DateNaissance.Text = "Date de Naissance";
            this.Label_DateNaissance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Nom
            // 
            this.Label_Nom.AutoSize = true;
            this.Label_Nom.ForeColor = System.Drawing.Color.White;
            this.Label_Nom.Location = new System.Drawing.Point(115, 24);
            this.Label_Nom.Name = "Label_Nom";
            this.Label_Nom.Size = new System.Drawing.Size(29, 13);
            this.Label_Nom.TabIndex = 2;
            this.Label_Nom.Text = "Nom";
            this.Label_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button_Modifier
            // 
            this.Button_Modifier.Location = new System.Drawing.Point(167, 138);
            this.Button_Modifier.Name = "Button_Modifier";
            this.Button_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Button_Modifier.TabIndex = 18;
            this.Button_Modifier.Text = "Modifier";
            this.Button_Modifier.UseVisualStyleBackColor = true;
            this.Button_Modifier.Click += new System.EventHandler(this.Button_Modifier_Click);
            // 
            // TextBox_IdPerson
            // 
            this.TextBox_IdPerson.Location = new System.Drawing.Point(9, 128);
            this.TextBox_IdPerson.Name = "TextBox_IdPerson";
            this.TextBox_IdPerson.Size = new System.Drawing.Size(100, 20);
            this.TextBox_IdPerson.TabIndex = 11;
            this.TextBox_IdPerson.Visible = false;
            // 
            // Label_Adresse
            // 
            this.Label_Adresse.AutoSize = true;
            this.Label_Adresse.ForeColor = System.Drawing.Color.White;
            this.Label_Adresse.Location = new System.Drawing.Point(115, 79);
            this.Label_Adresse.Name = "Label_Adresse";
            this.Label_Adresse.Size = new System.Drawing.Size(45, 13);
            this.Label_Adresse.TabIndex = 4;
            this.Label_Adresse.Text = "Adresse";
            this.Label_Adresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBox_User
            // 
            this.TextBox_User.Location = new System.Drawing.Point(289, 102);
            this.TextBox_User.Name = "TextBox_User";
            this.TextBox_User.Size = new System.Drawing.Size(100, 20);
            this.TextBox_User.TabIndex = 17;
            // 
            // Label_CP
            // 
            this.Label_CP.AutoSize = true;
            this.Label_CP.ForeColor = System.Drawing.Color.White;
            this.Label_CP.Location = new System.Drawing.Point(115, 105);
            this.Label_CP.Name = "Label_CP";
            this.Label_CP.Size = new System.Drawing.Size(64, 13);
            this.Label_CP.TabIndex = 5;
            this.Label_CP.Text = "Code Postal";
            this.Label_CP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBox_Ville
            // 
            this.TextBox_Ville.Location = new System.Drawing.Point(289, 76);
            this.TextBox_Ville.Name = "TextBox_Ville";
            this.TextBox_Ville.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Ville.TabIndex = 16;
            // 
            // Label_Prenom
            // 
            this.Label_Prenom.AutoSize = true;
            this.Label_Prenom.ForeColor = System.Drawing.Color.White;
            this.Label_Prenom.Location = new System.Drawing.Point(240, 24);
            this.Label_Prenom.Name = "Label_Prenom";
            this.Label_Prenom.Size = new System.Drawing.Size(43, 13);
            this.Label_Prenom.TabIndex = 6;
            this.Label_Prenom.Text = "Prenom";
            this.Label_Prenom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_Mail
            // 
            this.TextBox_Mail.Location = new System.Drawing.Point(289, 48);
            this.TextBox_Mail.Name = "TextBox_Mail";
            this.TextBox_Mail.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Mail.TabIndex = 15;
            // 
            // Label_Mail
            // 
            this.Label_Mail.AutoSize = true;
            this.Label_Mail.ForeColor = System.Drawing.Color.White;
            this.Label_Mail.Location = new System.Drawing.Point(257, 48);
            this.Label_Mail.Name = "Label_Mail";
            this.Label_Mail.Size = new System.Drawing.Size(26, 13);
            this.Label_Mail.TabIndex = 7;
            this.Label_Mail.Text = "Mail";
            this.Label_Mail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_Prenom
            // 
            this.TextBox_Prenom.Location = new System.Drawing.Point(289, 21);
            this.TextBox_Prenom.Name = "TextBox_Prenom";
            this.TextBox_Prenom.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Prenom.TabIndex = 14;
            // 
            // Label_Ville
            // 
            this.Label_Ville.AutoSize = true;
            this.Label_Ville.ForeColor = System.Drawing.Color.White;
            this.Label_Ville.Location = new System.Drawing.Point(257, 79);
            this.Label_Ville.Name = "Label_Ville";
            this.Label_Ville.Size = new System.Drawing.Size(26, 13);
            this.Label_Ville.TabIndex = 8;
            this.Label_Ville.Text = "Ville";
            this.Label_Ville.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_CP
            // 
            this.TextBox_CP.Location = new System.Drawing.Point(9, 102);
            this.TextBox_CP.Name = "TextBox_CP";
            this.TextBox_CP.Size = new System.Drawing.Size(100, 20);
            this.TextBox_CP.TabIndex = 13;
            // 
            // Label_User
            // 
            this.Label_User.AutoSize = true;
            this.Label_User.ForeColor = System.Drawing.Color.White;
            this.Label_User.Location = new System.Drawing.Point(254, 105);
            this.Label_User.Name = "Label_User";
            this.Label_User.Size = new System.Drawing.Size(29, 13);
            this.Label_User.TabIndex = 9;
            this.Label_User.Text = "User";
            this.Label_User.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_Adresse
            // 
            this.TextBox_Adresse.Location = new System.Drawing.Point(9, 76);
            this.TextBox_Adresse.Name = "TextBox_Adresse";
            this.TextBox_Adresse.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Adresse.TabIndex = 12;
            // 
            // TextBox_Nom
            // 
            this.TextBox_Nom.Location = new System.Drawing.Point(9, 21);
            this.TextBox_Nom.Name = "TextBox_Nom";
            this.TextBox_Nom.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nom.TabIndex = 10;
            // 
            // Label_Modification
            // 
            this.Label_Modification.AutoSize = true;
            this.Label_Modification.ForeColor = System.Drawing.Color.White;
            this.Label_Modification.Location = new System.Drawing.Point(587, 286);
            this.Label_Modification.Name = "Label_Modification";
            this.Label_Modification.Size = new System.Drawing.Size(64, 13);
            this.Label_Modification.TabIndex = 19;
            this.Label_Modification.Text = "Modification";
            this.Label_Modification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_OuvertCompte
            // 
            this.dataGridView_OuvertCompte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_OuvertCompte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_OuvertCompte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.dataGridView_OuvertCompte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_OuvertCompte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_OuvertCompte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_OuvertCompte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OuvertCompte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Compte});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_OuvertCompte.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_OuvertCompte.Location = new System.Drawing.Point(28, 27);
            this.dataGridView_OuvertCompte.MultiSelect = false;
            this.dataGridView_OuvertCompte.Name = "dataGridView_OuvertCompte";
            this.dataGridView_OuvertCompte.RowHeadersVisible = false;
            this.dataGridView_OuvertCompte.RowHeadersWidth = 51;
            this.dataGridView_OuvertCompte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_OuvertCompte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_OuvertCompte.Size = new System.Drawing.Size(1265, 226);
            this.dataGridView_OuvertCompte.TabIndex = 0;
            this.dataGridView_OuvertCompte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Compte
            // 
            this.Compte.HeaderText = "Compte";
            this.Compte.MinimumWidth = 6;
            this.Compte.Name = "Compte";
            this.Compte.Visible = false;
            // 
            // Button_DeconnexionAdmin
            // 
            this.Button_DeconnexionAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_DeconnexionAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Button_DeconnexionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_DeconnexionAdmin.ForeColor = System.Drawing.Color.White;
            this.Button_DeconnexionAdmin.Location = new System.Drawing.Point(1163, 12);
            this.Button_DeconnexionAdmin.Name = "Button_DeconnexionAdmin";
            this.Button_DeconnexionAdmin.Size = new System.Drawing.Size(188, 59);
            this.Button_DeconnexionAdmin.TabIndex = 15;
            this.Button_DeconnexionAdmin.Text = "Déconnexion";
            this.Button_DeconnexionAdmin.UseVisualStyleBackColor = false;
            this.Button_DeconnexionAdmin.Click += new System.EventHandler(this.Button_DeconnexionAdmin_Click);
            // 
            // Ecran_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1364, 687);
            this.Controls.Add(this.Button_DeconnexionAdmin);
            this.Controls.Add(this.Label_NomPanel);
            this.Controls.Add(this.Label_Suivant);
            this.Controls.Add(this.Label_Precedent);
            this.Controls.Add(this.Label_RoleAdmin);
            this.Controls.Add(this.Label_NomPrenomAdmin);
            this.Controls.Add(this.Label_IdentifiantAdmin);
            this.Controls.Add(this.Panel_OuvertCompte);
            this.Controls.Add(this.Panel_RDV);
            this.Controls.Add(this.Panel_Transaction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ecran_Admin";
            this.Text = "Admin";
            this.Panel_Transaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Transaction)).EndInit();
            this.Panel_RDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RDV)).EndInit();
            this.Panel_OuvertCompte.ResumeLayout(false);
            this.Panel_OuvertCompte.PerformLayout();
            this.groupBox_ModifAdmin.ResumeLayout(false);
            this.groupBox_ModifAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OuvertCompte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_RoleAdmin;
        private System.Windows.Forms.Label Label_NomPrenomAdmin;
        private System.Windows.Forms.Label Label_IdentifiantAdmin;
        private System.Windows.Forms.Panel Panel_Transaction;
        private System.Windows.Forms.DataGridView dataGridView_Transaction;
        private System.Windows.Forms.Label Label_Suivant;
        private System.Windows.Forms.Label Label_Precedent;
        private System.Windows.Forms.Label Label_NomPanel;
        private System.Windows.Forms.Panel Panel_RDV;
        private System.Windows.Forms.DataGridView dataGridView_RDV;
        private System.Windows.Forms.Panel Panel_OuvertCompte;
        private System.Windows.Forms.DataGridView dataGridView_OuvertCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compte;
        private System.Windows.Forms.Button Button_DeconnexionAdmin;
        private System.Windows.Forms.Label Label_DateNaissance;
        private System.Windows.Forms.Label Label_Nom;
        private System.Windows.Forms.Button Button_Modifier;
        private System.Windows.Forms.TextBox TextBox_User;
        private System.Windows.Forms.TextBox TextBox_Ville;
        private System.Windows.Forms.TextBox TextBox_Mail;
        private System.Windows.Forms.TextBox TextBox_Prenom;
        private System.Windows.Forms.TextBox TextBox_CP;
        private System.Windows.Forms.TextBox TextBox_Adresse;
        private System.Windows.Forms.TextBox TextBox_IdPerson;
        private System.Windows.Forms.TextBox TextBox_Nom;
        private System.Windows.Forms.Label Label_User;
        private System.Windows.Forms.Label Label_Ville;
        private System.Windows.Forms.Label Label_Mail;
        private System.Windows.Forms.Label Label_Prenom;
        private System.Windows.Forms.Label Label_CP;
        private System.Windows.Forms.Label Label_Adresse;
        private System.Windows.Forms.Label Label_Modification;
        private System.Windows.Forms.GroupBox groupBox_ModifAdmin;
        private System.Windows.Forms.DateTimePicker dateTime_DNaissance;
    }
}