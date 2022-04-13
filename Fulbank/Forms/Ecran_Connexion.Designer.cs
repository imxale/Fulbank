namespace Fulbank
{
    partial class Ecran_Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ecran_Connexion));
            this.Label_Titre = new System.Windows.Forms.Label();
            this.TextBox_Identifiant = new System.Windows.Forms.TextBox();
            this.TextBox_MDP = new System.Windows.Forms.TextBox();
            this.Button_Connexion = new System.Windows.Forms.Button();
            this.RadioButton_AfficherMotDePasse = new System.Windows.Forms.CheckBox();
            this.Button_CreerCompte = new System.Windows.Forms.Button();
            this.label_forgotPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Titre
            // 
            this.Label_Titre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Titre.AutoSize = true;
            this.Label_Titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Label_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Titre.ForeColor = System.Drawing.Color.White;
            this.Label_Titre.Location = new System.Drawing.Point(526, 45);
            this.Label_Titre.Name = "Label_Titre";
            this.Label_Titre.Size = new System.Drawing.Size(261, 73);
            this.Label_Titre.TabIndex = 0;
            this.Label_Titre.Text = "Fulbank";
            this.Label_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Titre.UseMnemonic = false;
            // 
            // TextBox_Identifiant
            // 
            this.TextBox_Identifiant.AccessibleDescription = "";
            this.TextBox_Identifiant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_Identifiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.TextBox_Identifiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Identifiant.ForeColor = System.Drawing.Color.White;
            this.TextBox_Identifiant.Location = new System.Drawing.Point(562, 348);
            this.TextBox_Identifiant.Name = "TextBox_Identifiant";
            this.TextBox_Identifiant.Size = new System.Drawing.Size(256, 38);
            this.TextBox_Identifiant.TabIndex = 1;
            // 
            // TextBox_MDP
            // 
            this.TextBox_MDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_MDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.TextBox_MDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_MDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MDP.Location = new System.Drawing.Point(562, 409);
            this.TextBox_MDP.Name = "TextBox_MDP";
            this.TextBox_MDP.Size = new System.Drawing.Size(256, 38);
            this.TextBox_MDP.TabIndex = 2;
            this.TextBox_MDP.UseSystemPasswordChar = true;
            // 
            // Button_Connexion
            // 
            this.Button_Connexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Connexion.AutoSize = true;
            this.Button_Connexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Button_Connexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Connexion.ForeColor = System.Drawing.Color.White;
            this.Button_Connexion.Location = new System.Drawing.Point(616, 497);
            this.Button_Connexion.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Connexion.Name = "Button_Connexion";
            this.Button_Connexion.Size = new System.Drawing.Size(114, 47);
            this.Button_Connexion.TabIndex = 3;
            this.Button_Connexion.Text = "Connexion";
            this.Button_Connexion.UseVisualStyleBackColor = false;
            this.Button_Connexion.Click += new System.EventHandler(this.Button_Connexion_Click);
            // 
            // RadioButton_AfficherMotDePasse
            // 
            this.RadioButton_AfficherMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RadioButton_AfficherMotDePasse.AutoSize = true;
            this.RadioButton_AfficherMotDePasse.Location = new System.Drawing.Point(619, 452);
            this.RadioButton_AfficherMotDePasse.Margin = new System.Windows.Forms.Padding(2);
            this.RadioButton_AfficherMotDePasse.Name = "RadioButton_AfficherMotDePasse";
            this.RadioButton_AfficherMotDePasse.Size = new System.Drawing.Size(139, 17);
            this.RadioButton_AfficherMotDePasse.TabIndex = 4;
            this.RadioButton_AfficherMotDePasse.Text = "Afficher le mot de passe";
            this.RadioButton_AfficherMotDePasse.UseVisualStyleBackColor = true;
            this.RadioButton_AfficherMotDePasse.CheckedChanged += new System.EventHandler(this.AfficherMotDePasse_CheckedChanged);
            // 
            // Button_CreerCompte
            // 
            this.Button_CreerCompte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_CreerCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Button_CreerCompte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_CreerCompte.ForeColor = System.Drawing.Color.White;
            this.Button_CreerCompte.Location = new System.Drawing.Point(815, 11);
            this.Button_CreerCompte.Margin = new System.Windows.Forms.Padding(2);
            this.Button_CreerCompte.Name = "Button_CreerCompte";
            this.Button_CreerCompte.Size = new System.Drawing.Size(198, 40);
            this.Button_CreerCompte.TabIndex = 5;
            this.Button_CreerCompte.Text = "Créer un compte";
            this.Button_CreerCompte.UseVisualStyleBackColor = false;
            this.Button_CreerCompte.Click += new System.EventHandler(this.Button_CreerCompte_Click);
            // 
            // label_forgotPassword
            // 
            this.label_forgotPassword.AutoSize = true;
            this.label_forgotPassword.Location = new System.Drawing.Point(619, 471);
            this.label_forgotPassword.Name = "label_forgotPassword";
            this.label_forgotPassword.Size = new System.Drawing.Size(111, 13);
            this.label_forgotPassword.TabIndex = 6;
            this.label_forgotPassword.Text = "Mot de passe oublié ?";
            this.label_forgotPassword.Click += new System.EventHandler(this.label_forgotPassword_Click);
            // 
            // Ecran_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1023, 609);
            this.Controls.Add(this.label_forgotPassword);
            this.Controls.Add(this.Button_CreerCompte);
            this.Controls.Add(this.RadioButton_AfficherMotDePasse);
            this.Controls.Add(this.Button_Connexion);
            this.Controls.Add(this.TextBox_MDP);
            this.Controls.Add(this.TextBox_Identifiant);
            this.Controls.Add(this.Label_Titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ecran_Connexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Titre;
        private System.Windows.Forms.TextBox TextBox_Identifiant;
        private System.Windows.Forms.TextBox TextBox_MDP;
        private System.Windows.Forms.Button Button_Connexion;
        private System.Windows.Forms.CheckBox RadioButton_AfficherMotDePasse;
        private System.Windows.Forms.Button Button_CreerCompte;
        private System.Windows.Forms.Label label_forgotPassword;
    }
}

