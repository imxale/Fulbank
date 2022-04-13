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

namespace Fulbank
{
    public partial class Ecran_BDD : Form
    {
        // Initialisation d'une nouvelle police d'écriture //
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font myFont;
        // FIN ICI //
        public Ecran_BDD()
        {
            InitializeComponent();

            //SetPoliceEcriture();
            CentrerText();

            this.WindowState = FormWindowState.Maximized; //Plein écran
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
            Button_Envoyer.Font = new Font(myFont.FontFamily, 15, FontStyle.Regular);
            Label_HostName.Font = new Font(myFont.FontFamily, 10, FontStyle.Regular);
            Label_NomBDD.Font = new Font(myFont.FontFamily, 10, FontStyle.Regular);
            Label_Identifiant.Font = new Font(myFont.FontFamily, 10, FontStyle.Regular);
            Label_MotDePasse.Font = new Font(myFont.FontFamily, 35, FontStyle.Regular);
        }

        public void CentrerText()
        {

            TextBox_HostName.Left = (this.Width / 2) - (TextBox_HostName.Width / 2);
            TextBox_NomBDD.Left = (this.Width / 2) - (TextBox_NomBDD.Width / 2);
            TextBox_Identifiant.Left = (this.Width / 2) - (TextBox_Identifiant.Width / 2);
            TextBox_MotDePasse.Left = (this.Width / 2) - (TextBox_MotDePasse.Width / 2);

            Button_Envoyer.Left = (this.Width / 2) - (Button_Envoyer.Width / 2);

            Label_HostName.Left = (this.Width / 2) - (TextBox_HostName.Width / 2) - Label_HostName.Width;
            Label_NomBDD.Left = (this.Width / 2) - (TextBox_NomBDD.Width / 2) - Label_NomBDD.Width;
            Label_Identifiant.Left = (this.Width / 2) - (TextBox_Identifiant.Width / 2) - Label_Identifiant.Width;
            Label_MotDePasse.Left = (this.Width / 2) - (TextBox_MotDePasse.Width / 2) - Label_MotDePasse.Width;
        }

        private void Button_Envoyer_Click(object sender, EventArgs e)
        {
            var Myini = new IniFile("../../../bdd.ini");
            Myini.Write("host", TextBox_HostName.Text);
            Myini.Write("database", TextBox_NomBDD.Text);
            Myini.Write("username", TextBox_Identifiant.Text);
            Myini.Write("password", TextBox_MotDePasse.Text);

            Ecran_Connexion connexion = new Ecran_Connexion();
            this.Hide();
            connexion.ShowDialog();
            this.Close();
        }

        private void button_testbdd_Click(object sender, EventArgs e)
        {
            label_testBDD.Visible = true;
            try
            {
                DbMySql.GetDBConn().Open();
                label_testBDD.Text = "Connexion établie";
            }
            catch (Exception ex)
            {
                label_testBDD.Text = "Connexion échouée" + "\n" + ex.Message;
            }
        }
    }
}
