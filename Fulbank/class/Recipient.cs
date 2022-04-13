using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Fulbank.Model;

namespace Fulbank
{
    class Recipient
    {
        private int idRecipient;
        private string name;
        private int accountNumber;
        private int idPerson;

        public DataTable SelectAllRecipientFor()
        {
            RecipientModel unepersonne = new RecipientModel();
            return unepersonne.selectAllRecipientFor(this.idPerson);
        }

        public DataTable SelectAllRecipient()
        {
            RecipientModel unepersonne = new RecipientModel();
            return unepersonne.selectAllRecipient();
        }

        public DataTable SelectRecipientByName()
        {
            RecipientModel unepersonne = new RecipientModel();
            return unepersonne.selectRecipientByName(this.name);
        }

        public DataTable SelectIdType()
        {
            RecipientModel unepersonne = new RecipientModel();
            return unepersonne.selectIdType(this.name);
        }

        public int InsertRecipient()
        {
            RecipientModel unepersone = new RecipientModel();
            return unepersone.insertRecipient(this);
        }

        public int DeleteRecipient()
        {
            RecipientModel aRecipient = new RecipientModel();
            return aRecipient.deleteRecipient(this);
        }

        public int IdRecipient
        {
            get => this.idRecipient;
            set => this.idRecipient = value;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int AccountNumber
        {
            get => this.accountNumber;
            set => this.accountNumber = value;
        }

        public int IdPerson
        {
            get => this.idPerson;
            set => this.idPerson = value;
        }
    }   
}
