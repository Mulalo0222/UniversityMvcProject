using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityMvcProject.Models;
//using static UniversityMvcProject.Models.Registration;

namespace UniversityMvcProject.DAL
{
    public class UniversityInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstName="Carson",LastName="Alexander",RegistrationDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Meredith",LastName="Alonso",RegistrationDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Arturo",LastName="Anand",RegistrationDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Gytis",LastName="Barzdukas",RegistrationDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Yan",LastName="Li",RegistrationDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Peggy",LastName="Justice",RegistrationDate=DateTime.Parse("2001-09-01")},
            new Student{FirstName="Laura",LastName="Norman",RegistrationDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Nino",LastName="Olivetto",RegistrationDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
            new Course{CourseID=1045,Title="Calculus",Credits=4,},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
            new Course{CourseID=2021,Title="Composition",Credits=3,},
            new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Registration>
            {
            new Registration{StudentID=1,CourseID=1050,Grades=Registration.Grade.A},
            new Registration{StudentID=1,CourseID=4022,Grades=Registration.Grade.C},
            new Registration{StudentID=1,CourseID=4041,Grades=Registration.Grade.B},
            new Registration{StudentID=2,CourseID=1045,Grades=Registration.Grade.B},
            new Registration{StudentID=2,CourseID=3141,Grades=Registration.Grade.F},
            new Registration{StudentID=2,CourseID=2021,Grades=Registration.Grade.F},
            new Registration{StudentID=3,CourseID=1050},
            new Registration{StudentID=4,CourseID=1050,},
            new Registration{StudentID=4,CourseID=4022,Grades=Registration.Grade.F},
            new Registration{StudentID=5,CourseID=4041,Grades=Registration.Grade.C},
            new Registration{StudentID=6,CourseID=1045},
            new Registration{StudentID=7,CourseID=3141,Grades=Registration.Grade.A},
            };
            enrollments.ForEach(s => context.Registrations.Add(s));
            context.SaveChanges();
        }
    }
}
    
