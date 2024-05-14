using AppPrueba.Entities;
using AppPrueba.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppPrueba.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
