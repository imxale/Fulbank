using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Fulbank.Model
{
    class PersonModel
    {
        public int insertUser(Person aPerson)
        {                       
            string querry = "INSERT INTO person (IDROLE, NAME, FNAME, BIRTH, MAIL, ADDRESS, CITY, POSTAL, USER, PASSWORD, CREATIONDATE)" 
                + " VALUES(@idrole, @name, @fname, @birth, @mail, @address, @city, @postal, @user, @password, @creationdate)";

            MySqlConnection con = DbMySql.GetDBConn();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(querry,con);
                        
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            
            cmd.Parameters.Add("@idrole", MySqlDbType.Int64).Value = 1;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = aPerson.Name;
            cmd.Parameters.Add("@fname", MySqlDbType.VarChar).Value = aPerson.Fname;
            cmd.Parameters.Add("@birth", MySqlDbType.Date).Value = aPerson.Birth.Date.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@mail", MySqlDbType.VarChar).Value = aPerson.Mail;
            cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = aPerson.Address;
            cmd.Parameters.Add("@city", MySqlDbType.VarChar).Value = aPerson.City;
            cmd.Parameters.Add("@postal", MySqlDbType.Int32).Value = aPerson.Postal;
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = aPerson.User;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = Hash(aPerson.Password+aPerson.CreationDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.Add("@creationdate", MySqlDbType.Date).Value = DateTime.Now.Date.ToString("yyyy-MM-dd");
            
            int resultat = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            return resultat;                       
        }

        public DataTable selectPersonName()
        {
            string sqlCmd = "select USER from person";

            //Execution de la requête
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }

        public DataTable selectPerson(string userName)
        {
            string sqlCmd = "select * FROM person WHERE USER = '" + userName + "'";

            //Execution de la requête
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }

        public DataTable selectPersonAdmin()
        {
            string sqlCmd = "select * FROM person";

            //Execution de la requête
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }

        public DataTable selectCurrentAccount(int userid)
        {
            string sqlCmd = "SELECT * FROM accountuser WHERE IDPERSON = "+userid+" AND IDTYPE = 1;";
            //Execution de la requête
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }

        public DataTable selectSavingAccount(int userid)
        {
            string sqlCmd = "SELECT * FROM accountuser WHERE IDPERSON = " + userid + " AND IDTYPE = 2;";
            //Execution de la requête
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }

        public DataTable selectHomeloanplan(int userid)
        {
            string sqlCmd = "SELECT * FROM accountuser WHERE IDPERSON = " + userid + " AND IDTYPE = 3;";
            //Execution de la requête
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }


        //algorithme de hashage 
        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }

        public int updatePerson(Person aPersonne)
        {
            string querry = "UPDATE person SET IDROLE = @idrole AND NAME = @name" +
                " AND FNAME = @fname" +
                " AND BIRTH = @birth AND MAIL = @mail" +
                " AND ADDRESS = @address AND CITY = @city" +
                " AND POSTAL = @postal AND ISVALID = @isvalid WHERE IDPERSON = "+aPersonne.IdPerson+";";

            MySqlConnection con = DbMySql.GetDBConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(querry, con);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.Add("@idrole", MySqlDbType.Int32).Value = aPersonne.IdRole;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = aPersonne.Name;
            cmd.Parameters.Add("@fname", MySqlDbType.VarChar).Value = aPersonne.Fname;
            cmd.Parameters.Add("@birth", MySqlDbType.Date).Value = aPersonne.Birth;
            cmd.Parameters.Add("@mail", MySqlDbType.VarChar).Value = aPersonne.Mail;
            cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = aPersonne.Address;
            cmd.Parameters.Add("@city", MySqlDbType.VarChar).Value = aPersonne.City;
            cmd.Parameters.Add("@postal", MySqlDbType.Int32).Value = aPersonne.Postal;
            cmd.Parameters.Add("@isvalid", MySqlDbType.Int32).Value = aPersonne.IsValid;

            int resultat = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            return resultat;
        }
    }
}
