using Microsoft.EntityFrameworkCore;
using EFCoreCrudDemo.Models;

namespace EFCoreCrudDemo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}
