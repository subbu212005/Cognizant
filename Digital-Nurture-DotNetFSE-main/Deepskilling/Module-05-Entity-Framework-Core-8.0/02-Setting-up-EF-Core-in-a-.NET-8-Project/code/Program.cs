using EFCoreSetupDemo.Data;
using EFCoreSetupDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseSqlServer(config.GetConnectionString("DefaultConnection"))
    .Options;

using var db = new AppDbContext(options);
Console.WriteLine("EF Core configured successfully.");

// Verify database operations
Console.WriteLine("Adding a new student to the database...");
var newStudent = new Student { Name = "Alice Smith", Age = 20 };
db.Students.Add(newStudent);
db.SaveChanges();
Console.WriteLine("Student added successfully!");

Console.WriteLine("\nQuerying all students from the database:");
var students = db.Students.ToList();
foreach (var student in students)
{
    Console.WriteLine($"- Student ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
}
