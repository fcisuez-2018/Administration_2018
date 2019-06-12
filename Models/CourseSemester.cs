using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Admin.Models;

namespace Admin.Models
{
    public class CourseSemester
    {
        [Display(Name = " ID")]
        [Required(ErrorMessage = "Enter The Course ID")]
        public int ID { get; set; }

        [Display(Name = " ID")]
        [Required(ErrorMessage = "Enter The  ID")]
        public int ID_sem { get; set; }

        [Display(Name = "Code")]
        [Required(ErrorMessage = "Enter The Course Code")]
        public string Code { get; set; }


        [Display(Name = "ArabicName")]
        [Required(ErrorMessage = "Enter The Course Arabic Name")]
        public string ArabicName { get; set; }


        [Display(Name = "CourseName")]
        [Required(ErrorMessage = "Enter The Course Name")]
        public string _Course { get; set; }


        [Display(Name = " SemesterFullName")]
        [Required(ErrorMessage = "Enter SemesterFullName  ")]
        public string SemesterFullName { get; set; }

        [Display(Name = " Semester")]
        [Required(ErrorMessage = "Enter Semester ....  ")]
        public string Semester { get; set; }

        [Display(Name = "DoctorID")]
        [Required(ErrorMessage = "Enter The DoctorID")]
        public int DoctorID { get; set; }

        [Display(Name = "Name_Txt")]
        [Required(ErrorMessage = "Enter The Name_Txt")]
        public string Name_Txt { get; set; }
        [Display(Name = "Arabic_doctorName")]
        [Required(ErrorMessage = "Enter Arabic_doctorName")]
        public string Arabic_doctorName { get; set; }

    }
}