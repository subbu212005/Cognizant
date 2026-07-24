using Microsoft.EntityFrameworkCore;
using MigrationDemo.Models;

namespace MigrationDemo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Employee> Employees => Set<Employee>();
}
