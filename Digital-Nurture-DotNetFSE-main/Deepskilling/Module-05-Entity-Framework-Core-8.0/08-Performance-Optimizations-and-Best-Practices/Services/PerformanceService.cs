using Microsoft.EntityFrameworkCore;
using PerformanceDemo.Data;
using PerformanceDemo.Models;
using System.Diagnostics;

namespace PerformanceDemo.Services;

public class PerformanceService
{
    private readonly AppDbContext _db;
    private readonly AppDbContext _db2; // Useful for concurrency simulation

    public PerformanceService(AppDbContext db, AppDbContext db2)
    {
        _db = db;
        _db2 = db2;
    }

    // Helper for memory measurement
    private static long GetMemoryUsage() => GC.GetTotalMemory(true);

    // 1. AsNoTracking Benchmark
    public async Task<(double trackingMs, long trackingMem, double noTrackingMs, long noTrackingMem)> RunAsNoTrackingBenchmarkAsync()
    {
        // Clear tracker
        _db.ChangeTracker.Clear();

        // With Tracking
        long memStart = GetMemoryUsage();
        var sw = Stopwatch.StartNew();
        var trackingList = await _db.Products.ToListAsync();
        sw.Stop();
        double trackingMs = sw.Elapsed.TotalMilliseconds;
        long trackingMem = GetMemoryUsage() - memStart;

        // Clear tracker to ensure clean test for AsNoTracking
        _db.ChangeTracker.Clear();

        // Without Tracking
        memStart = GetMemoryUsage();
        sw.Restart();
        var noTrackingList = await _db.Products.AsNoTracking().ToListAsync();
        sw.Stop();
        double noTrackingMs = sw.Elapsed.TotalMilliseconds;
        long noTrackingMem = GetMemoryUsage() - memStart;

        return (trackingMs, Math.Max(0, trackingMem), noTrackingMs, Math.Max(0, noTrackingMem));
    }

    // 2. Query Projection Benchmark
    public async Task<(double fullEntityMs, long fullEntityMem, double projectionMs, long projectionMem)> RunProjectionBenchmarkAsync()
    {
        _db.ChangeTracker.Clear();

        // Full Entity
        long memStart = GetMemoryUsage();
        var sw = Stopwatch.StartNew();
        var fullList = await _db.Products.AsNoTracking().ToListAsync();
        sw.Stop();
        double fullEntityMs = sw.Elapsed.TotalMilliseconds;
        long fullEntityMem = GetMemoryUsage() - memStart;

        // Projection
        memStart = GetMemoryUsage();
        sw.Restart();
        var projectedList = await _db.Products.AsNoTracking()
            .Select(p => new { p.Name, p.Price })
            .ToListAsync();
        sw.Stop();
        double projectionMs = sw.Elapsed.TotalMilliseconds;
        long projectionMem = GetMemoryUsage() - memStart;

        return (fullEntityMs, Math.Max(0, fullEntityMem), projectionMs, Math.Max(0, projectionMem));
    }

    // 3. Batch Insert Benchmark
    public async Task<(double individualMs, double batchedMs)> RunBatchInsertBenchmarkAsync()
    {
        // Clean up any test products first to keep database clean
        await _db.Products.Where(p => p.Name.StartsWith("BatchTestTemp")).ExecuteDeleteAsync();

        int insertCount = 200;

        // 1. Individual inserts (bad practice)
        var sw = Stopwatch.StartNew();
        for (int i = 0; i < insertCount; i++)
        {
            _db.Products.Add(new Product { Name = $"BatchTestTemp_Indiv_{i}", Price = 10.0m + i, Version = 1 });
            await _db.SaveChangesAsync();
        }
        sw.Stop();
        double individualMs = sw.Elapsed.TotalMilliseconds;

        // Clean up individual inserts
        await _db.Products.Where(p => p.Name.StartsWith("BatchTestTemp_Indiv")).ExecuteDeleteAsync();

        // 2. Batched insert (good practice)
        sw.Restart();
        for (int i = 0; i < insertCount; i++)
        {
            _db.Products.Add(new Product { Name = $"BatchTestTemp_Batch_{i}", Price = 10.0m + i, Version = 1 });
        }
        await _db.SaveChangesAsync();
        sw.Stop();
        double batchedMs = sw.Elapsed.TotalMilliseconds;

        // Clean up batched inserts
        await _db.Products.Where(p => p.Name.StartsWith("BatchTestTemp_Batch")).ExecuteDeleteAsync();

        return (individualMs, batchedMs);
    }

    // 4. Compiled Queries Benchmark
    // Define a static compiled query for looking up products by price range
    private static readonly Func<AppDbContext, decimal, IAsyncEnumerable<Product>> _productsByPriceCompiled =
        EF.CompileAsyncQuery((AppDbContext db, decimal minPrice) =>
            db.Products.Where(p => p.Price >= minPrice));

    public async Task<(double regularMs, double compiledMs)> RunCompiledQueryBenchmarkAsync()
    {
        int iterations = 100;
        decimal targetPrice = 50.0m;

        // Warmup
        _ = await _db.Products.Where(p => p.Price >= targetPrice).ToListAsync();
        await foreach (var _ in _productsByPriceCompiled(_db, targetPrice)) { }

        // Regular LINQ Query
        var sw = Stopwatch.StartNew();
        for (int i = 0; i < iterations; i++)
        {
            var list = await _db.Products.Where(p => p.Price >= targetPrice).ToListAsync();
        }
        sw.Stop();
        double regularMs = sw.Elapsed.TotalMilliseconds;

        // Compiled Query
        sw.Restart();
        for (int i = 0; i < iterations; i++)
        {
            var list = new List<Product>();
            await foreach (var item in _productsByPriceCompiled(_db, targetPrice))
            {
                list.Add(item);
            }
        }
        sw.Stop();
        double compiledMs = sw.Elapsed.TotalMilliseconds;

        return (regularMs, compiledMs);
    }

    // 5. Bulk Update / Delete Benchmark
    public async Task<(double traditionalMs, double bulkMs)> RunBulkUpdateBenchmarkAsync()
    {
        // We'll update the price of a subset of products (e.g. products with price < 20)
        // First count them to see what we are dealing with
        int count = await _db.Products.CountAsync(p => p.Price < 20.0m);
        if (count == 0)
        {
            // Seed a few cheap products for this test
            for (int i = 0; i < 50; i++)
            {
                _db.Products.Add(new Product { Name = $"CheapProduct_{i}", Price = 15.0m, Version = 1 });
            }
            await _db.SaveChangesAsync();
        }

        // 1. Traditional Update (Query, Loop, Modify, SaveChanges)
        var sw = Stopwatch.StartNew();
        var cheapProducts = await _db.Products.Where(p => p.Name.StartsWith("CheapProduct_")).ToListAsync();
        foreach (var p in cheapProducts)
        {
            p.Price += 1.0m;
        }
        await _db.SaveChangesAsync();
        sw.Stop();
        double traditionalMs = sw.Elapsed.TotalMilliseconds;

        // 2. Bulk Update (ExecuteUpdate)
        sw.Restart();
        await _db.Products
            .Where(p => p.Name.StartsWith("CheapProduct_"))
            .ExecuteUpdateAsync(s => s.SetProperty(p => p.Price, p => p.Price + 1.0m));
        sw.Stop();
        double bulkMs = sw.Elapsed.TotalMilliseconds;

        // Clean up test data
        await _db.Products.Where(p => p.Name.StartsWith("CheapProduct_")).ExecuteDeleteAsync();

        return (traditionalMs, bulkMs);
    }

    // 6. Concurrency Conflict Simulation
    public async Task<string> RunConcurrencyDemoAsync()
    {
        // 1. Setup a product to test
        var product = new Product { Name = "ConcurrencyDemoProduct", Price = 100.0m, Version = 1 };
        _db.Products.Add(product);
        await _db.SaveChangesAsync();

        var productId = product.Id;

        // 2. Fetch the same product using two different DB contexts (simulating two different concurrent users)
        var client1Product = await _db.Products.FindAsync(productId);
        var client2Product = await _db2.Products.FindAsync(productId);

        if (client1Product == null || client2Product == null)
            return "Failed to initialize concurrency test product.";

        // 3. User 1 updates price and saves
        client1Product.Price = 120.0m;
        client1Product.Version++; // Increment version to trigger conflict check
        await _db.SaveChangesAsync();

        // 4. User 2 updates price and saves (this should throw a concurrency exception because the version in database has changed)
        client2Product.Price = 150.0m;
        client2Product.Version++; // Increment version

        string result = "";
        try
        {
            await _db2.SaveChangesAsync();
            result = "Warning: Expected concurrency exception but SaveChanges succeeded.";
        }
        catch (DbUpdateConcurrencyException ex)
        {
            result = $"Success: Concurrency exception thrown as expected: {ex.Message.Split('\n')[0]}\n";
            
            // Resolve conflict (e.g. client wins)
            var entry = ex.Entries.Single();
            var proposedValues = entry.CurrentValues.Clone();
            var databaseValues = await entry.GetDatabaseValuesAsync();

            if (databaseValues != null)
            {
                result += $"Database original price: {databaseValues["Price"]}\n";
                result += $"Proposed client price: {proposedValues["Price"]}\n";
                
                // Refresh original values to match database values to resolve conflict
                entry.OriginalValues.SetValues(databaseValues);
                
                // Save again with database values loaded as original
                await _db2.SaveChangesAsync();
                result += "Concurrency conflict resolved successfully by refreshing database values.";
            }
        }

        // Clean up
        var cleanupProduct = await _db.Products.FindAsync(productId);
        if (cleanupProduct != null)
        {
            _db.Products.Remove(cleanupProduct);
            await _db.SaveChangesAsync();
        }

        return result;
    }
}