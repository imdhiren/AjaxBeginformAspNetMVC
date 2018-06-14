using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AjaxBeginformAspNetMVC2.Models
{
    public class Countries
    {
        [Key]
        public int CountriesID { get; set; }
        public string CountriesName { get; set; }
    }
}