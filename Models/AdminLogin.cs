
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdminstratorModule.Models
{
    public class AdminLogin
    {
        [Key]
        public int ID{ get; set; }

        [Required(ErrorMessage = "Please Enter UserName")]
        [DataType(DataType.Text, ErrorMessage = "Please Enter UserName")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password, ErrorMessage = "Please Enter valid Password")]
        [Display(Name = "Password")]
        public string Password{ get; set; }




    }
}