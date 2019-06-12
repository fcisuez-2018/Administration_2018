using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AdminstratorModule.Models;

namespace Admin.Models
{
    public class LevelBL
    {

        public static List<level> GetAll()
        {
            string statement = "select * from level";
            var ds = DBManager.ExecuteQuery(statement);
            List<level> GP = new List<level>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                GP.Add(
                    new level
                    {
                        ID = int.Parse(item["ID"].ToString()),
                        LevelTxt = item["LevelTxt"].ToString(),
                        LevelNumber = int.Parse(item["LevelNumber"].ToString()),
                        LevelCreditHours = int.Parse(item["LevelCreditHours"].ToString()),
                        LevelTxt_Arabic = (item["LevelTxt_Arabic"].ToString()),

                    });
            }
            return GP;
        }

        public static level GetById(int id)
        {
            string statement = $"select * from level where ID={id}";
            var ds = DBManager.ExecuteQuery(statement);
            var item = ds.Tables[0].Rows[0];
            var Obj = new level
            {
                ID = int.Parse(item["ID"].ToString()),
                LevelTxt = item["LevelTxt"].ToString(),
                LevelNumber = int.Parse(item["LevelNumber"].ToString()),
                LevelCreditHours = int.Parse(item["LevelCreditHours"].ToString()),
                LevelTxt_Arabic = (item["LevelTxt_Arabic"].ToString()),
            };

            return Obj;
        }

        public static int Update(level l)
        {
            string stataement = $"update level set ID={l.ID},LevelTxt='{l.LevelTxt}', LevelNumber={l.LevelNumber}, LevelCreditHours={l.LevelCreditHours},LevelTxt_Arabic='{l.LevelTxt_Arabic}' where ID={l.ID}";
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;

        }
        public static int Delete(level l)
        {
            string stataement = $"Delete * from level where ID ={l.ID}";
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;

        }

    }
}