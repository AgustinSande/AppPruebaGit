using AppPrueba.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppPrueba.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; } // DbSet for the base class

        public DbSet<Student> Students { get; set; } // DbSet for Student
        public DbSet<Teacher> Teachers { get; set; } // DbSet for Teacher
        public DbSet<Staff> Staffs { get; set; } // DbSet for Staff
        public DbSet<Course> Courses { get; set; } // DbSet for Course
        public DbSet<StudentCourse> StudentCourses { get; set; } // DbSet for StudentCourse

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure table-per-type (TPT) inheritance
            modelBuilder.Entity<Person>().ToTable("People");
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Teacher>().ToTable("Teachers");
            modelBuilder.Entity<Staff>().ToTable("Staffs");

            // Configure primary keys
            modelBuilder.Entity<Person>().HasKey(p => p.Id);
            modelBuilder.Entity<Student>().HasBaseType<Person>();
            modelBuilder.Entity<Employee>().HasBaseType<Person>();
            modelBuilder.Entity<Teacher>().HasBaseType<Employee>();
            modelBuilder.Entity<Staff>().HasBaseType<Employee>();

            // Configure Course-Teacher one-to-many relationship
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId);

            // Configure Course-Student many-to-many relationship
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);

            // Additional configurations...
            modelBuilder.Entity<Course>()
        .HasOne(c => c.Teacher)
        .WithMany(t => t.Courses)
        .HasForeignKey(c => c.TeacherId)
        .OnDelete(DeleteBehavior.Restrict); // Specify ON DELETE NO ACTION

            base.OnModelCreating(modelBuilder);
        }

    }
}
