using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using AdminstratorModule.Models;

namespace AdminstratorModule.Models
{
    public class Students_MIS_BL
    {

        public static List<Students_MIS> GetAll()
        {
            string stm = " SELECT * from [dbo].[ED_STUD] where AS_FACULTY_INFO_ID=992;";
            var ds = DBManager_umis.ExecuteQuery(stm);


            List<Students_MIS> mem = new List<Students_MIS>();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                mem.Add(
                    new Students_MIS
                    {
                        ED_STUD_ID =(item["ED_STUD_ID"].ToString()),
                        STUD_CODE = (item["STUD_CODE"].ToString()),
                        NATIONAL_NUMBER = item["NATIONAL_NUMBER"].ToString(),
                        FULL_NAME_AR = item["FULL_NAME_AR"].ToString(),
                        FULL_NAME_EN= item["FULL_NAME_EN"].ToString(),
                        BIRTH_DATE = item["BIRTH_DATE"].ToString(),
                        FATHER_PROFESSION = item["FATHER_PROFESSION"].ToString(),


                    });


            }

            return mem;
        }
    }
}