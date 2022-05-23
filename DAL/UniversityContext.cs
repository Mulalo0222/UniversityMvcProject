using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using UniversityMvcProject.Models;

namespace UniversityMvcProject.DAL
{
    public class UniversityContext :DbContext
    {
        public UniversityContext() : base("UniversityContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<UniversityMvcProject.Models.OfficeAssignment> OfficeAssignments { get; set; }
    }
}