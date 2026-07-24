using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PerformanceDemo.Data;
using PerformanceDemo.Models;
using PerformanceDemo.Services;
using System.Diagnostics;

var cfg = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var opt = new DbContextOptionsBuilder<AppDbContext>()
    .UseSqlite(cfg.GetConnectionString("DefaultConnection")).Options;

using var db = new AppDbContext(opt);
using var db2 = new AppDbContext(opt); // For concurrency simulation

// 1. Ensure migrations are applied
await db.Database.MigrateAsync();

Console.WriteLine("Applying Database Seeding (if necessary)...");
// 2. Seed database
int expectedProducts = 5000;
int currentProducts = await db.Products.CountAsync();
if (currentProducts < expectedProducts)
{
    int toAdd = expectedProducts - currentProducts;
    Console.WriteLine($"Seeding {toAdd} products...");
    var list = new List<Product>();
    for (int i = 0; i < toAdd; i++)
    {
        list.Add(new Product 
        { 
            Name = $"SeedProduct_{i + currentProducts}", 
            Price = 10.0m + (i % 100), 
            Version = 1 
        });
    }
    await db.Products.AddRangeAsync(list);
    await db.SaveChangesAsync();
    Console.WriteLine("Seeding completed successfully.");
}
else
{
    Console.WriteLine("Seeding skipped. Database already contains sufficient data.");
}

Console.WriteLine("\n==========================================");
Console.WriteLine("  EF Core 8 Performance Optimization Benchmarks");
Console.WriteLine("==========================================\n");

var service = new PerformanceService(db, db2);

// Benchmark 1: AsNoTracking
Console.Write("Running AsNoTracking Benchmark... ");
var noTracking = await service.RunAsNoTrackingBenchmarkAsync();
Console.WriteLine("Done.");

// Benchmark 2: Query Projection
Console.Write("Running Query Projection Benchmark... ");
var projection = await service.RunProjectionBenchmarkAsync();
Console.WriteLine("Done.");

// Benchmark 3: Batch Insert
Console.Write("Running Batch Insert Benchmark (200 records)... ");
var batchInsert = await service.RunBatchInsertBenchmarkAsync();
Console.WriteLine("Done.");

// Benchmark 4: Compiled Queries
Console.Write("Running Compiled Queries Benchmark (100 runs)... ");
var compiledQuery = await service.RunCompiledQueryBenchmarkAsync();
Console.WriteLine("Done.");

// Benchmark 5: Bulk Updates (EF Core 8)
Console.Write("Running Bulk Updates Benchmark... ");
var bulkUpdate = await service.RunBulkUpdateBenchmarkAsync();
Console.WriteLine("Done.");

// Benchmark 6: Concurrency Simulation
Console.WriteLine("\nRunning Concurrency Conflict Simulation:");
var concurrencyResult = await service.RunConcurrencyDemoAsync();
Console.WriteLine(concurrencyResult);

// Print Results Table
Console.WriteLine("\n==========================================================================");
Console.WriteLine("| Optimization Topic | Unoptimized (Standard) | Optimized Approach     | Speedup |");
Console.WriteLine("==========================================================================");

Console.WriteLine($"| AsNoTracking       | {noTracking.trackingMs,15:F2} ms    | {noTracking.noTrackingMs,13:F2} ms      | {noTracking.trackingMs / noTracking.noTrackingMs,6:F2}x |");
Console.WriteLine($"| Query Projection   | {projection.fullEntityMs,15:F2} ms    | {projection.projectionMs,13:F2} ms      | {projection.fullEntityMs / projection.projectionMs,6:F2}x |");
Console.WriteLine($"| Batch Insert       | {batchInsert.individualMs,15:F2} ms    | {batchInsert.batchedMs,13:F2} ms      | {batchInsert.individualMs / batchInsert.batchedMs,6:F2}x |");
Console.WriteLine($"| Compiled Queries   | {compiledQuery.regularMs,15:F2} ms    | {compiledQuery.compiledMs,13:F2} ms      | {compiledQuery.regularMs / compiledQuery.compiledMs,6:F2}x |");
Console.WriteLine($"| Bulk Updates       | {bulkUpdate.traditionalMs,15:F2} ms    | {bulkUpdate.bulkMs,13:F2} ms      | {bulkUpdate.traditionalMs / bulkUpdate.bulkMs,6:F2}x |");

Console.WriteLine("==========================================================================\n");

Console.WriteLine("Memory Impact of Tracking vs AsNoTracking:");
Console.WriteLine($"- Tracking query memory:    {noTracking.trackingMem / 1024.0:F2} KB");
Console.WriteLine($"- NoTracking query memory:  {noTracking.noTrackingMem / 1024.0:F2} KB");
Console.WriteLine($"* Memory Saved:             {(noTracking.trackingMem - noTracking.noTrackingMem) / 1024.0:F2} KB");