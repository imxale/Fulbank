using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fulbank.Model;
using System.Data;

namespace Fulbank
{
    class HomeLoanPlan : AccountUser
    {
        public HomeLoanPlan(int aType = 3) : base(aType)
        {
            this.idType = aType;
        }
    }
}
