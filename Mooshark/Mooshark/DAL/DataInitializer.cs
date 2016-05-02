using Mooshark.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshark.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationDbContext> 
    {
        protected override void Seed(ApplicationDbContext context)
        {
            Admin admin = new Admin { username = "admin", email = "admin@admin.com", password = "admin123", authentication = "admin" };

            context.Admins.Add(admin); 
            context.SaveChanges(); 
        }
    }
}