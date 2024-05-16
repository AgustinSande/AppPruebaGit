using System.ComponentModel.DataAnnotations;

namespace AppPrueba.Models
{
    public class Student : Person
    {
        
        public int SchoolFile { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public DateTime? EnrollmentEndDate { get; set; }

        public int GradeLevel { get; set; }

        
        public List<StudentCourse> StudentCourses { get; set; }
        

    }


    
}
