using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Fulbank.Model
{
    class SavingAccountModel : AccountUserModel
    {
        public SavingAccountModel(int aType = 2) : base(aType)
        {
            this.idType = aType;
        }
    }
}
