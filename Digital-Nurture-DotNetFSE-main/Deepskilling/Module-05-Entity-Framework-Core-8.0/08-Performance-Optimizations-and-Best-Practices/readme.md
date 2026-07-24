# Performance Optimizations and Best Practices

## Introduction

Performance optimization is essential for building fast, scalable, and efficient database applications. Entity Framework Core 8 provides several features to improve query performance, reduce memory usage, and optimize database interactions. Understanding these techniques helps developers create responsive and high-performance applications.

This topic covers query caching, tracking behavior, batch processing, bulk operations, concurrency handling, and compiled queries.

---

## Query Caching

Entity Framework Core automatically caches query execution plans to reduce the overhead of repeatedly generating SQL statements.

### Benefits

* Faster query execution
* Reduced CPU usage
* Improved application performance

---

# 08 - EF Core 8 Performance Optimizations and Best Practices

This project demonstrates and benchmarks key performance optimization strategies and best practices in Entity Framework Core 8.

To make the demonstration self-contained and run on any machine without external database server setups, the project is configured to use a local **SQLite** database.

---

##  How to Run the Project

1. Navigate to the project root:
   ```bash
   cd Code/PerformanceDemo
   ```

2. Run the application:
   ```bash
   dotnet run
   ```
   *Note: Database migrations will be applied and the database will be automatically seeded on startup.*

---

##  Optimization Topics & Implementation Details

### 1. AsNoTracking
* **Concept**: Bypasses the EF Core state tracker for read-only queries.
* **Why it matters**: Disabling tracking saves substantial memory (as EF doesn't need to maintain shadow properties or references in the context tracker) and executes faster because change tracking snapshots are skipped.
* **Code Example**:
  ```csharp
  // Unoptimized (Tracking)
  var products = await db.Products.ToListAsync();

  // Optimized (No Tracking)
  var products = await db.Products.AsNoTracking().ToListAsync();
  ```

### 2. Query Projection
* **Concept**: Retrieves only the columns required by the application rather than whole entities (`SELECT *`).
* **Why it matters**: Reduces network load, disk I/O, and client-side memory footprint by avoiding retrieval of unused columns.
* **Code Example**:
  ```csharp
  // Unoptimized
  var products = await db.Products.ToListAsync();

  // Optimized
  var products = await db.Products
      .Select(p => new { p.Name, p.Price })
      .ToListAsync();
  ```

### 3. Batch Operations (Batch Insert)
* **Concept**: Groups database write operations instead of saving them one-by-one.
* **Why it matters**: Calling `SaveChanges()` in a loop creates a new database connection round-trip for each record, causing massive latency. Calling `SaveChanges()` once allows EF Core to execute them in bulk.
* **Code Example**:
  ```csharp
  // Unoptimized
  for (int i = 0; i < 200; i++) {
      db.Products.Add(new Product { ... });
      await db.SaveChangesAsync(); // 200 database round-trips!
  }

  // Optimized
  for (int i = 0; i < 200; i++) {
      db.Products.Add(new Product { ... });
  }
  await db.SaveChangesAsync(); // 1 database round-trip!
  ```

### 4. Compiled Queries
* **Concept**: Pre-compiles query execution plans so EF Core doesn't have to translate LINQ expressions to SQL on every execution.
* **Why it matters**: Useful for frequently executed queries to eliminate translation and compilation overhead.
* **Code Example**:
  ```csharp
  // Define compiled query
  private static readonly Func<AppDbContext, decimal, IAsyncEnumerable<Product>> _productsByPriceCompiled =
      EF.CompileAsyncQuery((AppDbContext db, decimal minPrice) =>
          db.Products.Where(p => p.Price >= minPrice));
  ```

### 5. Bulk Updates & Deletes (EF Core 7/8)
* **Concept**: Directly executes UPDATE or DELETE SQL statements in the database without loading the entities into the DbContext first.
* **Why it matters**: Eliminates the overhead of loading data into memory, tracking it, modifying it, and saving it.
* **Code Example**:
  ```csharp
  // Unoptimized
  var products = await db.Products.Where(p => p.Price < 20).ToListAsync();
  foreach(var p in products) { p.Price += 1.0m; }
  await db.SaveChangesAsync();

  // Optimized (EF Core 8 ExecuteUpdate)
  await db.Products
      .Where(p => p.Price < 20)
      .ExecuteUpdateAsync(s => s.SetProperty(p => p.Price, p => p.Price + 1.0m));
  ```

### 6. Optimistic Concurrency
* **Concept**: Detects concurrency conflicts when multiple users attempt to update the same record simultaneously using a concurrency check token.
* **Implementation**: We use the `Version` property on `Product` with `[ConcurrencyCheck]`. The application intercepts `DbUpdateConcurrencyException`, reloads values from the database, and resolves conflict.

---

##  Performance Notes on Local SQLite
When running these benchmarks locally, some database optimizations (like compiled queries and bulk updates) might appear faster in their unoptimized form. 
This is because:
1. **Zero Network Latency**: SQLite is an in-process database, meaning network roundtrip latency is zero. The database command generation overhead of some advanced queries can sometimes exceed SQLite's fast local execution.
2. **Dataset Size**: On production enterprise databases with millions of rows and multi-millisecond network latency, optimizations like Projections and Bulk Updates yield orders-of-magnitude improvements.
