
namespace Fulbank
{
    partial class Ecran_BDD
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
            this.Label_HostName = new System.Windows.Forms.Label();
            this.Label_NomBDD = new System.Windows.Forms.Label();
            this.Label_Identifiant = new System.Windows.Forms.Label();
            this.Label_MotDePasse = new System.Windows.Forms.Label();
            this.Button_Envoyer = new System.Windows.Forms.Button();
            this.TextBox_HostName = new System.Windows.Forms.TextBox();
            this.TextBox_NomBDD = new System.Windows.Forms.TextBox();
            this.TextBox_Identifiant = new System.Windows.Forms.TextBox();
            this.TextBox_MotDePasse = new System.Windows.Forms.TextBox();
            this.button_testbdd = new System.Windows.Forms.Button();
            this.label_testBDD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_HostName
            // 
            this.Label_HostName.AutoSize = true;
            this.Label_HostName.Location = new System.Drawing.Point(508, 105);
            this.Label_HostName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_HostName.Name = "Label_HostName";
            this.Label_HostName.Size = new System.Drawing.Size(72, 16);
            this.Label_HostName.TabIndex = 0;
            this.Label_HostName.Text = "HostName";
            // 
            // Label_NomBDD
            // 
            this.Label_NomBDD.AutoSize = true;
            this.Label_NomBDD.Location = new System.Drawing.Point(508, 155);
            this.Label_NomBDD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_NomBDD.Name = "Label_NomBDD";
            this.Label_NomBDD.Size = new System.Drawing.Size(68, 16);
            this.Label_NomBDD.TabIndex = 1;
            this.Label_NomBDD.Text = "Nom BDD";
            // 
            // Label_Identifiant
            // 
            this.Label_Identifiant.AutoSize = true;
            this.Label_Identifiant.Location = new System.Drawing.Point(508, 202);
            this.Label_Identifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Identifiant.Name = "Label_Identifiant";
            this.Label_Identifiant.Size = new System.Drawing.Size(63, 16);
            this.Label_Identifiant.TabIndex = 2;
            this.Label_Identifiant.Text = "Identifiant";
            // 
            // Label_MotDePasse
            // 
            this.Label_MotDePasse.AutoSize = true;
            this.Label_MotDePasse.Location = new System.Drawing.Point(508, 255);
            this.Label_MotDePasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_MotDePasse.Name = "Label_MotDePasse";
            this.Label_MotDePasse.Size = new System.Drawing.Size(89, 16);
            this.Label_MotDePasse.TabIndex = 3;
            this.Label_MotDePasse.Text = "Mot de passe";
            // 
            // Button_Envoyer
            // 
            this.Button_Envoyer.Location = new System.Drawing.Point(631, 315);
            this.Button_Envoyer.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Envoyer.Name = "Button_Envoyer";
            this.Button_Envoyer.Size = new System.Drawing.Size(100, 28);
            this.Button_Envoyer.TabIndex = 4;
            this.Button_Envoyer.Text = "Envoyer";
            this.Button_Envoyer.UseVisualStyleBackColor = true;
            this.Button_Envoyer.Click += new System.EventHandler(this.Button_Envoyer_Click);
            // 
            // TextBox_HostName
            // 
            this.TextBox_HostName.Location = new System.Drawing.Point(631, 105);
            this.TextBox_HostName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_HostName.Name = "TextBox_HostName";
            this.TextBox_HostName.Size = new System.Drawing.Size(132, 22);
            this.TextBox_HostName.TabIndex = 5;
            // 
            // TextBox_NomBDD
            // 
            this.TextBox_NomBDD.Location = new System.Drawing.Point(631, 155);
            this.TextBox_NomBDD.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_NomBDD.Name = "TextBox_NomBDD";
            this.TextBox_NomBDD.Size = new System.Drawing.Size(132, 22);
            this.TextBox_NomBDD.TabIndex = 6;
            // 
            // TextBox_Identifiant
            // 
            this.TextBox_Identifiant.Location = new System.Drawing.Point(631, 202);
            this.TextBox_Identifiant.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Identifiant.Name = "TextBox_Identifiant";
            this.TextBox_Identifiant.Size = new System.Drawing.Size(132, 22);
            this.TextBox_Identifiant.TabIndex = 7;
            // 
            // TextBox_MotDePasse
            // 
            this.TextBox_MotDePasse.Location = new System.Drawing.Point(631, 255);
            this.TextBox_MotDePasse.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_MotDePasse.Name = "TextBox_MotDePasse";
            this.TextBox_MotDePasse.Size = new System.Drawing.Size(132, 22);
            this.TextBox_MotDePasse.TabIndex = 8;
            // 
            // button_testbdd
            // 
            this.button_testbdd.Location = new System.Drawing.Point(631, 364);
            this.button_testbdd.Name = "button_testbdd";
            this.button_testbdd.Size = new System.Drawing.Size(100, 29);
            this.button_testbdd.TabIndex = 9;
            this.button_testbdd.Text = "Test BDD";
            this.button_testbdd.UseVisualStyleBackColor = true;
            this.button_testbdd.Click += new System.EventHandler(this.button_testbdd_Click);
            // 
            // label_testBDD
            // 
            this.label_testBDD.AutoSize = true;
            this.label_testBDD.Location = new System.Drawing.Point(646, 408);
            this.label_testBDD.Name = "label_testBDD";
            this.label_testBDD.Size = new System.Drawing.Size(44, 16);
            this.label_testBDD.TabIndex = 10;
            this.label_testBDD.Text = "label1";
            this.label_testBDD.Visible = false;
            // 
            // Ecran_BDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1819, 922);
            this.Controls.Add(this.label_testBDD);
            this.Controls.Add(this.button_testbdd);
            this.Controls.Add(this.TextBox_MotDePasse);
            this.Controls.Add(this.TextBox_Identifiant);
            this.Controls.Add(this.TextBox_NomBDD);
            this.Controls.Add(this.TextBox_HostName);
            this.Controls.Add(this.Button_Envoyer);
            this.Controls.Add(this.Label_MotDePasse);
            this.Controls.Add(this.Label_Identifiant);
            this.Controls.Add(this.Label_NomBDD);
            this.Controls.Add(this.Label_HostName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ecran_BDD";
            this.Text = "Base de donnée";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_HostName;
        private System.Windows.Forms.Label Label_NomBDD;
        private System.Windows.Forms.Label Label_Identifiant;
        private System.Windows.Forms.Label Label_MotDePasse;
        private System.Windows.Forms.Button Button_Envoyer;
        private System.Windows.Forms.TextBox TextBox_HostName;
        private System.Windows.Forms.TextBox TextBox_NomBDD;
        private System.Windows.Forms.TextBox TextBox_Identifiant;
        private System.Windows.Forms.TextBox TextBox_MotDePasse;
        private System.Windows.Forms.Button button_testbdd;
        private System.Windows.Forms.Label label_testBDD;
    }
}