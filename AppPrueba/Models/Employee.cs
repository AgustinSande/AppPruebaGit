using AppPrueba.Entities;

namespace AppPrueba.Models
{
    public class Employee : Person
    {
        public int Salary { get; set; }
        public int InstitutionId { get; set; }
        public Institution Institution { get; set; }
    }
}
