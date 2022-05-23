using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityMvcProject.Models
{
    public class Registration
    {
        public enum Grade
        {
            A, B, C, D, F
        }
        public int RegistrationID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grades { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}