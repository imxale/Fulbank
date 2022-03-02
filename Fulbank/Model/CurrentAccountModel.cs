using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Fulbank.Model
{
    class CurrentAccountModel : AccountUserModel
    {
        public CurrentAccountModel(int aType = 1) : base(aType)
        {
            this.idType = aType;
        }
    }
}
