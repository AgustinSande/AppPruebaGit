namespace AppPrueba.Models
{
    public class Population : Person
    {
        public int Salary { get; set; }
        public int InstitutionId { get; set; }
        public Institution Institution { get; set; }
    }
}
