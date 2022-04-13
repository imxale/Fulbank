using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Fulbank.Model;

namespace Fulbank
{
    class RendezvousType
    {
        private int idRendezvousType;
        private string libelle;

        public int IdRendezvousType
        {
            get => idRendezvousType;
            set => idRendezvousType = value;
        }

        public string Libelle
        {
            get => libelle;
            set => libelle = value;
        }

        public DataTable selectRDVLibelle()
        {
            RendezvousTypeModel unmodel = new RendezvousTypeModel();
            return unmodel.selectRDVLibelle();
        }

        public DataTable selectRDVIdByLibelle()
        {
            RendezvousTypeModel rendezvous = new RendezvousTypeModel();
            return rendezvous.selectRDVIdByLibelle(this.libelle);
        }
    }

}
