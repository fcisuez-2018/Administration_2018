using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AdminstratorModule.Models;


namespace Admin.Models
{
    public class CourseSemesterBL
    {
        public static List<CourseSemester> GetAll()
        {
            string statement = "select c.ID, c.CODE,c.ArabicName,c.Course,s.Semester,s.SemesterFullName,d.ID, d.NameTxt,d.Arabic_doctorName from course c,semester s,course_semester cs ,doctor d where c.ID=cs.CourseID and s.ID=cs.SemesterID and d.ID=cs.DoctorID order BY c.ID";
            var ds = DBManager.ExecuteQuery(statement);
            List<CourseSemester> GP = new List<CourseSemester>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new CourseSemester
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        Code = item["CODE"].ToString(),
                        ArabicName = item["ArabicName"].ToString(),
                        _Course = item["Course"].ToString(),
                        Semester = item["Semester"].ToString(),
                        SemesterFullName = (item["SemesterFullName"].ToString()),
                        DoctorID = int.Parse(item["ID"].ToString()),
                        Name_Txt = (item["NameTxt"].ToString()),
                        Arabic_doctorName=(item["Arabic_doctorName"].ToString())
                    });
            }
            return GP;
        }
        public static List<CourseSemester> GetSemesterFullNames()
        {
            string statement = "select semester.ID,Semester from semester";
            var ds = DBManager.ExecuteQuery(statement);
            List<CourseSemester> GP = new List<CourseSemester>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new CourseSemester
                    {

                       ID_sem = int.Parse(item["ID"].ToString()),

                        Semester = item["Semester"].ToString(),
                        //SemesterFullName = (item["SemesterFullName"].ToString()),
                        //SemesterArabicName = (item["SemesterArabicName"].ToString()),
                        //SemesterEnumID = int.Parse(item["SemesterEnumID"].ToString()),
                        //StatusID = int.Parse(item["StatusID"].ToString())


                    });
            }
            return GP;
        }

        public static int Update(CourseSemester l)
        {
            string stataement = $"update course,semester,course_semester,doctor set course.ID={l.ID},course.Code='{l.Code}', course.ArabicName='{l.ArabicName}', course.Course='{l._Course}',semester.SemesterFullName='{l.SemesterFullName}',doctor.DoctorID={l.DoctorID},doctor.NameTxt='{l.Name_Txt}',doctor.Arabic_doctorName='{l.Arabic_doctorName}' where ID={l.ID}" ;
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;

        }

        public static List<CourseSemester> GetById (int id)
        {
            string statement = "select c.ID, c.CODE,c.ArabicName,c.Course,s.Semester,s.SemesterFullName,d.ID, d.NameTxt,d.Arabic_doctorName from course c,semester s,course_semester cs ,doctor d where c.ID=cs.CourseID and s.ID=cs.SemesterID and d.ID=cs.DoctorID order BY c.ID";
            var ds = DBManager.ExecuteQuery(statement);
            List<CourseSemester> GP = new List<CourseSemester>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new CourseSemester
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        Code = item["CODE"].ToString(),
                        ArabicName = item["ArabicName"].ToString(),
                        _Course = item["Course"].ToString(),
                        Semester = item["Semester"].ToString(),
                        SemesterFullName = (item["SemesterFullName"].ToString()),
                        DoctorID = int.Parse(item["DoctorID"].ToString()),
                        Name_Txt = (item["NameTxt"].ToString()),
                        Arabic_doctorName = (item["Arabic_doctorName"].ToString())
                    });
            }
            return GP;
        }




    }
}