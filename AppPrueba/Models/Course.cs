using AppPrueba.Entities;

namespace AppPrueba.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students{ get; set; }
        public List<Employee> Employees { get; set; }
    }
}
