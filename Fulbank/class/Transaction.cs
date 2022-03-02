using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fulbank.Model;
using System.Data;

namespace Fulbank
{
    class Transaction
    {
        private int idTransaction;
        private int idPerson;
        private int idTerminal;
        private int idWallet;
        private float amount;
        private DateTime dateTrans;
        private string action;
        private int idReceiver;
        private int bankDetails;
        private int idAccountSender;
        private bool isVerify = false;

        public int InsertTransaction()
        {
            TransactionModel unetransac = new TransactionModel();
            return unetransac.insertTransaction(this); // La méthode d'insertion renvoit le nombre de lignes insérées
        }

        public DataTable SelectTransactionFor()
        {
            TransactionModel unetransac = new TransactionModel();
            return unetransac.selectTransactionsFor(this.idPerson, this.idAccountSender); // La méthode d'insertion renvoit le nombre de lignes insérées
        }

        public DataTable SelectTransaction()
        {
            TransactionModel unetransac = new TransactionModel();
            return unetransac.selectTransactions(); // La méthode d'insertion renvoit le nombre de lignes insérées
        }

        public int IdTransaction
        {
            get => this.idTransaction;
            set => this.idTransaction = value;
        }

        public int IdPerson
        {
            get => this.idPerson;
            set => this.idPerson = value;
        }
        public int IdTerminal
        {
            get => this.idTerminal;
            set => this.idTerminal = value;
        }
        public int IdWallet
        {
            get => this.idWallet;
            set => this.idWallet = value;
        }

        public float Amount
        {
            get => this.amount;
            set => this.amount = value;
        }

        public DateTime DateTrans
        {
            get => this.dateTrans;
            set => this.dateTrans = value;
        }

        public string Action
        {
            get => this.action;
            set => this.action = value;
        }

        public int IdReceiver
        {
            get => this.idReceiver;
            set => this.idReceiver = value;
        }

        public int BankDetails
        {
            get => this.bankDetails;
            set => this.bankDetails = value;
        }

        public int IdAccountSender
        {
            get => this.idAccountSender;
            set => this.idAccountSender = value;
        }
    }
}
