using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Fulbank.Model
{
    class RendezVousModel
    {
        public int createRDV(RendezVous aRDV)
        {
            string querry = "INSERT INTO rendezvous (IDPERSON, IDREASON, COMMENT)"
                + " VALUES(@idperson, @idreason, @comment)";

            MySqlConnection con = DbMySql.GetDBConn();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(querry, con);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.Add("@idperson", MySqlDbType.Int64).Value = aRDV.IdPerson;
            cmd.Parameters.Add("@idreason", MySqlDbType.Int64).Value = aRDV.IdReason;
            cmd.Parameters.Add("@comment", MySqlDbType.VarChar).Value = aRDV.Comment;

            int resultat = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            return resultat;
        }

        public DataTable selectRDV()
        {
            string query = "SELECT IDRENDEZVOUS, IDPERSON, LIBELLE, COMMENT FROM rendezvous " +
                "RV INNER JOIN rendezvoustype RT ON RV.IDREASON = RT.IDRENDEZVOUSTYPE ";

            MySqlDataAdapter adr = new MySqlDataAdapter(query, DbMySql.GetDBConn());
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);
            return dt;
        }

    }
}
