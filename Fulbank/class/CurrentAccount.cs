using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fulbank.Model;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Fulbank
{
    public class CurrentAccount : AccountUser , IAccount
    {
        public CurrentAccount(int aType = 1) : base(aType)
        {
            this.idType = aType;
        }
    }
}
