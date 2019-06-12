using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using AdminstratorModule.Models;

namespace Admin.Models
{
    public class Department
    {

        [Display(Name = "Department ID")]
        [Required(ErrorMessage = "Enter Department ID")]
        public int DepartmentID { get; set; }

        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "Enter Departmenttxt")]
        public string Departmenttxt { get; set; }

        [Display(Name = "Deptartment Code")]
        [Required(ErrorMessage = "Enter DeptartmentCode")]
        public string  DeptartmentCode { get; set; }

        [Display(Name = "FacultyID")]
        [Required(ErrorMessage = "Enter FacultyID")]
        public int FacultyID { get; set; }

        [Display(Name = "Faculty")]
        [Required(ErrorMessage = "Enter FacultyName_English")]
        public string  FacultyName_English { get; set; }

        [Display(Name = "Order Code")]
        [Required(ErrorMessage = "Enter Order Code")]
        public int OrderCode { get; set; }


    }
}