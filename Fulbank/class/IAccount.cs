using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Fulbank
{
    public interface IAccount
    {
        void Deposit(float montant);
        void Withdrawal(float montant);
        int UpdateBalance();
        int UpdateBalance2();
        DataTable selectaAccountById();
        int IdPerson { get; set;}
        float Balance { get; set; }
        int IdAccount { get; set; }
        int Cap { get; set; }
        int CreateBankAccount();
    }
}
