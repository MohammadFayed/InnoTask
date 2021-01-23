using System;
using InnoTechApp.Core;
using Microsoft.EntityFrameworkCore;

namespace InnoTechApp.Data
{
    public class InnoTechAppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public InnoTechAppDbContext(DbContextOptions<InnoTechAppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Course>().HasData(
                new Course() { CourseId = 1, Name = "Asp.Net Core", Price = 112, Description = "Lorem pla pla pla pla pla"},
                new Course() { CourseId = 2, Name = "Blazor", Price = 500, Description = "Lorem pla pla pla pla pla"},
                new Course() { CourseId = 3, Name = "Entity Framework Core Getting Started", Price = 300, Description = "Lorem pla pla pla pla pla"}
                );
            
            builder.Entity<Student>().HasData(
                new Student() { StudentId = 1, Name = "Mohammad Fayed", Age = 21},
                new Student() { StudentId = 2, Name = "Ahmed Fayed", Age = 9},
                new Student() { StudentId = 3, Name = "Amr Alaa", Age = 21},
                new Student() { StudentId = 4, Name = "Omar Morgan", Age = 21}
            );
            builder.Entity<Enrollment>().HasData(
                new Enrollment() { EnrollmentId = 1, CourseId = 1, StudentId = 1, Date = DateTime.Now},
                new Enrollment() { EnrollmentId = 2, CourseId = 2, StudentId = 1, Date = DateTime.Now.AddDays(60)},
                new Enrollment() { EnrollmentId = 3, CourseId = 3, StudentId = 1, Date = DateTime.Now.AddDays(30)},
                new Enrollment() { EnrollmentId = 4, CourseId = 1, StudentId = 2, Date = DateTime.Now.AddHours(20)},
                new Enrollment() { EnrollmentId = 5, CourseId = 1, StudentId = 3, Date = DateTime.Now.AddMinutes(20)},
                new Enrollment() { EnrollmentId = 6, CourseId = 3, StudentId = 2, Date = DateTime.Now.AddHours(20)},
                new Enrollment() { EnrollmentId = 7, CourseId = 2, StudentId = 3, Date = DateTime.Now.AddMonths(1)},
                new Enrollment() { EnrollmentId = 8, CourseId = 2, StudentId = 4, Date = DateTime.Now.AddHours(6)}
            );
        }
    }
}