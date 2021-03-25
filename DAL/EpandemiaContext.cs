using Epandemia.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Epandemia.DAL
{
    public class EpandemiaContext :DbContext
    {
        public EpandemiaContext(): base("DefaultConnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}