using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxBeginformAspNetMVC2.Models
{
    public class DbconnectionContext : DbContext
    {
        public DbconnectionContext(): base("DefaultConnection")
        {

        }

        public DbSet<Countries> Countries { get; set; }
    }
}