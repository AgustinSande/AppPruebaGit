using System.ComponentModel.DataAnnotations;

namespace AppPrueba.Models
{
    public class Teacher : Employee
    {


        [Required(ErrorMessage = "Specialization is required")]
        public string Specialization { get; set; }
        [Required(ErrorMessage = "Years of experience is required")]
        public int YearsOfExperience { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();




    }
}
