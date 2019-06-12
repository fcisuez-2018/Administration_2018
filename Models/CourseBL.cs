using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AdminstratorModule.Models;

namespace Admin.Models
{
    public class CourseBL
    {
        public static List<Course> GetAll()
        {
            string statement = "select * from course";
            var ds = DBManager.ExecuteQuery(statement);
            List<Course> cr = new List<Course>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                cr.Add(
                    new Course
                    {
                        ID =int.Parse(item["ID"].ToString()),
                        Code =item["CODE"].ToString(),
                        ArabicName =item["ArabicName"].ToString(),
                        _Course =item["Course"].ToString(),
                        Credits = int.Parse(item["Credits"].ToString()),
                        Prerequisits = item["Prerequisits"].ToString(),
                        // CourseTypeID = int.Parse(item["CourseTypeID"].ToString()),
                        // Teaching_Hours_Lecture = int.Parse(item["Teaching Hours Lecture"].ToString()),
                        // Teching_Hours_Tutorial = (item["Teching Hours Tutorial"].ToString()),
                        //TeachingHours_Practical = (item["TeachingHours Practical"].ToString()),
                        // Midterm = decimal.Parse(item["Midterm"].ToString()),
                        // Year_Work_Grades_O = decimal.Parse(item["Year Work Grades O"].ToString()),
                        // Year_Work_Grades_PE = decimal.Parse(item["Year Work Grades PE"].ToString()),
                        // Year_Work_Grades_G = decimal.Parse(item["Year Work Grades G"].ToString()),
                        FinalExam = (item["FinalExam"].ToString()),
                        TimeofExam = int.Parse(item["TimeofExam"].ToString()),
                        DepartmentID=int.Parse(item["DepartmentID"].ToString()),
                        LeveLID=int.Parse(item["LeveLID"].ToString()),
                        StatusID = int.Parse(item["StatusID"].ToString())


                    });
            }
            return cr;
        }


        public static List<Course> GetAll_IT()
        {
            string statement = "select * from course where DepartmentID=3";
            var ds = DBManager.ExecuteQuery(statement);
            List<Course> cr = new List<Course>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                cr.Add(
                    new Course
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        Code = item["CODE"].ToString(),
                        ArabicName = item["ArabicName"].ToString(),
                        _Course = item["Course"].ToString(),
                        Credits = int.Parse(item["Credits"].ToString()),
                        Prerequisits = item["Prerequisits"].ToString(),
                        // CourseTypeID = int.Parse(item["CourseTypeID"].ToString()),
                        // Teaching_Hours_Lecture = int.Parse(item["Teaching Hours Lecture"].ToString()),
                        // Teching_Hours_Tutorial = (item["Teching Hours Tutorial"].ToString()),
                        //TeachingHours_Practical = (item["TeachingHours Practical"].ToString()),
                        // Midterm = decimal.Parse(item["Midterm"].ToString()),
                        // Year_Work_Grades_O = decimal.Parse(item["Year Work Grades O"].ToString()),
                        // Year_Work_Grades_PE = decimal.Parse(item["Year Work Grades PE"].ToString()),
                        // Year_Work_Grades_G = decimal.Parse(item["Year Work Grades G"].ToString()),
                        FinalExam = (item["FinalExam"].ToString()),
                        TimeofExam = int.Parse(item["TimeofExam"].ToString()),
                        DepartmentID = int.Parse(item["DepartmentID"].ToString()),
                        LeveLID = int.Parse(item["LeveLID"].ToString()),
                        StatusID = int.Parse(item["StatusID"].ToString())


                    });
            }
            return cr;
        }



        public static List<Course> GetAll_CS()
        {
            string statement = "select * from course where DepartmentID=1";
            var ds = DBManager.ExecuteQuery(statement);
            List<Course> cr = new List<Course>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                cr.Add(
                    new Course
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        Code = item["CODE"].ToString(),
                        ArabicName = item["ArabicName"].ToString(),
                        _Course = item["Course"].ToString(),
                        Credits = int.Parse(item["Credits"].ToString()),
                        Prerequisits = item["Prerequisits"].ToString(),
                        // CourseTypeID = int.Parse(item["CourseTypeID"].ToString()),
                        // Teaching_Hours_Lecture = int.Parse(item["Teaching Hours Lecture"].ToString()),
                        // Teching_Hours_Tutorial = (item["Teching Hours Tutorial"].ToString()),
                        //TeachingHours_Practical = (item["TeachingHours Practical"].ToString()),
                        // Midterm = decimal.Parse(item["Midterm"].ToString()),
                        // Year_Work_Grades_O = decimal.Parse(item["Year Work Grades O"].ToString()),
                        // Year_Work_Grades_PE = decimal.Parse(item["Year Work Grades PE"].ToString()),
                        // Year_Work_Grades_G = decimal.Parse(item["Year Work Grades G"].ToString()),
                        FinalExam = (item["FinalExam"].ToString()),
                        TimeofExam = int.Parse(item["TimeofExam"].ToString()),
                        DepartmentID = int.Parse(item["DepartmentID"].ToString()),
                        LeveLID = int.Parse(item["LeveLID"].ToString()),
                        StatusID=int.Parse(item["StatusID"].ToString())


                    });
            }
            return cr;
        }
        public static List<Course> GetAll_General()
        {
            string statement = "select * from course where DepartmentID=5";
            var ds = DBManager.ExecuteQuery(statement);
            List<Course> cr = new List<Course>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                cr.Add(
                    new Course
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        Code = item["CODE"].ToString(),
                        ArabicName = item["ArabicName"].ToString(),
                        _Course = item["Course"].ToString(),
                        Credits = int.Parse(item["Credits"].ToString()),
                        Prerequisits = item["Prerequisits"].ToString(),
                        // CourseTypeID = int.Parse(item["CourseTypeID"].ToString()),
                        // Teaching_Hours_Lecture = int.Parse(item["Teaching Hours Lecture"].ToString()),
                        // Teching_Hours_Tutorial = (item["Teching Hours Tutorial"].ToString()),
                        //TeachingHours_Practical = (item["TeachingHours Practical"].ToString()),
                        // Midterm = decimal.Parse(item["Midterm"].ToString()),
                        // Year_Work_Grades_O = decimal.Parse(item["Year Work Grades O"].ToString()),
                        // Year_Work_Grades_PE = decimal.Parse(item["Year Work Grades PE"].ToString()),
                        // Year_Work_Grades_G = decimal.Parse(item["Year Work Grades G"].ToString()),
                        FinalExam = (item["FinalExam"].ToString()),
                        TimeofExam = int.Parse(item["TimeofExam"].ToString()),
                        DepartmentID = int.Parse(item["DepartmentID"].ToString()),
                        LeveLID = int.Parse(item["LeveLID"].ToString()),
                        StatusID = int.Parse(item["StatusID"].ToString())


                    });
            }
            return cr;
        }
        public static List<Course> GetAll_IS()
        {
            string statement = "select * from course where DepartmentID=2";
            var ds = DBManager.ExecuteQuery(statement);
            List<Course> cr = new List<Course>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                cr.Add(
                    new Course
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        Code = item["CODE"].ToString(),
                        ArabicName = item["ArabicName"].ToString(),
                        _Course = item["Course"].ToString(),
                        Credits = int.Parse(item["Credits"].ToString()),
                        Prerequisits = item["Prerequisits"].ToString(),
                        // CourseTypeID = int.Parse(item["CourseTypeID"].ToString()),
                        // Teaching_Hours_Lecture = int.Parse(item["Teaching Hours Lecture"].ToString()),
                        // Teching_Hours_Tutorial = (item["Teching Hours Tutorial"].ToString()),
                        //TeachingHours_Practical = (item["TeachingHours Practical"].ToString()),
                        // Midterm = decimal.Parse(item["Midterm"].ToString()),
                        // Year_Work_Grades_O = decimal.Parse(item["Year Work Grades O"].ToString()),
                        // Year_Work_Grades_PE = decimal.Parse(item["Year Work Grades PE"].ToString()),
                        // Year_Work_Grades_G = decimal.Parse(item["Year Work Grades G"].ToString()),
                        FinalExam = (item["FinalExam"].ToString()),
                        TimeofExam = int.Parse(item["TimeofExam"].ToString()),
                        DepartmentID = int.Parse(item["DepartmentID"].ToString()),
                        LeveLID = int.Parse(item["LeveLID"].ToString()),
                        StatusID = int.Parse(item["StatusID"].ToString())


                    });
            }
            return cr;
        }

        public static List<Course> GetAll_SE()
        {
            string statement = "select * from course where DepartmentID=4";
            var ds = DBManager.ExecuteQuery(statement);
            List<Course> cr = new List<Course>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                cr.Add(
                    new Course
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        Code = item["CODE"].ToString(),
                        ArabicName = item["ArabicName"].ToString(),
                        _Course = item["Course"].ToString(),
                        Credits = int.Parse(item["Credits"].ToString()),
                        Prerequisits = item["Prerequisits"].ToString(),
                        // CourseTypeID = int.Parse(item["CourseTypeID"].ToString()),
                        // Teaching_Hours_Lecture = int.Parse(item["Teaching Hours Lecture"].ToString()),
                        // Teching_Hours_Tutorial = (item["Teching Hours Tutorial"].ToString()),
                        //TeachingHours_Practical = (item["TeachingHours Practical"].ToString()),
                        // Midterm = decimal.Parse(item["Midterm"].ToString()),
                        // Year_Work_Grades_O = decimal.Parse(item["Year Work Grades O"].ToString()),
                        // Year_Work_Grades_PE = decimal.Parse(item["Year Work Grades PE"].ToString()),
                        // Year_Work_Grades_G = decimal.Parse(item["Year Work Grades G"].ToString()),
                        FinalExam = (item["FinalExam"].ToString()),
                        TimeofExam = int.Parse(item["TimeofExam"].ToString()),
                        DepartmentID = int.Parse(item["DepartmentID"].ToString()),
                        LeveLID = int.Parse(item["LeveLID"].ToString()),
                        StatusID = int.Parse(item["StatusID"].ToString())


                    });
            }
            return cr;
        }



        public static List<Course> GetCoursesFullNames()
        {
            string statement = "select ID , Course from course";
            var ds = DBManager.ExecuteQuery(statement);
            List<Course> GP = new List<Course>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new Course
                    {

                        ID = int.Parse(item["ID"].ToString()),
                        _Course = item["Course"].ToString(),

                    });
            }
            return GP;
        }


        public static Course GetByID(int id)
        {
            string statement = $"select * from course where ID={id}";
            var ds = DBManager.ExecuteQuery(statement);
            var item = ds.Tables[0].Rows[0];
            var Obj = new Course
            {
                ID = int.Parse(item["ID"].ToString()),
                Code = item["CODE"].ToString(),
                ArabicName = item["ArabicName"].ToString(),
                _Course = item["Course"].ToString(),
                Credits = int.Parse(item["Credits"].ToString()),
                Prerequisits = item["Prerequisits"].ToString(),
                // CourseTypeID = int.Parse(item["CourseTypeID"].ToString()),
                // Teaching_Hours_Lecture = int.Parse(item["Teaching Hours Lecture"].ToString()),
                // Teching_Hours_Tutorial = (item["Teching Hours Tutorial"].ToString()),
                //TeachingHours_Practical = (item["TeachingHours Practical"].ToString()),
                // Midterm = decimal.Parse(item["Midterm"].ToString()),
                // Year_Work_Grades_O = decimal.Parse(item["Year Work Grades O"].ToString()),
                // Year_Work_Grades_PE = decimal.Parse(item["Year Work Grades PE"].ToString()),
                // Year_Work_Grades_G = decimal.Parse(item["Year Work Grades G"].ToString()),
                FinalExam = (item["FinalExam"].ToString()),
                TimeofExam = int.Parse(item["TimeofExam"].ToString()),
                DepartmentID = int.Parse(item["DepartmentID"].ToString()),
                LeveLID = int.Parse(item["LeveLID"].ToString()),
                StatusID = int.Parse(item["StatusID"].ToString())

            };

            return Obj;
        }


        public static int Update(Course s)
        {
            string stataement = $"update course set CODE='{s.Code}',ArabicName='{s.ArabicName}',Course='{s._Course}',Credits={s.Credits},Prerequisits='{s.Prerequisits}',FinalExam='{s.FinalExam}',TimeofExam={s.TimeofExam},DepartmentID={s.DepartmentID},LeveLID={s.LeveLID} where ID={s.ID}";
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;

        }

        public static int EditActive(int ID, int stID)
        {

            string stataement = "";
            if (stID == 1)
            {
                stataement = $"UPDATE course SET StatusID=2 where ID={ID} ";
            }
            else
            {
                stataement = $"UPDATE course  SET StatusID=1 where ID={ID} ";
            }
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;
        }


        public static int Add(Course m)
        {
            string stm = $"INSERT INTO course(CODE,ArabicName,Course,Credits,Prerequisits,FinalExam,TimeofExam,DepartmentID,LeveLID,StatusID) values ('{m.Code}','{m.ArabicName}','{m._Course}',{m.Credits},'{m.Prerequisits}',{m.FinalExam},{m.TimeofExam},{m.DepartmentID},{m.LeveLID},{1})";
            var affected = DBManager.ExecuteNonQuery(stm);
            return affected;
        }


        public static Course GetByCode(string code)
        {
         
            string stm = $"select * from course  where  CODE like'%{code}'";
            var ds = DBManager.ExecuteQuery(stm);
            var item = ds.Tables[0].Rows[0];
            var Obj = new Course
            {
                ID = int.Parse(item["ID"].ToString()),
                Code = item["CODE"].ToString(),
                ArabicName = item["ArabicName"].ToString(),
                _Course = item["Course"].ToString(),
                Credits = int.Parse(item["Credits"].ToString()),
                Prerequisits = item["Prerequisits"].ToString(),
                FinalExam = (item["FinalExam"].ToString()),
                TimeofExam = int.Parse(item["TimeofExam"].ToString()),
                DepartmentID = int.Parse(item["DepartmentID"].ToString()),
                LeveLID = int.Parse(item["LeveLID"].ToString()),
                StatusID = int.Parse(item["StatusID"].ToString())

            };

            return Obj;
        }
    }
}