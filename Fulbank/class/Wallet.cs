using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank
{
    class Wallet
    {
        private int idWallet;
        private string name;
        private float quantity;

        public Wallet(string aName, int aQuantity)
        {
            this.name = aName;
            this.quantity = aQuantity;
        }

        public int IdWallet
        {
            get => this.idWallet;
            set => this.idWallet = value;
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
