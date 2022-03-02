
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
            this.RDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_OuvertCompte = new System.Windows.Forms.Panel();
            this.Button_UpdatePerson = new System.Windows.Forms.Button();
            this.dataGridView_OuvertCompte = new System.Windows.Forms.DataGridView();
            this.Compte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_DeconnexionAdmin = new System.Windows.Forms.Button();
            this.Panel_Transaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Transaction)).BeginInit();
            this.Panel_RDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RDV)).BeginInit();
            this.Panel_OuvertCompte.SuspendLayout();
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
            this.dataGridView_RDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RDV});
            this.dataGridView_RDV.Location = new System.Drawing.Point(28, 27);
            this.dataGridView_RDV.Name = "dataGridView_RDV";
            this.dataGridView_RDV.RowHeadersWidth = 51;
            this.dataGridView_RDV.Size = new System.Drawing.Size(1265, 441);
            this.dataGridView_RDV.TabIndex = 0;
            // 
            // RDV
            // 
            this.RDV.HeaderText = "RDV";
            this.RDV.MinimumWidth = 6;
            this.RDV.Name = "RDV";
            this.RDV.Width = 125;
            // 
            // Panel_OuvertCompte
            // 
            this.Panel_OuvertCompte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_OuvertCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Panel_OuvertCompte.Controls.Add(this.Button_UpdatePerson);
            this.Panel_OuvertCompte.Controls.Add(this.dataGridView_OuvertCompte);
            this.Panel_OuvertCompte.Location = new System.Drawing.Point(15, 191);
            this.Panel_OuvertCompte.Name = "Panel_OuvertCompte";
            this.Panel_OuvertCompte.Size = new System.Drawing.Size(1330, 483);
            this.Panel_OuvertCompte.TabIndex = 14;
            this.Panel_OuvertCompte.Visible = false;
            // 
            // Button_UpdatePerson
            // 
            this.Button_UpdatePerson.Location = new System.Drawing.Point(1256, 3);
            this.Button_UpdatePerson.Margin = new System.Windows.Forms.Padding(2);
            this.Button_UpdatePerson.Name = "Button_UpdatePerson";
            this.Button_UpdatePerson.Size = new System.Drawing.Size(65, 19);
            this.Button_UpdatePerson.TabIndex = 1;
            this.Button_UpdatePerson.Text = "Actualiser";
            this.Button_UpdatePerson.UseVisualStyleBackColor = true;
            this.Button_UpdatePerson.Click += new System.EventHandler(this.Button_UpdatePerson_Click);
            // 
            // dataGridView_OuvertCompte
            // 
            this.dataGridView_OuvertCompte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.dataGridView_OuvertCompte.Name = "dataGridView_OuvertCompte";
            this.dataGridView_OuvertCompte.RowHeadersVisible = false;
            this.dataGridView_OuvertCompte.RowHeadersWidth = 51;
            this.dataGridView_OuvertCompte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_OuvertCompte.Size = new System.Drawing.Size(1265, 441);
            this.dataGridView_OuvertCompte.TabIndex = 0;
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
            this.Controls.Add(this.Panel_Transaction);
            this.Controls.Add(this.Panel_OuvertCompte);
            this.Controls.Add(this.Panel_RDV);
            this.Name = "Ecran_Admin";
            this.Text = "Admin";
            this.Panel_Transaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Transaction)).EndInit();
            this.Panel_RDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RDV)).EndInit();
            this.Panel_OuvertCompte.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn RDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compte;
        private System.Windows.Forms.Button Button_UpdatePerson;
        private System.Windows.Forms.Button Button_DeconnexionAdmin;
    }
}