namespace Fulbank.Forms
{
    partial class Ecran_ResetPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_envoyer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_codeSecret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_confirmpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_resetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email : ";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(254, 71);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(242, 22);
            this.textBox_email.TabIndex = 1;
            // 
            // button_envoyer
            // 
            this.button_envoyer.Location = new System.Drawing.Point(334, 112);
            this.button_envoyer.Name = "button_envoyer";
            this.button_envoyer.Size = new System.Drawing.Size(87, 23);
            this.button_envoyer.TabIndex = 2;
            this.button_envoyer.Text = "Envoyer";
            this.button_envoyer.UseVisualStyleBackColor = true;
            this.button_envoyer.Click += new System.EventHandler(this.button_envoyer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code Secret :";
            // 
            // textBox_codeSecret
            // 
            this.textBox_codeSecret.Location = new System.Drawing.Point(254, 171);
            this.textBox_codeSecret.Name = "textBox_codeSecret";
            this.textBox_codeSecret.Size = new System.Drawing.Size(242, 22);
            this.textBox_codeSecret.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nouveau mot de passe : ";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(254, 212);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(242, 22);
            this.textBox_password.TabIndex = 6;
            // 
            // textBox_confirmpassword
            // 
            this.textBox_confirmpassword.Location = new System.Drawing.Point(254, 251);
            this.textBox_confirmpassword.Name = "textBox_confirmpassword";
            this.textBox_confirmpassword.Size = new System.Drawing.Size(242, 22);
            this.textBox_confirmpassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmer mot de passe :";
            // 
            // button_resetPassword
            // 
            this.button_resetPassword.Location = new System.Drawing.Point(334, 294);
            this.button_resetPassword.Name = "button_resetPassword";
            this.button_resetPassword.Size = new System.Drawing.Size(87, 23);
            this.button_resetPassword.TabIndex = 9;
            this.button_resetPassword.Text = "Réinitialiser";
            this.button_resetPassword.UseVisualStyleBackColor = true;
            this.button_resetPassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ecran_ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_resetPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_confirmpassword);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_codeSecret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_envoyer);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label1);
            this.Name = "Ecran_ResetPassword";
            this.Text = "Ecran_ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button_envoyer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_codeSecret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_confirmpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_resetPassword;
    }
}