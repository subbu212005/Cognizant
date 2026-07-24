using EFCoreCrudDemo.Data;
using EFCoreCrudDemo.Models;
using EFCoreCrudDemo.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseSqlite(config.GetConnectionString("DefaultConnection"))
    .Options;

using var db = new AppDbContext(options);
var productService = new ProductService(db);

Console.WriteLine("========================================");
Console.WriteLine("  EF Core CRUD Demo: Basic Operations   ");
Console.WriteLine("========================================\n");

// 1. Create (Add)
Console.WriteLine("--- 1. Creating Products ---");
var product1 = new Product { Name = "Laptop", Price = 999.99m };
var product2 = new Product { Name = "Smartphone", Price = 499.99m };

productService.Add(product1);
productService.Add(product2);
Console.WriteLine($"Added Product: {product1.Name} with Price: {product1.Price:C}");
Console.WriteLine($"Added Product: {product2.Name} with Price: {product2.Price:C}\n");

// 2. Read (GetAll)
Console.WriteLine("--- 2. Reading Products ---");
var allProducts = productService.GetAll();
foreach (var p in allProducts)
{
    Console.WriteLine($"ID: {p.Id} | Name: {p.Name} | Price: {p.Price:C}");
}
Console.WriteLine();

// 3. Update
Console.WriteLine("--- 3. Updating Product Price ---");
var firstProduct = allProducts.FirstOrDefault();
if (firstProduct != null)
{
    Console.Write($"Updating ID {firstProduct.Id} ({firstProduct.Name}) price from {firstProduct.Price:C} ");
    firstProduct.Price = 899.99m;
    productService.Update(firstProduct);
    Console.WriteLine($"to {firstProduct.Price:C}\n");
}

// Read again
Console.WriteLine("--- Reading Products After Update ---");
foreach (var p in productService.GetAll())
{
    Console.WriteLine($"ID: {p.Id} | Name: {p.Name} | Price: {p.Price:C}");
}
Console.WriteLine();

// 4. Delete
Console.WriteLine("--- 4. Deleting a Product ---");
var productToDelete = productService.GetAll().LastOrDefault();
if (productToDelete != null)
{
    Console.WriteLine($"Deleting ID {productToDelete.Id} ({productToDelete.Name})...");
    productService.Delete(productToDelete);
}
Console.WriteLine();

// Final Read
Console.WriteLine("--- Reading Products After Delete ---");
var finalProducts = productService.GetAll();
if (finalProducts.Count == 0)
{
    Console.WriteLine("No products found in the database.");
}
else
{
    foreach (var p in finalProducts)
    {
        Console.WriteLine($"ID: {p.Id} | Name: {p.Name} | Price: {p.Price:C}");
    }
}
Console.WriteLine("\nDemo completed successfully.");

