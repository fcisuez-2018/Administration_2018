using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class level
    {
        [Display(Name = "ID ")]
        [Required(ErrorMessage = "Enter ID ")]
        public int ID { get; set; }

        [Display(Name = "LevelTxt ")]
        [Required(ErrorMessage = "Enter LevelTxt ")]
        public string LevelTxt { get; set; }

        [Display(Name = "LevelNumber ")]
        [Required(ErrorMessage = "Enter LevelNumber ")]
        public int  LevelNumber { get; set; }

        [Display(Name = "LevelCreditHours ")]
        [Required(ErrorMessage = "Enter LevelCreditHours ")]
        public int LevelCreditHours { get; set; }

        [Display(Name = "LevelTxt_Arabic ")]
        [Required(ErrorMessage = "Enter LevelTxt_Arabic ")]
        public string LevelTxt_Arabic { get; set; }

     




    }
}