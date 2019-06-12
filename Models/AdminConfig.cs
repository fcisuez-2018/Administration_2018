using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using AdminstratorModule.Models;

namespace Admin.Models


{
    public class AdminConfig
    {

        [Display(Name = "ID ")]
        [Required(ErrorMessage = "Enter ID ")]
        public int ID { get; set; }

        [Display(Name = "ConfigName")]
        [Required(ErrorMessage = "Enter ConfigName  ")]
        public string ConfigName { get; set; }

        [Display(Name = "ConfigValue")]
        [Required(ErrorMessage = "	ConfigValue  ")]
        public string ConfigValue { get; set; }

        [Display(Name = "parentID")]
        [Required(ErrorMessage = "Enter parentID  ")]
        public int parentID { get; set; }











    }
}