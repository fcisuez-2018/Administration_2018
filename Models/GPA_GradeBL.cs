using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AdminstratorModule.Models;
namespace Admin.Models
{
public class GPA_GradeBL
 {
      public static List<GPA_Grade> GetAll()
        {
            string statement = "select * from gpa_grade";
            var ds = DBManager.ExecuteQuery(statement);
            List<GPA_Grade> GP = new List<GPA_Grade>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new GPA_Grade
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        Grade_English = item["Grade_English"].ToString(),
                        Grade_Arabic = item["Grade_Arabic"].ToString(),
                        OrderCode = int.Parse(item["OrderCode"].ToString()),
                        Points = (item["Points"].ToString()),
                        semesterID = int.Parse(item["semesterID"].ToString()),
                        Course_Points = (item["Course_Points"].ToString()),
                        Course_cr_points = (item["Course_cr_points"].ToString())
                    });
            }
            return GP;
        }
        public static GPA_Grade GetById(int id)
        {
            string statement = $"select * from gpa_grade where id={id}";
            var ds = DBManager.ExecuteQuery(statement);
            var item = ds.Tables[0].Rows[0];
            var gp = new GPA_Grade
            {
                ID = int.Parse(item["ID"].ToString()),
                Grade_English = item["Grade_English"].ToString(),
                Grade_Arabic = item["Grade_Arabic"].ToString(),
                OrderCode = int.Parse(item["OrderCode"].ToString()),
                Points = (item["Points"].ToString()),
                semesterID = int.Parse(item["semesterID"].ToString()),
                Course_Points = (item["Course_Points"].ToString()),
                Course_cr_points = (item["Course_cr_points"].ToString())

            };

            return gp;
        }

        public static int Insert(GPA_Grade s)
        {
            string statement = $"insert into gpa_grade columns(Grade_English,Grade_Arabic,OrderCode,Points,semesterID,Course_Points, Course_cr_points) values('{s.Grade_English}','{s.Grade_Arabic}',{s.OrderCode},{s.Points},{s.semesterID},{s.Course_Points},{s.Course_cr_points})";
            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }
        public static int Update(GPA_Grade s)
        {
            string stataement = $"update gpa_grade set Grade_English='{s.Grade_English}',Grade_Arabic='{s.Grade_Arabic}',OrderCode={s.OrderCode},Points={s.Points},semesterID={s.semesterID},Course_Points='{s.Course_Points}',Course_cr_points='{s.Course_cr_points}' where ID={s.ID}";
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;
        }
        public static int Delete(int id)
        {
            string statement = $"update gpa_grade set ID=0 where ID={id}";
            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }

        public static List<GPA_Grade> GetSemesterID()
        {
            string statement = "select ID,semesterID from gpa_grade ";
            var ds = DBManager.ExecuteQuery(statement);
            List<GPA_Grade> GP = new List<GPA_Grade>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new GPA_Grade
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        semesterID = int.Parse(item["ID"].ToString()),
                      
                    });
            }
            return GP;
        }


    }

    }
