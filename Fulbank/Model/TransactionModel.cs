using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Fulbank.Model
{
    class TransactionModel
    {        
        public int insertTransaction(Transaction aTransac)
        {
            string querry = "INSERT INTO transaction (IDPERSON, IDTERMINAL, IDWALLET, AMOUNT, DATETRANS, ACTION, IDACCOUNTRECEIVER, IDACCOUNTSENDER)"
                + " VALUES(@idperson, @idterminal, @idwallet, @amount, @datetrans, @action, @idreceiver, @idaccountsender)";

            MySqlConnection con = DbMySql.GetDBConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(querry, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.Add("@idperson", MySqlDbType.Int64).Value = aTransac.IdPerson;
            cmd.Parameters.Add("@idterminal", MySqlDbType.Int64).Value = aTransac.IdTerminal;
            cmd.Parameters.Add("@idwallet", MySqlDbType.Int64).Value = aTransac.IdWallet;
            cmd.Parameters.Add("@amount", MySqlDbType.Float).Value = aTransac.Amount ;
            cmd.Parameters.Add("@datetrans", MySqlDbType.Date).Value = DateTime.Now.Date.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@action", MySqlDbType.VarChar).Value = aTransac.Action;
            cmd.Parameters.Add("@idreceiver", MySqlDbType.Int32).Value = aTransac.IdReceiver;
            cmd.Parameters.Add("@idaccountsender", MySqlDbType.Int64).Value = aTransac.IdAccountSender;

            int resultat = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            return resultat;
        }

        public DataTable selectTransactionsFor(int idPerson, int idAccount)
        {
            string sqlCmd = "SELECT IDTRANSACTION, wallet.NAME as 'Nom Wallet', terminal.NAME as 'Nom Terminal', AMOUNT as Montant, DATETRANS 'Date du Transfert', " +
                "ACTION as 'Action', person.USER as 'Nom utilisateur destinataire', transaction.IDACCOUNTRECEIVER as 'Id Compte destinataire' " +
                "FROM transaction " +
                "LEFT JOIN wallet ON wallet.IDWALLET = transaction.IDWALLET " +
                "INNER JOIN terminal ON terminal.IDTERMINAL = transaction.IDTERMINAL " +
                "LEFT JOIN accountuser ON accountuser.IDACCOUNT = transaction.IDACCOUNTRECEIVER " +
                "LEFT JOIN person ON person.IDPERSON = accountuser.IDPERSON " +
                "LEFT JOIN accountype ON accountype.IDACCOUNTTYPE = transaction.IDACCOUNTSENDER " +
                "WHERE transaction.IDPERSON = " + idPerson +" AND IDACCOUNTSENDER = "+idAccount+" " +
                "ORDER BY IDTRANSACTION;";

            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }

        public DataTable selectTransactions()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            dt.Clear();
            string sqlCmd = "SELECT * FROM transaction ";
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());     
            adr.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }
    }
}
