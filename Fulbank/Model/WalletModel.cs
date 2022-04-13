using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Fulbank.Model
{
    class WalletModel
    {
        public int createWallet(Wallet aWallet)
        {
            string querry = " INSERT INTO wallet(NOMCRYPTO,IDPERSON,NAME) " +
                "VALUES(@nomCrypto,@idPerson, @name)";

            MySqlConnection con = DbMySql.GetDBConn();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(querry, con);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.Add("@nomCrypto", MySqlDbType.VarChar).Value = aWallet.NomCrypto;
            cmd.Parameters.Add("@idPerson", MySqlDbType.Int64).Value = aWallet.IdPerson;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = aWallet.Name;

            int resultat = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            return resultat;
        }

        public int updateBalance(Wallet aWallet)
        {
            string querry = "UPDATE wallet SET QUANTITY = @quantity WHERE IDWALLET = " + aWallet.IdWallet + "";

            MySqlConnection con = DbMySql.GetDBConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(querry, con);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.Add("@quantity", MySqlDbType.Float).Value = aWallet.Quantity;

            int resultat = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            return resultat;
        }

        public int updateBalance2(Wallet aWallet)
        {
            string querry = "UPDATE wallet SET QUANTITY = @quantity WHERE NOMCRYPTO = '" + aWallet.NomCrypto + "' AND IDPERSON = " + aWallet.IdPerson + "";

            MySqlConnection con = DbMySql.GetDBConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(querry, con);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.Add("@quantity", MySqlDbType.Float).Value = aWallet.Quantity;

            int resultat = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();    
            return resultat;
        }

        public DataTable selectWallet(int idPerson)
        {
            string sql = "SELECT IDWALLET, wallet.NAME, NOMCRYPTO, QUANTITY " +
            " FROM wallet " + 
            " WHERE IDPERSON = " + idPerson + "";

            MySqlDataAdapter adr = new MySqlDataAdapter(sql, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }    
        
        public int deleteWallet(Wallet aWallet)
        {
            string querry = "DELETE FROM wallet WHERE IDWALLET = @id";

            MySqlConnection con = DbMySql.GetDBConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(querry, con);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = aWallet.IdWallet;

            int resultat = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            return resultat;
        }

        public int ChangeWalletName(Wallet aWallet)
        {
            string sql = "UPDATE wallet SET NAME = @name WHERE IDWALLET = @id";

            MySqlConnection con = DbMySql.GetDBConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.Add("name", MySqlDbType.VarChar).Value = aWallet.Name;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = aWallet.IdWallet;

            int resultat = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            return resultat;
        }

    }
}
