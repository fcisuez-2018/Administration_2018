using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AdminstratorModule.Models
{
    public class Doctors
    {
        [Display(Name = "ID ")]
        [Required(ErrorMessage = "Enter ID ")]
        public int ID { get; set; }
        
        [Display(Name = "Name_Txt")]
        [Required(ErrorMessage = "Enter The Name_Txt")]
        public string Name_Txt { get; set; }

        [Display(Name = "Status ")]
        [Required(ErrorMessage = "Enter StatusID  ")]
        public int StatusID { get; set; }

        [Display(Name = "Order Code")]
        [Required(ErrorMessage = "Enter Order Code")]
        public int OrderCode { get; set; }

  
        [Display(Name = "Doctor Name ")]
        [Required(ErrorMessage = "Enter DoctorName")]
        public string Arabic_doctorName { get; set; }

    }
}