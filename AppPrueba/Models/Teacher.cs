namespace AppPrueba.Models
{
    public class Teacher : Employee
    {
        public int TeacherId { get; set; }
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }
        

    }
}
