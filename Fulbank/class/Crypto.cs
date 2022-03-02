using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank
{
    class Crypto
    {
        private int idCrypto;
        private string name;
        private float euroValue;

        public Crypto(string aName, float anEuroValue)
        {
            this.name = aName;
            this.euroValue = anEuroValue;
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
