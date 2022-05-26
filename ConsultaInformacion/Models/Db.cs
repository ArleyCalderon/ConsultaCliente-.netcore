using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace ConsultaInformacion.Models
{
    public class Db
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R73A9RK;Initial Catalog=DbSearchInformation;Integrated Security=True");
        public int LoginCheck(Ad_Login ad)
        {
            SqlCommand com = new SqlCommand("Sp_Login", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Admin_id", ad.Admin_id);
            com.Parameters.AddWithValue("@Password", ad.Admin_Pass);
            SqlParameter oblogin = new SqlParameter();
            oblogin.ParameterName = "@Isvalid";
            oblogin.SqlDbType = SqlDbType.Bit;
            oblogin.Direction = ParameterDirection.Output;
            com.Parameters.Add(oblogin);
            con.Open();
            com.ExecuteNonQuery();
            int res = Convert.ToInt32(oblogin.Value);
            con.Close();
            return res;
        }
    }
}
