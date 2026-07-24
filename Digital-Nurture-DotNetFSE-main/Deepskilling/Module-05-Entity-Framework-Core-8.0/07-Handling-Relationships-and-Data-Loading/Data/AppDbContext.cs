using Microsoft.EntityFrameworkCore;
using RelationshipsDemo.Models;
namespace RelationshipsDemo.Data;
public class AppDbContext:DbContext{
public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
public DbSet<Department> Departments=>Set<Department>();
public DbSet<Employee> Employees=>Set<Employee>();
public DbSet<Project> Projects=>Set<Project>();
public DbSet<EmployeeProject> EmployeeProjects=>Set<EmployeeProject>();
protected override void OnModelCreating(ModelBuilder modelBuilder){
modelBuilder.Entity<EmployeeProject>().HasKey(x=>new{x.EmployeeId,x.ProjectId});
}
}