using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Fulbank.Model
{
    class RecipientModel
    {
        public DataTable selectAllRecipientFor(int PersonId)
        {
            string sqlCmd = "SELECT * FROM recipient WHERE idPerson = '" + PersonId + "'";

            //Execution de la requête
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }
        public DataTable selectAllRecipient()
        {
            string sqlCmd = "SELECT * FROM recipient";

            //Execution de la requête
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }

        public DataTable selectRecipientByName(string name)
        {
            string sqlCmd = "SELECT * FROM recipient WHERE NAME = '"+ name +"'";

            //Execution de la requête
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }

        public int insertRecipient(Recipient aRecipient)
        {
            string querry = "INSERT INTO recipient (NAME, ACCOUNTNUMBER, IDPERSON)"
                + " VALUES(@name, @accountnumber, @idperson)";

            MySqlConnection con = DbMySql.GetDBConn();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(querry, con);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = aRecipient.Name;
            cmd.Parameters.Add("@accountnumber", MySqlDbType.Int32).Value = aRecipient.AccountNumber;
            cmd.Parameters.Add("@idperson", MySqlDbType.Int32).Value = aRecipient.IdPerson;

            int resultat = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            return resultat;
        }
        public DataTable selectIdType(string name)
        {
            string sqlCmd = "SELECT IDACCOUNTTYPE FROM recipient " +
                " INNER JOIN accountuser ON recipient.ACCOUNTNUMBER = accountuser.IDACCOUNT " +
                " INNER JOIN accountype ON accountype.IDACCOUNTTYPE = accountuser.IDTYPE " +
                " WHERE recipient.NAME = '" + name + "'";    
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }
    }
}
