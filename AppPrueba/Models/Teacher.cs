using System.ComponentModel.DataAnnotations;

namespace AppPrueba.Models
{
    public class Teacher : Population
    {
        
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }
        

    }
}
