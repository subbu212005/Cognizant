using RetailInventory.Data;
using RetailInventory.Models;

using var context = new AppDbContext();

// Create Categories
var electronics = new Category
{
    Name = "Electronics"
};

var groceries = new Category
{
    Name = "Groceries"
};

// Save Categories
await context.Categories.AddRangeAsync(electronics, groceries);
await context.SaveChangesAsync();

// Create Products
var laptop = new Product
{
    Name = "Laptop",
    Price = 75000,
    CategoryId = electronics.Id
};

var riceBag = new Product
{
    Name = "Rice Bag",
    Price = 1200,
    CategoryId = groceries.Id
};

// Save Products
await context.Products.AddRangeAsync(laptop, riceBag);
await context.SaveChangesAsync();

Console.WriteLine("Initial data inserted successfully.");

Console.WriteLine("----------------------------------");

Console.WriteLine("Categories Added:");
Console.WriteLine("1. Electronics");
Console.WriteLine("2. Groceries");

Console.WriteLine();

Console.WriteLine("Products Added:");
Console.WriteLine("Laptop - ₹75000");
Console.WriteLine("Rice Bag - ₹1200");
