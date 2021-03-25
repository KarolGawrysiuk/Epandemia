using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Epandemia.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Epandemia.DAL
{
    public class EpandemiaInitializer : DropCreateDatabaseIfModelChanges<EpandemiaContext>
    {
        protected override void Seed(EpandemiaContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(new ApplicationDbContext()));

            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(new ApplicationDbContext()));

            roleManager.Create(new IdentityRole("Admin"));

            var user = new ApplicationUser { UserName = "karol.gawrysiuk@gmail.com" };
            string password = "Admin123456@";

            userManager.Create(user, password);
            userManager.AddToRole(user.Id, "Admin");


            var hospitals = new List<Hospital>
            {
                new Hospital { Name = "Szpital Wojewódzki w Siedlcach", City = City.Siedlce, Street = "Poniatowskiego", MaxBeds = 200 },
                new Hospital { Name = "Szpital w Warszawie", City = City.Warszawa, Street = "Kleberga", MaxBeds = 1000 }
            };

            hospitals.ForEach(h => context.Hospitals.Add(h));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee {FirstName = "Karol", LastName = "Gawrysiuk", Age = 28, Hospital = hospitals[0] },
                new Employee {FirstName = "Jakub", LastName = "Sidoruk", Age = 27, Hospital = hospitals[0] }
            };

            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();

            var users = new List<User>
            {
                new User { FirstName = "Michał", LastName = "Woźniak", Age = 88, Hospital = hospitals[1], Gender = Gender.Male, DateAdded = DateTime.Parse("2020-10-30")  },
                new User { FirstName = "Jacek", LastName = "Placek", Age = 92, Hospital = hospitals[1], Gender = Gender.Male, DateAdded = DateTime.Parse("2020-10-30")  }
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}