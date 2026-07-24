using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StudentManagementDemo.Data;
using StudentManagementDemo.Models;

var cfg=new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var opt=new DbContextOptionsBuilder<AppDbContext>().UseSqlServer(cfg.GetConnectionString("DefaultConnection")).Options;
using var db=new AppDbContext(opt);
Console.WriteLine("Database model configured.");

// Ensure database is clean or seed data if empty
if (!db.Students.Any())
{
    Console.WriteLine("Seeding database with sample data...");
    
    var student = new Student { Name = "Alice Smith" };
    var course = new Course { Title = "Introduction to Entity Framework" };
    
    var enrollment = new Enrollment
    {
        Student = student,
        Course = course
    };
    
    db.Enrollments.Add(enrollment);
    db.SaveChanges();
    Console.WriteLine("Sample data seeded successfully.");
}

// Retrieve and print database output
Console.WriteLine("\n--- Querying Database Records ---");
var enrollments = db.Enrollments
    .Include(e => e.Student)
    .Include(e => e.Course)
    .ToList();

foreach (var e in enrollments)
{
    Console.WriteLine($"Enrollment ID: {e.Id} | Student: {e.Student?.Name} | Course: {e.Course?.Title}");
}