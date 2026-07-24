using Microsoft.EntityFrameworkCore;
using LINQQueriesDemo.Models;
namespace LINQQueriesDemo.Data;
public class AppDbContext:DbContext{
 public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
 public DbSet<Product> Products=>Set<Product>();
 public DbSet<Category> Categories=>Set<Category>();
}