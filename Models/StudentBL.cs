using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AdminstratorModule.Models;

namespace Admin.Models
{
    public class StudentBL
    {
        public static List<Student> GetAll()
        {
            string statement = "select * from student";
            var ds = DBManager.ExecuteQuery(statement);
            List<Student> std = new List<Student>();
 

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                std.Add(
                    new Student
                    {
                       ID=int.Parse(item["ID"].ToString()),
                       StudentName=(item["StudentName"].ToString()),
                       StudentEductionalNumber=(item["StudentEductionalNumber"].ToString()),
                        //NationalityID = int.Parse(item["NationalityID"].ToString()),
                        Phone = (item["Phone"].ToString()),
                        // GenderID=int.Parse(item["GenderID"].ToString()),
                        Email = (item["Email"].ToString()),
                        // ActivityID=(item["ActivityID"].ToString()),
                        // MilitaryStatusID=int.Parse(item["MilitaryStatusID"].ToString()),
                        // AdvisorID=int.Parse(item["AdvisorID"].ToString()),
                        SocialNumber = (item["SocialNumber"].ToString()),
                        // MajorDepartmentID=int.Parse(item["MajorDepartmentID"].ToString()),
                        // MinorDepartmentID=(item["MinorDepartmentID"].ToString()),
                        StatusID = int.Parse(item["StatusID"].ToString())
                        // MilitaryEducationID=int.Parse(item["MilitaryEducationID"].ToString()),
                        // CurriculumID=int.Parse(item["CurriculumID"].ToString()),


                    });
            }
            return std;
        }





        public static List<Student> GetAll_Cs()
        {
            string statement = "select * from student , department where student.MajorDepartmentID= department.ID And department.ID=1";
            var ds = DBManager.ExecuteQuery(statement);
            List<Student> std = new List<Student>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                std.Add(
                    new Student
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        StudentName = (item["StudentName"].ToString()),
                        StudentEductionalNumber =(item["StudentEductionalNumber"].ToString()),
                        Phone = (item["Phone"].ToString()),
                        Email = (item["Email"].ToString()),
                        SocialNumber = (item["SocialNumber"].ToString()),
                        StatusID = int.Parse(item["StatusID"].ToString()),
            
                    });
            }
            return std;
        }



        public static List<Student> GetAll_IT()
        {
            string statement = "select * from student , department where student.MajorDepartmentID= department.ID And department.ID=3";
            var ds = DBManager.ExecuteQuery(statement);
            List<Student> std = new List<Student>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                std.Add(
                    new Student
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        StudentName = (item["StudentName"].ToString()),
                        StudentEductionalNumber = (item["StudentEductionalNumber"].ToString()),
                        Phone = (item["Phone"].ToString()),
                        Email = (item["Email"].ToString()),
                        SocialNumber = (item["SocialNumber"].ToString()),
                        StatusID = int.Parse(item["StatusID"].ToString()),

                    });
            }
            return std;
        }

        public static List<Student> GetAll_General()
        {
            string statement = "select * from student , department where student.MajorDepartmentID= department.ID And department.ID=5";
            var ds = DBManager.ExecuteQuery(statement);
            List<Student> std = new List<Student>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                std.Add(
                    new Student
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        StudentName = (item["StudentName"].ToString()),
                        StudentEductionalNumber = (item["StudentEductionalNumber"].ToString()),
                        Phone = (item["Phone"].ToString()),
                        Email = (item["Email"].ToString()),
                        SocialNumber = (item["SocialNumber"].ToString()),
                        StatusID = int.Parse(item["StatusID"].ToString()),
                    });
            }
            return std;
        }

        public static int EditActive(int ID,int stID)
        {

            string stataement = "";
            if (stID == 1)
            {
                stataement = $"UPDATE student  SET StatusID=2 where ID={ID} ";
            }
            else
            {
                stataement = $"UPDATE student  SET StatusID=1 where ID={ID} ";
            }
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;
        }



        public static List<Student> GetAll_Software()
        {
            string statement = "select * from student , department where student.MajorDepartmentID= department.ID And department.ID=4";
            var ds = DBManager.ExecuteQuery(statement);
            List<Student> std = new List<Student>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                std.Add(
                    new Student
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        StudentName = (item["StudentName"].ToString()),
                        StudentEductionalNumber = (item["StudentEductionalNumber"].ToString()),
                        Phone = (item["Phone"].ToString()),
                        Email = (item["Email"].ToString()),
                        SocialNumber = (item["SocialNumber"].ToString()),
                        StatusID = int.Parse(item["StatusID"].ToString()),

                    });
            }
            return std;
        }



        public static List<Student> GetAll_IS()
        {
            string statement = "select * from student , department where student.MajorDepartmentID= department.ID And department.ID=2";
            var ds = DBManager.ExecuteQuery(statement);
            List<Student> std = new List<Student>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                std.Add(
                    new Student
                    {
                          ID = int.Parse(item["ID"].ToString()),
                        StudentName = (item["StudentName"].ToString()),
                        StudentEductionalNumber = (item["StudentEductionalNumber"].ToString()),
                        Phone = (item["Phone"].ToString()),
                        Email = (item["Email"].ToString()),
                        SocialNumber = (item["SocialNumber"].ToString()),
                        StatusID = int.Parse(item["StatusID"].ToString()),
                     


                    });
            }
            return std;
        }

        public static int Update(Student s)
        {
            string stataement = $"update student set StudentName=N'{s.StudentName}',StudentEductionalNumber='{s.StudentEductionalNumber}',Phone={s.Phone},Email='{s.Email}',SocialNumber={s.SocialNumber},StatusID={s.StatusID} where ID={s.ID}";
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;

        }
        public static Student GetById(int id)
        {
            string statement = $"select * from student where ID={id}";
            var ds = DBManager.ExecuteQuery(statement);
            var item = ds.Tables[0].Rows[0];
            var Obj = new Student
            {
                ID = int.Parse(item["ID"].ToString()),
                StudentName = (item["StudentName"].ToString()),
                StudentEductionalNumber = (item["StudentEductionalNumber"].ToString()),
                //NationalityID = int.Parse(item["NationalityID"].ToString()),
                Phone = (item["Phone"].ToString()),
                // GenderID=int.Parse(item["GenderID"].ToString()),
                Email = (item["Email"].ToString()),
                // ActivityID=(item["ActivityID"].ToString()),
                // MilitaryStatusID=int.Parse(item["MilitaryStatusID"].ToString()),
                // AdvisorID=int.Parse(item["AdvisorID"].ToString()),
                SocialNumber = (item["SocialNumber"].ToString()),
                // MajorDepartmentID=int.Parse(item["MajorDepartmentID"].ToString()),
                // MinorDepartmentID=(item["MinorDepartmentID"].ToString()),
                StatusID = int.Parse(item["StatusID"].ToString())
                // MilitaryEducationID=int.Parse(item["MilitaryEducationID"].ToString()),
                // CurriculumID=int.Parse(item["CurriculumID"].ToString()),

            };

            return Obj;
        }





        public static List<Student> GetByEmail(string Email)
        {


            string stm = $"select * from student  where Email ='%{Email}' ";
            var ds = DBManager.ExecuteQuery(stm);

            List<Student> stu = new List<Student>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                stu.Add(
                     new Student
                     {


                         ID = int.Parse(item["ID"].ToString()),
                         StudentName = (item["StudentName"].ToString()),
                         StudentEductionalNumber = (item["StudentEductionalNumber"].ToString()),
                         //NationalityID = int.Parse(item["NationalityID"].ToString()),
                         Phone = (item["Phone"].ToString()),
                         // GenderID=int.Parse(item["GenderID"].ToString()),
                         Email = (item["Email"].ToString()),
                         // ActivityID=(item["ActivityID"].ToString()),
                         // MilitaryStatusID=int.Parse(item["MilitaryStatusID"].ToString()),
                         // AdvisorID=int.Parse(item["AdvisorID"].ToString()),
                         SocialNumber = (item["SocialNumber"].ToString()),
                         // MajorDepartmentID=int.Parse(item["MajorDepartmentID"].ToString()),
                         // MinorDepartmentID=(item["MinorDepartmentID"].ToString()),
                         StatusID = int.Parse(item["StatusID"].ToString())
                         // MilitaryEducationID=int.Parse(item["MilitaryEducationID"].ToString()),
                         // CurriculumID=int.Parse(item["CurriculumID"].ToString()),

                     });
            }

            return stu;
        }




        public static List<Student> GetByName(string Name)
        {


            string stm = $"select * from student  where StudentName like'%{Name}'";
            var ds = DBManager.ExecuteQuery(stm);

            List<Student> stu = new List<Student>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                stu.Add(
                     new Student
                     {


                         ID = int.Parse(item["ID"].ToString()),
                         StudentName = (item["StudentName"].ToString()),
                         StudentEductionalNumber = (item["StudentEductionalNumber"].ToString()),
                         //NationalityID = int.Parse(item["NationalityID"].ToString()),
                         Phone = (item["Phone"].ToString()),
                         // GenderID=int.Parse(item["GenderID"].ToString()),
                         Email = (item["Email"].ToString()),
                         // ActivityID=(item["ActivityID"].ToString()),
                         // MilitaryStatusID=int.Parse(item["MilitaryStatusID"].ToString()),
                         // AdvisorID=int.Parse(item["AdvisorID"].ToString()),
                         SocialNumber = (item["SocialNumber"].ToString()),
                         // MajorDepartmentID=int.Parse(item["MajorDepartmentID"].ToString()),
                         // MinorDepartmentID=(item["MinorDepartmentID"].ToString()),
                         StatusID = int.Parse(item["StatusID"].ToString())
                         // MilitaryEducationID=int.Parse(item["MilitaryEducationID"].ToString()),
                         // CurriculumID=int.Parse(item["CurriculumID"].ToString()),


                     });
            }

            return stu;
        }
        public static List<Student> GetByStudentEductionalNumber(string StudentEductionalNumber)
        {


            string stm = $"select * from student  where  StudentEductionalNumber like'%{ StudentEductionalNumber}'";
            var ds = DBManager.ExecuteQuery(stm);

            List<Student> stu = new List<Student>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                stu.Add(
                     new Student
                     {


                         ID = int.Parse(item["ID"].ToString()),
                         StudentName = (item["StudentName"].ToString()),
                         StudentEductionalNumber = (item["StudentEductionalNumber"].ToString()),
                         //NationalityID = int.Parse(item["NationalityID"].ToString()),
                         Phone = (item["Phone"].ToString()),
                         // GenderID=int.Parse(item["GenderID"].ToString()),
                         Email = (item["Email"].ToString()),
                         // ActivityID=(item["ActivityID"].ToString()),
                         // MilitaryStatusID=int.Parse(item["MilitaryStatusID"].ToString()),
                         // AdvisorID=int.Parse(item["AdvisorID"].ToString()),
                         SocialNumber = (item["SocialNumber"].ToString()),
                         // MajorDepartmentID=int.Parse(item["MajorDepartmentID"].ToString()),
                         // MinorDepartmentID=(item["MinorDepartmentID"].ToString()),
                         StatusID = int.Parse(item["StatusID"].ToString())
                         // MilitaryEducationID=int.Parse(item["MilitaryEducationID"].ToString()),
                         // CurriculumID=int.Parse(item["CurriculumID"].ToString()),


                     });
            }

            return stu;
        }

        public static int Add(Student m)
        {
            string stm = $"INSERT INTO student(StudentName,StudentEductionalNumber, Phone,Email,  SocialNumber, StatusID) values ('{m.StudentName}','{m.StudentEductionalNumber}','{m.Phone}','{m.Email}','{m.SocialNumber}',{m.StatusID})";
            var affected = DBManager.ExecuteNonQuery(stm);
            return affected;
        }





    }
}


 