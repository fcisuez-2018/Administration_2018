using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Admin.Models
{
    public class Student
    {


        [Display(Name = "ID")]

        [Required(ErrorMessage = "Enter The Student ID")]
        public int ID { get; set; }


        [Display(Name = "Student Name")]
        [Required(ErrorMessage = "Enter The StudentName")]

        public string StudentName { get; set; }


        [Display(Name = "Eduacational Number")]
        [Required(ErrorMessage = "Enter Educational Number ")]
        public string StudentEductionalNumber { get; set; }



        //[Display(Name = "NationalityID")]
        //[Required(ErrorMessage = "Enter The NationalityID")]
        //public int NationalityID { get; set; }


        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Enter Phone")]
        public string Phone { get; set; }


        //[Display(Name = "GenderID")]
        //[Required(ErrorMessage = "Enter The GenderID ")]
        //public int GenderID { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "Enter The Email ")]
        public string Email { get; set; }






        //[Display(Name = "ActivityID")]
        //[Required(ErrorMessage = "Enter The ActivityID")]
        //public string ActivityID { get; set; }


        //[Display(Name = "MilitaryStatusID")]
        //[Required(ErrorMessage = "Enter The MilitaryStatusID")]
        //public int MilitaryStatusID { get; set; }


        //[Display(Name = "AdvisorID")]
        //[Required(ErrorMessage = "Enter The AdvisorID")]
        //public int AdvisorID { get; set; }



        [Display(Name = "SocialNumber")]
        [Required(ErrorMessage = "Enter The SocialNumber ")]
        public string SocialNumber { get; set; }


        //[Display(Name = "MajorDepartmentID")]
        //[Required(ErrorMessage = "Enter MajorDepartmentID  ")]
        //public int MajorDepartmentID { get; set; }


        //[Display(Name = "MinorDepartmentID")]
        //[Required(ErrorMessage = "Enter MinorDepartmentID  ")]
        //public string MinorDepartmentID { get; set; }


        [Display(Name = "Status ")]
        [Required(ErrorMessage = "Enter StatusID  ")]
        public int StatusID { get; set; }


        //[Display(Name = "MilitaryEducationID")]
        //[Required(ErrorMessage = "Enter MilitaryEducationID ")]
        //public int MilitaryEducationID { get; set; }


        //[Display(Name = "CurriculumID")]
        //[Required(ErrorMessage = "  Enter The CurriculumID ")]
        //public int CurriculumID { get; set; }

    }
}