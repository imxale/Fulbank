using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Fulbank.Model
{
    class AccountUserModel
    {
        protected int idType;

        public AccountUserModel(int aType)
        {
            this.idType = aType;
        }

        public int createBankAccount(AccountUser aUser)
        {
            string querry = "INSERT INTO accountuser (IDTYPE, CAP, BALANCE, IDPERSON)"
                + " VALUES(@idtype, @cap, @balance, @idperson)";

            MySqlConnection con = DbMySql.GetDBConn();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(querry, con);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.Add("@idtype", MySqlDbType.Int64).Value = this.idType;
            cmd.Parameters.Add("@cap", MySqlDbType.Int64).Value = aUser.Cap;
            cmd.Parameters.Add("@balance", MySqlDbType.Float).Value = aUser.Balance;
            cmd.Parameters.Add("@idperson", MySqlDbType.Int64).Value = aUser.IdPerson;

            int resultat = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            return resultat;
        }

        public DataTable selectAccount(int idperson)
        {
            string sqlCmd = "SELECT * FROM accountuser WHERE IDPERSON = '" + idperson + "'";

            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }

        public DataTable selectaAccount(int idperson)
        {
            string sqlCmd = "SELECT * FROM accountuser where IDPERSON = '" + idperson + "' AND IDTYPE = '"+this.idType+"'";

            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }

        public DataTable selectaAccountById(int idAccount)
        {
            string sqlCmd = "SELECT * FROM accountuser where IDACCOUNT = '" + idAccount + "' AND IDTYPE = '"+this.idType+"'";

            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }

        public int updateBalance(AccountUser aAccount)
        {
            string querry = "UPDATE accountuser SET BALANCE = @balance WHERE IDPERSON = "+aAccount.IdPerson+" AND IDTYPE = "+this.idType+";";

            MySqlConnection con = DbMySql.GetDBConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(querry, con); 

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.Add("@balance", MySqlDbType.Float).Value = aAccount.Balance;

            int resultat = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            return resultat;
        }

        public int updateBalance2(AccountUser aAccount)
        {
            string querry = "UPDATE accountuser SET BALANCE = @balance WHERE IDACCOUNT = " + aAccount.IdAccount + ";";

            MySqlConnection con = DbMySql.GetDBConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(querry, con);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.Add("@balance", MySqlDbType.Float).Value = aAccount.Balance;

            int resultat = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            return resultat;
        }
    }
}
