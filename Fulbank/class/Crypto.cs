using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Fulbank.Model;

namespace Fulbank
{
    class Crypto
    {
        private int idCrypto;
        private string name;
        private float euroValue;

        public DataTable selectCrypto()
        {
            CryptoModel anAccountModel = new CryptoModel();
            return anAccountModel.selectCrypto();
        }

        public DataTable selectCryptoName()
        {
            CryptoModel aCryptoModel = new CryptoModel();
            return aCryptoModel.selectCryptoName();
        }

        public DataTable selectCryptoByName()
        {
            CryptoModel aCryptoModel = new CryptoModel();
            return aCryptoModel.selectCryptoByName(this.name);
        }


        public int IdCrypto
        {
            get => this.idCrypto;
            set => this.idCrypto = value;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public float EuroValue
        {
            get => this.euroValue;
            set => this.euroValue = value;
        }
    }
}
