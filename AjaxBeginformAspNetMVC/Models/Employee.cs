using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AjaxBeginformAspNetMVC.Models
{
    public class Employee
    {
        public int? Id { get; set; }
        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "FirstName is Required.")]
        public string FirstName { get; set; }
        [Display(Name = "LastName")]
        [Required(ErrorMessage = "LastName is Required.")]
        public string LastName { get; set; }
        [Display(Name = "Salary")]
        [Required(ErrorMessage = "Salary is Required.")]
        public int Salary { get; set; }
    }
}