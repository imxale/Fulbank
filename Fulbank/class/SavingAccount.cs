using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fulbank.Model;
using System.Data;

namespace Fulbank
{
    class SavingAccount : AccountUser
    {
        public SavingAccount(int aType = 2) : base(aType)
        {
            this.idType = aType;
        }
    }
}
