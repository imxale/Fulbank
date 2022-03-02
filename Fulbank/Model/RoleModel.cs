using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Fulbank.Model
{
    class RoleModel
    {
        public DataTable RoleSelector(int idrole)
        {
            MySqlConnection conn = DbMySql.GetDBConn();

            //Requête pour selectionner le mot de passe et la date de création du compte
            string sqlCmd = "select NAME FROM role WHERE IDROLE = '" + idrole  + "'";

            //Execution de la requête
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, conn);
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt); //opens and closes the DB connection automatically !! (fetches from pool)                      
            return dt;
        }
    }
}
