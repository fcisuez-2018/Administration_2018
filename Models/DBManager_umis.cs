using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AdminstratorModule.Models
{
    public class DBManager_umis
    {

        public static DataSet ExecuteQuery(string query)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KF9E19V\MO;Initial Catalog=umis;Integrated Security=True");
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            return ds;
        }

        public static int ExecuteNonQuery(string query)
        {
            int affected = 0;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KF9E19V\MO;Initial Catalog=umis;Integrated Security=True");
            SqlCommand command = new SqlCommand(query, con);

            try
            {
                con.Open();
                affected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                con.Close();
            }



            return affected;
        }



    }
}