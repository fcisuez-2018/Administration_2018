using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Admin.Models;

namespace AdminstratorModule.Models
{
    public class semesterBL
    {


        public static List<semester> GetAll()
        {
            string statement = " select * from semester";
            var ds = DBManager.ExecuteQuery(statement);
            List<semester> GP = new List<semester>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new semester
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        Semester = item["Semester"].ToString(),
                        SemesterFullName = (item["SemesterFullName"].ToString()),
                        SemesterArabicName = (item["SemesterArabicName"].ToString()),
                        SemesterEnumID = int.Parse(item["SemesterEnumID"].ToString()),
                        StatusID=int.Parse(item["StatusID"].ToString())

                    });
            }
            return GP;
        }



        public static int EditActive(int ID, int stID)
        {

            string stataement = "";
            if (stID == 1)
            {
                stataement = $"UPDATE semester  SET StatusID=2 where ID={ID} ";
            }
            else
            {
                stataement = $"UPDATE semester  SET StatusID=1 where ID={ID} ";
            }
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;
        }

     

        public static semester GetById(int id)
        {
            string statement = $"select *  from semester where ID={id}";
            var ds = DBManager.ExecuteQuery(statement);
            var item = ds.Tables[0].Rows[0];
            var Obj = new semester
            {
                ID = int.Parse(item["ID"].ToString()),
                Semester = item["Semester"].ToString(),
                SemesterFullName = (item["SemesterFullName"].ToString()),
                SemesterArabicName = (item["SemesterArabicName"].ToString()),
                SemesterEnumID = int.Parse(item["SemesterEnumID"].ToString()),
                StatusID = int.Parse(item["StatusID"].ToString())
            };

            return Obj;
        }



        public static int Add_Semester(semester s)
        {
            //string statement = $"insert into semester values('{s.Semester}','{s.SemesterFullName}','{s.SemesterArabicName}',{s.SemesterEnumID},{s.StatusID})";
            string statement = $"insert into semester(Semester,SemesterFullName,SemesterArabicName,SemesterEnumID,StatusID) values ('{s.Semester}','{s.SemesterFullName}','{s.SemesterArabicName}',{s.SemesterEnumID},{s.StatusID})";
            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }
        public static List<semester> GetSemesterFullNames()
        {
            string statement = "select ID,Semester from semester";
            var ds = DBManager.ExecuteQuery(statement);
            List<semester> GP = new List<semester>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new semester
                    {

                        ID = int.Parse(item["ID"].ToString()),
                        Semester = item["Semester"].ToString(),
                        //SemesterFullName = (item["SemesterFullName"].ToString()),
                        //SemesterArabicName = (item["SemesterArabicName"].ToString()),
                        //SemesterEnumID = int.Parse(item["SemesterEnumID"].ToString()),
                        //StatusID = int.Parse(item["StatusID"].ToString())


                    });
            }
            return GP;
        }


    }
}