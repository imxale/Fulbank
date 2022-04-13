using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Fulbank
{
    class DbMySql
    {
        public static bool ConnexionBDD()
        {
            var Myini = new IniFile("../../../bdd.ini");
            if (Myini.Read("host") == "" && Myini.Read("database") == "" && Myini.Read("username") == "" &&
                Myini.Read("password") == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static MySqlConnection GetDBConn()
        {
            var Myini = new IniFile("../../../bdd.ini");            
            string host = Myini.Read("host");/*10.119.0.240*/
            string database = Myini.Read("database");
            string username = Myini.Read("username");
            string password = Myini.Read("password");

            string connString = @"Server=" + host + ";Database=" + database + ";User Id=" + username + ";Password=" + password + ";SslMode=none";

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

        //test de la connection
        public static void TestConnexion()
        {
            
        }   
    }
}
