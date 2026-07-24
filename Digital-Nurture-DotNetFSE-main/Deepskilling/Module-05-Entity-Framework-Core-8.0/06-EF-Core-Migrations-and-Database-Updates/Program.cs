using MigrationDemo.Data;
using MigrationDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseSqlite(config.GetConnectionString("DefaultConnection"))
    .Options;

using var db = new AppDbContext(options);

// Automatically apply any pending migrations
db.Database.Migrate();

Console.WriteLine("Migration Demo configured successfully.");
Console.WriteLine();

// Check if database needs seeding
if (!db.Employees.Any())
{
    Console.WriteLine("Seeding initial employee data...");
    db.Employees.AddRange(
        new Employee { Name = "Alice Smith", Department = "Engineering", Salary = 85000 },
        new Employee { Name = "Bob Jones", Department = "Marketing", Salary = 65000 },
        new Employee { Name = "Charlie Brown", Department = "HR", Salary = 55000 }
    );
    db.SaveChanges();
    Console.WriteLine("Data seeded successfully!\n");
}
else
{
    Console.WriteLine("Employees already exist in the database.\n");
}

Console.WriteLine("List of Employees in Database:");
Console.WriteLine("------------------------------");
foreach (var emp in db.Employees)
{
    Console.WriteLine($"ID: {emp.Id} | Name: {emp.Name} | Department: {emp.Department} | Salary: ${emp.Salary:N2}");
}

