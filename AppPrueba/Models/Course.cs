
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AppPrueba.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public int Level { get; set; }
        public string Subject { get; set; }
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual List<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        //public List<Student> Students{ get; set; }
        //public List<Employee> Employees { get; set; }
    }
}
