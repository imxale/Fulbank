using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Fulbank.Model
{
    class RendezvousTypeModel
    {
        public DataTable selectRDVLibelle()
        {
            string sqlCmd = "SELECT LIBELLE FROM rendezvoustype";

            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }

        public DataTable selectRDVIdByLibelle(string libelle)
        {
            string sqlCmd = "SELECT IDRENDEZVOUSTYPE FROM rendezvoustype where libelle = '" + libelle + "'";

            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }
    }
}
