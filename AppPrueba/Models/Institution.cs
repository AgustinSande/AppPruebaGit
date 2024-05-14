using System.ComponentModel.DataAnnotations;

namespace AppPrueba.Models
{
    public class Institution
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //public List<Employee> Employees { get; set; }
        
    }
}