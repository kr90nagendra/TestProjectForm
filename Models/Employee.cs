using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace TestProjectForm.Models
{
    public class Employee
    {
        [Required]
        [Display(Name ="Employee First Name")]
        public string  Empfname { get; set; }
        [Required]
        [Display(Name = "Employee Last Name")]
        public string Emplname { get; set; }
    }
}