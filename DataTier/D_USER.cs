using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTier;

namespace DataTier
{
    public class D_USER
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

       

        public void InsertUser(E_USER user)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERT_USER", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NAMES", user.NAME);
            cmd.Parameters.AddWithValue("@LASTNAME", user.LASTNAME);
            cmd.Parameters.AddWithValue("@BIRTHDATE", user.BIRTHDATE);
            cmd.Parameters.AddWithValue("@USER_TYPE", user.USER_TYPE);
            cmd.Parameters.AddWithValue("@USER_", user.USER);
            cmd.Parameters.AddWithValue("@PASSWORD_", user.PASSWORD);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable LoginUser(E_USER user)
        {
           
            SqlCommand cmd = new SqlCommand("SP_LOGIN_USER_", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@USER_", user.USER);
            cmd.Parameters.AddWithValue("@PASSWORD_", user.PASSWORD);
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }

}
