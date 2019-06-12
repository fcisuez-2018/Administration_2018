using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AdminstratorModule.Models;

namespace Admin.Models
{
    public class DepartmentBL
    {
        public static List<Department> GetAll()
        {
            string statement = "select department.ID,department.Departmenttxt,department.DeptartmentCode,department.FacultyID,department.OrderCode,faculty.FacultyName_English from department,faculty where department.FacultyID=faculty.ID";
            var ds = DBManager.ExecuteQuery(statement);
            List<Department> dep = new List<Department>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                dep.Add(
                    new Department
                    {
                        DepartmentID = int.Parse(item["ID"].ToString()),
                        Departmenttxt = (item["Departmenttxt"].ToString()),
                        DeptartmentCode = (item["DeptartmentCode"].ToString()),
                        FacultyID = int.Parse(item["FacultyID"].ToString()),
                        OrderCode = int.Parse(item["OrderCode"].ToString()),
                        FacultyName_English=(item["FacultyName_English"].ToString())

                    });
            }
            return dep;
        }

        public static Department GetById(int id)
        {
            string statement = $"select * from department where ID={id}";
            var ds = DBManager.ExecuteQuery(statement);
            var item = ds.Tables[0].Rows[0];
            var Obj = new Department
            {
                DepartmentID = int.Parse(item["ID"].ToString()),
                Departmenttxt = (item["Departmenttxt"].ToString()),
                DeptartmentCode = (item["DeptartmentCode"].ToString()),
                FacultyID = int.Parse(item["FacultyID"].ToString()),
                OrderCode = int.Parse(item["OrderCode"].ToString()),
            };
            return Obj;

        }

        //Update in table Department
        public static int Update(Department d)
        {
            string statement = $"update department set ID={d.DepartmentID},Departmenttxt='{d.Departmenttxt}',DeptartmentCode ='{d.DeptartmentCode}',FacultyID={d.FacultyID},OrderCode={d.OrderCode} where ID={d.DepartmentID}";
            int affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }

        public static int Add_Department(Department s)
        {
            string statement = $"insert into department(Departmenttxt,DeptartmentCode,FacultyID,OrderCode) values ('{s.Departmenttxt}','{s.DeptartmentCode}',{s.FacultyID},{s.OrderCode})";
            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }
    }
}


