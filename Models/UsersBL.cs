using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AdminstratorModule.Models
{
    public class UsersBL
    {


        public static int CheckExistentUser(Users ob)
        {

            string Query = "select UserID, UserName,Password from uusers";
            var container = DBManager.ExecuteQuery(Query);

            //data that user enter in view
            string username = ob.UserName;
            string password = ob.Password;

            //List<Users> usernameVW= new List<Users>();

            foreach (DataRow item in container.Tables[0].Rows)
            {
                int id= int.Parse(item["UserID"].ToString());
                string usernameDB = item["UserName"].ToString();
                string passwordDB = item["Password"].ToString();

                if (username == usernameDB && password == passwordDB)
                {
                    ob.UserID = id;
                    return id;
                }
            }

            return 0;
        }

     



















    }
}