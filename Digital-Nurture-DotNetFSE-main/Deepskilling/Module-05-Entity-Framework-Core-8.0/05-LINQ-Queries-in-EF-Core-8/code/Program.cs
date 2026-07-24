using LINQQueriesDemo.Data;
using LINQQueriesDemo.Models;
using LINQQueriesDemo.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var cfg=new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var opt=new DbContextOptionsBuilder<AppDbContext>()
.UseSqlite(cfg.GetConnectionString("DefaultConnection")).Options;
using var db=new AppDbContext(opt);

Console.WriteLine("LINQ Queries Demo Ready.");
Console.WriteLine();

// 1. Seed data if database is empty
if (!await db.Categories.AnyAsync())
{
    Console.WriteLine("Seeding Database...");
    var electronics = new Category { Name = "Electronics" };
    var books = new Category { Name = "Books" };

    db.Categories.AddRange(electronics, books);
    await db.SaveChangesAsync();

    db.Products.AddRange(
        new Product { Name = "Laptop", Price = 999.99m, Category = electronics },
        new Product { Name = "Smartphone", Price = 499.99m, Category = electronics },
        new Product { Name = "C# Programming Book", Price = 45.50m, Category = books },
        new Product { Name = "EF Core 8 Guide", Price = 35.00m, Category = books },
        new Product { Name = "Novel", Price = 9.99m, Category = books }
    );
    await db.SaveChangesAsync();
    Console.WriteLine("Database Seeding Completed.");
    Console.WriteLine();
}

// 2. Demonstration: Where
Console.WriteLine("--- Demo: Where (Products with price > 40) ---");
var expensiveProducts = await db.Products
    .Where(p => p.Price > 40.00m)
    .ToListAsync();

foreach (var product in expensiveProducts)
{
    Console.WriteLine($"- {product.Name}: ${product.Price}");
}
Console.WriteLine();

// 3. Demonstration: Select & OrderBy
Console.WriteLine("--- Demo: Select & OrderBy (Product names ordered alphabetically) ---");
var productNames = await db.Products
    .OrderBy(p => p.Name)
    .Select(p => p.Name)
    .ToListAsync();

foreach (var name in productNames)
{
    Console.WriteLine($"- {name}");
}
Console.WriteLine();

// 4. Demonstration: Projection to DTO
Console.WriteLine("--- Demo: Projection to DTO (ProductDTO) ---");
var productDtos = (await db.Products
    .Select(p => new ProductDTO
    {
        Name = p.Name,
        Price = p.Price
    })
    .ToListAsync())
    .OrderByDescending(p => p.Price)
    .ToList();

foreach (var dto in productDtos)
{
    Console.WriteLine($"- {dto.Name} is priced at ${dto.Price}");
}
Console.WriteLine();
