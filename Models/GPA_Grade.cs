using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class GPA_Grade
    {
        [Display(Name = "ID ")]
        [Required(ErrorMessage = "Enter ID ")]
        public int ID { get; set; }

        [Display(Name = " Grade_English")]
        [Required(ErrorMessage = "Enter Grade_English  ")]
        public string Grade_English { get; set; }

        [Display(Name = " Grade_Arabic")]
        [Required(ErrorMessage = "Enter Grade_Arabic  ")]
        public string Grade_Arabic { get; set; }

        [Display(Name = " OrderCode")]
        [Required(ErrorMessage = "Enter OrderCode  ")]
        public int OrderCode { get; set; }

        [Display(Name = " Points")]
        [Required(ErrorMessage = "Enter Points  ")]
        public string Points { get; set; }


        [Display(Name = " SemesterID")]
        [Required(ErrorMessage = "Enter SemesterID  ")]
        public int semesterID { get; set; }


        [Display(Name = " Course_Points")]
     
        public string Course_Points { get; set; }

        [Display(Name = " Course_cr_points")]
      
        public string Course_cr_points { get; set; }
    }
}