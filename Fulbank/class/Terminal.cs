using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank
{
    class Terminal
    {
        private int idTerminal;
        private string name;
        private float ip;
        private string agency;

        public Terminal(string aName, int anIp, string anAgency)
        {
            this.name = aName;
            this.ip = anIp;
            this.agency = anAgency;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public float Ip
        {
            get => this.ip;
            set => this.ip = value;
        }

        public string Agency
        {
            get => this.agency;
            set => this.agency = value;
        }
    }
}
