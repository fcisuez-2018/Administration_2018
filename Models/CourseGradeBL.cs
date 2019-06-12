using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AdminstratorModule.Models;
namespace Admin.Models
{
    public class CourseGradeBL
    {

        public static List<CourseGrade> GetAll()
        {
            string statement = "select * from course_grade";
            var ds = DBManager.ExecuteQuery(statement);
            List<CourseGrade> GP = new List<CourseGrade>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new CourseGrade
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        Grade_English = item["Grade_English"].ToString(),
                        Grade_Arabic = item["Grade_Arabic"].ToString(),
                        OrderCode = int.Parse(item["OrderCode"].ToString()),
                        Points = (item["Points"].ToString()),
                        Percentage=(item["Percentage"].ToString()),
                        semesterID = int.Parse(item["semesterID"].ToString()),
                        Notes = item["Notes"].ToString()
                    });
            }
            return GP;
        }


        public static CourseGrade GetById(int id)
        {
            string statement = $"select * from course_grade where ID={id}";
            var ds = DBManager.ExecuteQuery(statement);
            var item = ds.Tables[0].Rows[0];
            var gp = new CourseGrade
            {
                ID = int.Parse(item["ID"].ToString()),
                Grade_English = item["Grade_English"].ToString(),
                Grade_Arabic = item["Grade_Arabic"].ToString(),
                OrderCode = int.Parse(item["OrderCode"].ToString()),
                Points = (item["Points"].ToString()),
                Percentage = (item["Percentage"].ToString()),
                semesterID = int.Parse(item["semesterID"].ToString()),
                Notes = item["Notes"].ToString()

            };

            return gp;
        }

        public static int Insert(CourseGrade s)
        {
            string statement = $"insert into course_grade columns(Grade_English,Grade_Arabic,OrderCode,Points,Percentage,semesterID,Notes) values('{s.Grade_English}','{s.Grade_Arabic}',{s.OrderCode},'{s.Points}',{s.Percentage},{s.semesterID},'{s.Notes}')";
            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }
        public static int Update(CourseGrade s)
        {
            string stataement = $"update course_grade set Grade_English='{s.Grade_English}',Grade_Arabic='{s.Grade_Arabic}',OrderCode={s.OrderCode},Points='{s.Points}',Percentage='{s.Percentage}',semesterID={s.semesterID},Notes='{s.Notes}' where ID={s.ID}";
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;
        }
        public static int Delete(int id)
        {
            string statement = $"update course_grade set ID=0 where ID={id}";
            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }

        public static List<CourseGrade> GetByID(int  ID)
        {
            string statement = $"select * from course_grade where ID ={ID} ";
            var ds = DBManager.ExecuteQuery(statement);
            List<CourseGrade> Emps = new List<CourseGrade>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Emps.Add(
                    new CourseGrade
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        Grade_English = item["Grade_English"].ToString(),
                        Grade_Arabic = item["Grade_Arabic"].ToString(),
                        OrderCode = int.Parse(item["OrderCode"].ToString()),
                        Points = (item["Points"].ToString()),
                        Percentage = (item["Percentage"].ToString()),
                        semesterID = int.Parse(item["semesterID"].ToString()),
                        Notes = item["Notes"].ToString()
                    });
            }
            return Emps;
        }

        public static List<CourseGrade> GetArabicGrades()
        {
            string statement = "select ID,Grade_Arabic from course_grade";
            var ds = DBManager.ExecuteQuery(statement);
            List<CourseGrade> GP = new List<CourseGrade>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new CourseGrade
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        Grade_Arabic = item["Grade_Arabic"].ToString(),


                    });
            }
            return GP;
        }

        public static List<CourseGrade> GetEnglishGrades()
        {
            string statement = "select ID,Grade_English from course_grade";
            var ds = DBManager.ExecuteQuery(statement);
            List<CourseGrade> GP = new List<CourseGrade>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new CourseGrade
                    {

                        ID = int.Parse(item["ID"].ToString()),
                        Grade_English = item["Grade_English"].ToString(),


                    });
            }
            return GP;
        }



    }
}