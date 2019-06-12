using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using AdminstratorModule.Models;
namespace Admin.Models
{
    public class Course
    {
        [Display(Name = " ID")]
        [Required(ErrorMessage = "Enter The Course ID")]
        public int ID { get; set; }


        [Display(Name = "Code")]
        [Required(ErrorMessage = "Enter The Course Code")]
        public string Code { get; set; }


        [Display(Name = "ArabicName")]
        [Required(ErrorMessage = "Enter The Course Arabic Name")]
        public string ArabicName { get; set; }


        [Display(Name = "CourseName")]
        [Required(ErrorMessage = "Enter The Course Name")]
        public string _Course { get; set; }


        [Display(Name = "Credits")]
        [Required(ErrorMessage = "Enter The Course Credits")]
        public int Credits { get; set; }


        [Display(Name = "Prerequisits")]
        [Required(ErrorMessage = "Enter The Prerequisits")]
        public string Prerequisits { get; set; }


        //[Display(Name = "CourseTypeID")]
        //[Required(ErrorMessage = "Enter The Course TypeID")]
        //public int CourseTypeID { get; set; }


        //[Display(Name = "Teaching_Hours_Lecture")]
        //[Required(ErrorMessage = "Enter The Teaching_Hours_Lecture")]
        //public int Teaching_Hours_Lecture { get; set; }


        //[Display(Name = "Teching_Hours_Tutorial")]
        //[Required(ErrorMessage = "Enter The Teching_Hours_Tutorial")]
        //public string Teching_Hours_Tutorial { get; set; }


        //[Display(Name = "TeachingHours_Practical")]
        //[Required(ErrorMessage = "Enter The TeachingHours_Practical")]
        //public string TeachingHours_Practical { get; set; }


        //[Display(Name = "Midterm")]
        //[Required(ErrorMessage = "Enter The Midterm")]
        //public decimal Midterm { get; set; }


        //[Display(Name = "Year_Work_Grades_O")]
        //[Required(ErrorMessage = "Enter The Year_Work_Grades_O")]
        //public decimal Year_Work_Grades_O { get; set; }


        //[Display(Name = "Year_Work_Grades_PE")]
        //[Required(ErrorMessage = "Enter The Year_Work_Grades_PE")]
        //public decimal Year_Work_Grades_PE { get; set; }


        //[Display(Name = "Year_Work_Grades_G")]
        //[Required(ErrorMessage = "Enter The Year_Work_Grades_G")]
        //public decimal Year_Work_Grades_G { get; set; }


        [Display(Name = "FinalExam")]
        [Required(ErrorMessage = "Enter The FinalExam")]
        public string FinalExam { get; set; }


        [Display(Name = "TimeofExam")]
        [Required(ErrorMessage = "Enter The TimeofExam")]
        public int TimeofExam { get; set; }


        [Display(Name = "LeveLID")]
        [Required(ErrorMessage = "Enter The LeveLID")]
        public int LeveLID { get; set; }


        [Display(Name = "DepartmentID")]
        [Required(ErrorMessage = "Enter The DepartmentID")]
        public int DepartmentID { get; set; }




        //[Display(Name = "OrderCode")]
        //[Required(ErrorMessage = "Enter The OrderCode")]
        //public int OrderCode { get; set; }


        [Display(Name = "StatusID")]
        [Required(ErrorMessage = "Enter The StatusID")]
        public int StatusID { get; set; }


        //[Display(Name = "CurriculumID")]
        //[Required(ErrorMessage = "Enter The CurriculumID")]
        //public int CurriculumID { get; set; }


    }
}