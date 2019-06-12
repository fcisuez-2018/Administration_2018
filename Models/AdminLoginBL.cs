using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AdminstratorModule.Models
{
    public class AdminLoginBL
    {
        public static int CheckExistentUser(AdminLogin Adm)
        {

            string Query = " select ID, Password, Username from login where ID=1";
            var container = DBManager.ExecuteQuery(Query);

            //data that user enter in view
            string username = Adm.Username;
            string password = Adm.Password;

            //List<Users> usernameVW= new List<Users>();

            foreach (DataRow item in container.Tables[0].Rows)
            {
                int id = int.Parse(item["userID"].ToString());
                string usernameDB = item["Username"].ToString();
                string PasswordDB= item["Password"].ToString();

                if (username == usernameDB && password == PasswordDB)
                {
                    Adm.ID = id;
                    return id;
                }
            }

            return 0;
        }

   



    }
}