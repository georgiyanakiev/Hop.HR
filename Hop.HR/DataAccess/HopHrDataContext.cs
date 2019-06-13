using Hop.HR.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hop.HR
{
    public class HopHrDataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public HopHrDataContext() : base("HopHrDataContext") { }
    }
}