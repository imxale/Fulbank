using Fulbank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Fulbank
{
    class Wallet
    {        
        private int idWallet;
        private string nomCrypto;
        private int idPerson;
        private string name;
        private float quantity;

        public int CreateWallet()
        {
            WalletModel aWallet = new WalletModel();
            return aWallet.createWallet(this);
        }

        public int UpdateBalance()
        {
            WalletModel aWallet = new WalletModel();
            return aWallet.updateBalance(this);
        }

        public int UpdateBalance2()
        {
            WalletModel aWallet = new WalletModel();
            return aWallet.updateBalance2(this);
        }

        public DataTable SelectWallet()
        {
            WalletModel aWallet = new WalletModel();
            return aWallet.selectWallet(this.idPerson);
        }

        public int DeleteWallet()
        {
            WalletModel aWallet = new WalletModel();
            return aWallet.deleteWallet(this);
        }

        public int ChangeWalletName()
        {
            WalletModel aWallet = new WalletModel();
            return aWallet.ChangeWalletName(this);
        }

        public float Purchase(float quantity)
        {
            return this.quantity += quantity;
        }

        public float Sell(float quantity)
        {
            if (this.quantity >= quantity)
            {
                this.quantity -= quantity;
            }
            else
            {
                MessageBox.Show("Quantitée insuffisante");
            }
            return this.quantity;
        }

        public int IdWallet
        {
            get => this.idWallet;
            set => this.idWallet = value;
        }


        public string NomCrypto
        {
            get => this.nomCrypto;
            set => this.nomCrypto = value;
        }

        public int IdPerson
        {
            get => this.idPerson;
            set => this.idPerson = value;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public float Quantity
        {
            get => this.quantity;
            set => this.quantity = value;
        }
    }
}
