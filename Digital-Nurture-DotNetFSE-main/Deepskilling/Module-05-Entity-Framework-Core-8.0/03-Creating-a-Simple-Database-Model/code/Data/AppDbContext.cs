using Microsoft.EntityFrameworkCore;
using StudentManagementDemo.Models;
namespace StudentManagementDemo.Data;
public class AppDbContext:DbContext{
public AppDbContext() {}
public AppDbContext(DbContextOptions<AppDbContext> o):base(o){}
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=StudentManagementDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
public DbSet<Student> Students=>Set<Student>();
public DbSet<Course> Courses=>Set<Course>();
public DbSet<Enrollment> Enrollments=>Set<Enrollment>();
}