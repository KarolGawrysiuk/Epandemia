using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epandemia.Models
{
    public enum City
    {
        Warszawa,
        Siedlce,
        Kraków,
        Łuków,
        Gdańsk,
        Wrocław,
        Poznań, 
        Lublin,
        Łomża,
        Warka,
        Szczecin,
        Mińsk
    }
   

    public class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public string Street { get; set; }
        public int MaxBeds { get; set; }
        public int Beds { get; set; }
        public int NumberEmployees{ get; set; }
        public virtual List<Employee> Employees { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
