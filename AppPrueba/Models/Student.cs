using AppPrueba.Entities;

namespace AppPrueba.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public int SchoolFile { get; set; } 
        public List<Course>  Courses{ get; set; }
        public int InstitutionId { get; set; }  
        public virtual Institution Institution { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
