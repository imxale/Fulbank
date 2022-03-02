using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Fulbank.Model;

namespace Fulbank
{
    class Role
    {
        private int idRole;
        private string name;

        public DataTable SelectRole()
        {
            RoleModel unrole = new RoleModel();
            return unrole.RoleSelector(this.idRole);
        }

        public int IdRole
        {
            get => this.idRole;
            set => this.idRole = value;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

    }
}
