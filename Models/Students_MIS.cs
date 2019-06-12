using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AdminstratorModule.Models
{
    public class Students_MIS
    {


        [Display(Name = "م")]
        [Required(ErrorMessage = "Enter The ED_STUD_ID")]
        public string ED_STUD_ID { get; set; }


        [Display(Name = "كود الطاالب")]
        [Required(ErrorMessage = "Enter The STUD_CODE")]
        public string STUD_CODE { get; set; }


        [Display(Name = "الرقم القومي")]
        [Required(ErrorMessage = "Enter The NATIONAL_NUMBER")]
        public string NATIONAL_NUMBER { get; set; }


        [Display(Name = "اسم الطالب باللغه العربيه")]
        [Required(ErrorMessage = "Enter The FULL_NAME_AR")]
        public string FULL_NAME_AR { get; set; }


        [Display(Name = "اسم الطالب باللغه الانجليزيه")]
        [Required(ErrorMessage = "Enter  FULL_NAME_EN")]
        public string FULL_NAME_EN { get; set; }
        [Display(Name = " تاريخ الميلاد")]
        [Required(ErrorMessage = "Enter  BIRTH_DATE")]
        public string BIRTH_DATE { get; set; }
        [Display(Name = "وظيفه الأب")]
        [Required(ErrorMessage = "Enter  FATHER_PROFESSION")]
        public string FATHER_PROFESSION { get; set; }

    }
}