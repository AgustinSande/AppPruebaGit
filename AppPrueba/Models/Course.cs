
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AppPrueba.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<Student> Students{ get; set; }
        //public List<Employee> Employees { get; set; }
    }
}
