using Microsoft.EntityFrameworkCore;
using PerformanceDemo.Models;
namespace PerformanceDemo.Data;
public class AppDbContext:DbContext{
 public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
 public DbSet<Product> Products=>Set<Product>();
 public DbSet<Order> Orders=>Set<Order>();

 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
     modelBuilder.Entity<Product>()
         .Property(p => p.Price)
         .HasPrecision(18, 2);

     modelBuilder.Entity<Order>()
         .Property(o => o.TotalAmount)
         .HasPrecision(18, 2);
 }
}