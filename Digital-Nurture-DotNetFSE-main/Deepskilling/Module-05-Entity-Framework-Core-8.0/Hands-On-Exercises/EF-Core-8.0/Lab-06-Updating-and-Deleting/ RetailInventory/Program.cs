using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

Console.WriteLine("===== UPDATE PRODUCT =====");

var product = await context.Products
    .FirstOrDefaultAsync(p => p.Name == "Laptop");

if (product != null)
{
    product.Price = 70000;
    await context.SaveChangesAsync();

    Console.WriteLine("Laptop price updated successfully.");
}

Console.WriteLine();

Console.WriteLine("===== DELETE PRODUCT =====");

var deleteProduct = await context.Products
    .FirstOrDefaultAsync(p => p.Name == "Rice Bag");

if (deleteProduct != null)
{
    context.Products.Remove(deleteProduct);

    await context.SaveChangesAsync();

    Console.WriteLine("Rice Bag deleted successfully.");
}

Console.WriteLine();

Console.WriteLine("===== REMAINING PRODUCTS =====");

var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Id}  {p.Name}  ₹{p.Price}");
}
