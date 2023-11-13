using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace mymyapp.DL
{
    public class DataLayer
    {

        static SqlConnection con = new SqlConnection("Data Source=DESKTOP-GGM6PE4;Initial Catalog=MobileShop;Integrated Security = True;TrustServerCertificate=Yes;");
        public static void ExecuteQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();

        }
        public static void ExecuteQuery(string query, SqlParameter[] prm)
        {
            SqlCommand command = new SqlCommand(query, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(prm);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            command.Parameters.Clear();

        }

        public static DataTable? ExecuteTable(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

       
      
        public static DataTable ExecuteTable(string query, SqlParameter[] prm)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(prm);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Parameters.Clear(); 
            return dt;
        }
    }
}

