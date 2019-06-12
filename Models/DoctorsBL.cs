using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AdminstratorModule.Models;

namespace AdminstratorModule.Models
{
    public class DoctorsBL
    {
        public static List<Doctors> GetAll()
        {
            string statement = "select * from doctor";
            var ds = DBManager.ExecuteQuery(statement);
            List<Doctors> GP = new List<Doctors>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new Doctors
                    {
                        ID=int.Parse(item["ID"].ToString()),
                        Name_Txt=(item["NameTxt"].ToString()),
                        StatusID = int.Parse(item["StatusID"].ToString()),
                        //OrderCode = int.Parse(item["OrderCode"].ToString()),
                        Arabic_doctorName = (item["Arabic_doctorName"].ToString()),

                    });
            }
            return GP;
        }



        public static Doctors GetById( int id)
        {
            string statement = $"select * from doctor where ID={id}";
            var ds = DBManager.ExecuteQuery(statement);
            Doctors GP = new Doctors();
            foreach (DataRow item in ds.Tables[0].Rows)
            {

                GP=    new Doctors
                {
                    ID = int.Parse(item["ID"].ToString()),
                    Name_Txt = (item["NameTxt"].ToString()),
                    StatusID = int.Parse(item["StatusID"].ToString()),
                    //OrderCode = int.Parse(item["OrderCode"].ToString()),
                    Arabic_doctorName = (item["Arabic_doctorName"].ToString()),

                };
            }
            return GP;
        }
        public static int Update(Doctors l)
        {
            string stataement = $"update doctor set ID={l.ID},NameTxt='{l.Name_Txt}',StatusID={l.StatusID}, OrderCode={l.OrderCode},Arabic_doctorName='{l.Arabic_doctorName}' where ID={l.ID}";
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;

        }


        public static int EditActive(int ID, int stID)
        {

            string stataement = "";
            if (stID == 1)
            {
                stataement = $"UPDATE doctor  SET StatusID=2 where ID={ID} ";
            }
            else
            {
                stataement = $"UPDATE doctor  SET StatusID=1 where ID={ID} ";
            }
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;
        }


    }
}