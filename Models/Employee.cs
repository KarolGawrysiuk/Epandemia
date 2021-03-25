using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epandemia.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HospitalId { get; set; }
        public int Age { get; set; }

        public virtual Hospital Hospital { get; set; }
    }
}