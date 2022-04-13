using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Fulbank.Model;

namespace Fulbank
{
    internal class RendezVous
    {
        private int idRendezVous;
        private int idPerson;
        private int idReason;
        private string comment;

        public int IdRendezVous
        {
            get => idRendezVous;
            set => idRendezVous = value;
        }

        public int IdPerson
        {
            get => idPerson;
            set => idPerson = value;
        }

        public int IdReason
        {
            get => idReason;
            set => idReason = value;
        }

        public string Comment
        {
            get => comment;
            set => comment = value;
        }

        public int createRDV()
        {
            RendezVousModel rendezVousModel = new RendezVousModel();
            return rendezVousModel.createRDV(this);
        }

        public DataTable SelectRDV()
        {
            RendezVousModel rendreVous = new RendezVousModel();
            return rendreVous.selectRDV();
        }
    }
}
