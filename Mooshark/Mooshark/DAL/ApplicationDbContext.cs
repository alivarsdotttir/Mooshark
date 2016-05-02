using Mooshark.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Mooshark.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("MooSharkConnection") {
            Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>()); 
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SubProject> SubProjects { get; set; }
        public DbSet <Submission> Submissions { get; set; }
        public DbSet<InputOutput> InputOutput { get; set; }

    }
}