using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

Console.WriteLine("===== ALL PRODUCTS =====");

var products = await context.Products.ToListAsync();

foreach (var product in products)
{
    Console.WriteLine($"{product.Id}  {product.Name}  ₹{product.Price}");
}

Console.WriteLine();

Console.WriteLine("===== FIND PRODUCT BY ID =====");

var foundProduct = await context.Products.FindAsync(1);

if (foundProduct != null)
{
    Console.WriteLine($"Found: {foundProduct.Name}");
}
else
{
    Console.WriteLine("Product not found.");
}

Console.WriteLine();

Console.WriteLine("===== FIRST PRODUCT PRICE > 50000 =====");

var expensiveProduct = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

if (expensiveProduct != null)
{
    Console.WriteLine($"Expensive Product: {expensiveProduct.Name}");
}
else
{
    Console.WriteLine("No expensive product found.");
}
