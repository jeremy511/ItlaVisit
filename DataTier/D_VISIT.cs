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
    public class D_VISIT
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);  
        
        public List<E_VISIT> ListAllVisit ()
    {
            SqlDataReader READER;
            SqlCommand command = new SqlCommand("SP_SELECT_VISIT", conn);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();

            READER = command.ExecuteReader();

            List<E_VISIT> List = new List<E_VISIT>();
            while (READER.Read())
            {
                List.Add(new E_VISIT
                {
                    ID_VISIT = READER.GetInt32(0),
                    CODE = READER.GetString(1),
                    NAME = READER.GetString(2),
                    LASTNAME = READER.GetString(3),
                    ID_CAREER = READER.GetInt32(4),
                    CAREER = READER.GetString(5),
                    MAIL = READER.GetString(6),
                    ID_BUILDING = READER.GetInt32(7),
                    BUILDING = READER.GetString(8),
                    ID_SECTION = READER.GetInt32(9),
                    SECTION = READER.GetString(10),
                    CHECKIN = READER.GetDateTime(11),
                    CHECKOUT = READER.GetDateTime(12),
                    REASON = READER.GetString(13)
                });
            }
            conn.Close();
            READER.Close();
            return List;

        }

        public void InsertVisit(E_VISIT visit)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERT_VISIT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NAME_VISIT", visit.NAME);
            cmd.Parameters.AddWithValue("@LASTNAME", visit.LASTNAME);
            cmd.Parameters.AddWithValue("@ID_CAREER", visit.ID_CAREER);
            cmd.Parameters.AddWithValue("@MAIL", visit.MAIL);
            cmd.Parameters.AddWithValue("@ID_BUILDING", visit.ID_BUILDING);
            cmd.Parameters.AddWithValue("@ID_SECTION", visit.ID_SECTION);
            cmd.Parameters.AddWithValue("@CHECKIN", visit.CHECKIN);
            cmd.Parameters.AddWithValue("@CHECKOUT", visit.CHECKOUT);
            cmd.Parameters.AddWithValue("@REASON", visit.REASON);


            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditVisit(E_VISIT visit)
        {
            SqlCommand cmd = new SqlCommand("SP_EDIT_VISIT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID_VISIT", visit.ID_VISIT);
            cmd.Parameters.AddWithValue("@NAME_VISIT", visit.NAME);
            cmd.Parameters.AddWithValue("@LASTNAME", visit.LASTNAME);
            cmd.Parameters.AddWithValue("@ID_CAREER", visit.ID_CAREER);
            cmd.Parameters.AddWithValue("@MAIL", visit.MAIL);
            cmd.Parameters.AddWithValue("@ID_BUILDING", visit.ID_BUILDING);
            cmd.Parameters.AddWithValue("@ID_SECTION", visit.ID_SECTION);
            cmd.Parameters.AddWithValue("@CHECKIN", visit.CHECKIN);
            cmd.Parameters.AddWithValue("@CHECKOUT", visit.CHECKOUT);
            cmd.Parameters.AddWithValue("@REASON", visit.REASON);


            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteVisit(E_VISIT visit)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETE_VISIT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID", visit.ID_VISIT);

            cmd.ExecuteNonQuery();
            conn.Close();

        }



    }


}
