using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AdminstratorModule.Models
{
    public class DBManager
    {
        public static DataSet ExecuteQuery(string Query)
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            
            MySqlDataAdapter Adapter = new MySqlDataAdapter(Query,con);
            DataSet ds = new DataSet();
            Adapter.Fill(ds);
            return ds;

        }

        public static int ExecuteNonQuery(string Query)
        {
            int affected;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            MySqlCommand command = new MySqlCommand(Query, con);
            //SqlCommand command = new SqlCommand(Query, con);
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