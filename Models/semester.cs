using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class semester
    {
        [Display(Name = "ID ")]
        [Required(ErrorMessage = "Enter ID ")]
        public int ID { get; set; }

        [Display(Name = " Semester")]
        [Required(ErrorMessage = "Enter Semester ")]
        public string Semester { get; set; }

        [Display(Name = " SemesterFullName")]
        [Required(ErrorMessage = "Enter SemesterFullName  ")]
        public string SemesterFullName { get; set; }

        [Display(Name = " SemesterArabicName")]
        [Required(ErrorMessage = "Enter SemesterArabicName  ")]
        public string SemesterArabicName { get; set; }

        [Display(Name = " SemesterEnumID")]
        [Required(ErrorMessage = "Enter SemesterEnumID  ")]
        public int SemesterEnumID { get; set; }


        [Display(Name = "StatusID ")]
        [Required(ErrorMessage = "Enter StatusID   ")]
        public int StatusID { get; set; }



        



    }
}