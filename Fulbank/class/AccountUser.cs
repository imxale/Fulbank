using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fulbank.Model;
using System.Data;
using System.Windows.Forms;

namespace Fulbank
{
    public abstract class AccountUser : IAccount
    {        
        private int idAccount;
        protected int idType;
        private int cap;
        private float balance;
        private int idPerson;            

        public AccountUser(int aType)
        {
            this.idType = aType;
        }
        public int CreateBankAccount()
        {
            AccountUserModel anAccountModel = new AccountUserModel(this.idType);
            return anAccountModel.createBankAccount(this);
        }

        public DataTable selectAccount()
        {
            AccountUserModel anAccountModel = new AccountUserModel(this.idType);
            return anAccountModel.selectAccount(this.idPerson);
        }

        public DataTable selectTheAccount()
        {
            AccountUserModel anAccountModel = new AccountUserModel(this.idType);
            return anAccountModel.selectaAccount(this.IdPerson);
        }

        public int UpdateBalance()
        {
            AccountUserModel anAccountModel = new AccountUserModel(this.idType);
            return anAccountModel.updateBalance(this);
        }

        public int UpdateBalance2()
        {
            AccountUserModel anAccountModel = new AccountUserModel(this.idType);
            return anAccountModel.updateBalance2(this);
        }

        public DataTable selectaAccountById()
        {
            AccountUserModel anAccountModel = new AccountUserModel(this.idType);
            return anAccountModel.selectaAccountById(this.idAccount);
        }

        public void Deposit(float amount)
        {
            this.balance += amount;
        }

        public void Withdrawal(float amount)
        {
            if (this.balance >= amount)
            {
               this.balance -= amount;
            }     
            else
            {
                MessageBox.Show("Vous n'avez pas assez d'argent dans votre compte");
            }            
        }

        public int IdAccount
        {
            get => this.idAccount;
            set => this.idAccount = value;
        }

        public int IdType
        {
            get => this.idType;
            set => this.idType = value;
        }

        public int Cap
        {
            get => this.cap;
            set => this.cap = value;
        }

        public float Balance
        {
            get => this.balance;
            set => this.balance = value;
        }
        
        public int IdPerson
        {
            get => this.idPerson;
            set => this.idPerson = value;
        }

    }
}
