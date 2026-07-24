using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LINQQueriesDemo.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var basePath = Directory.GetCurrentDirectory();
        
        // In some EF core tooling scenarios, the current directory might be the output path or somewhere else, 
        // so we search for appsettings.json or fallback.
        var builder = new ConfigurationBuilder();
        if (File.Exists(Path.Combine(basePath, "appsettings.json")))
        {
            builder.SetBasePath(basePath);
        }
        else if (File.Exists(Path.Combine(basePath, "..", "LINQQueriesDemo", "appsettings.json")))
        {
            builder.SetBasePath(Path.GetFullPath(Path.Combine(basePath, "..", "LINQQueriesDemo")));
        }
        
        var configuration = builder
            .AddJsonFile("appsettings.json", optional: true)
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection") 
            ?? "Data Source=LINQQueriesDemoDB.db";

        var dbOptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        dbOptionsBuilder.UseSqlite(connectionString);

        return new AppDbContext(dbOptionsBuilder.Options);
    }
}
