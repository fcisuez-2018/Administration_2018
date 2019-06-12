using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AdminstratorModule.Models;


namespace Admin.Models
{
    public class AdminConfigBL
    {
        public static List<AdminConfig> GetAll()
        {
            string statement = "select * from admin_config";
            var ds = DBManager.ExecuteQuery(statement);
            List<AdminConfig> GP = new List<AdminConfig >();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new AdminConfig
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        ConfigName = (item["ConfigName"].ToString()),
                        ConfigValue = (item["ConfigValue"].ToString()),
                        parentID = int.Parse(item["parentID"].ToString()),

                    });
            }
            return GP;
        }

        public static List<AdminConfig> GetById(int id)
        {
            string statement = $"select * from admin_config where ID={id}";
            var ds = DBManager.ExecuteQuery(statement);
            List<AdminConfig> GP = new List<AdminConfig>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new AdminConfig
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        ConfigName = (item["ConfigName"].ToString()),
                        ConfigValue = (item["ConfigValue"].ToString()),
                        parentID = int.Parse(item["parentID"].ToString()),

                    });
            }
            return GP;
        }


        public static int AddNewConfig(AdminConfig e)
        {
            string statement = $"insert into admin_config(ConfigName,ConfigValue,ParentID) values('{e.ConfigName}','{e.ConfigValue}',{e.parentID})";
            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }




        public static int Update(AdminConfig l)
        {
            string stataement = $"update admin_config set ConfigName='{l.ConfigName}',ConfigValue='{l.ConfigValue}',ParentID={l.parentID} where ID={l.ID}";
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;

        }





    }
}