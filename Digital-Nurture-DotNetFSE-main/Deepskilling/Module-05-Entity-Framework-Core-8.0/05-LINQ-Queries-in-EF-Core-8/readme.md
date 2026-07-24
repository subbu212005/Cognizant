# LINQ Queries in EF Core 8

## Introduction

Language Integrated Query (LINQ) is a powerful feature in C# that enables developers to query collections and databases using strongly typed syntax. In Entity Framework Core 8, LINQ queries are automatically translated into SQL statements, making data retrieval simple, efficient, and type-safe.

This topic covers filtering, selecting, ordering, projecting data into DTOs, aggregating data, and executing asynchronous queries.

# 05 - LINQ Queries in EF Core 8

This project demonstrates various LINQ (Language Integrated Query) queries with Entity Framework Core 8 in a .NET 8 console application. 

It is preconfigured with SQLite, database migrations, and automatic seeding to run seamlessly on any local environment.

## Features Demonstrated

The application demonstrates the following core LINQ and EF Core operations:
- **Automatic Database Seeding:** Checks and seeds categories and products if the database is empty.
- **Where:** Filtering datasets asynchronously based on conditions (e.g., retrieving products with price > $40).
- **Select:** Projecting data properties from entities.
- **OrderBy & OrderByDescending:** Ordering data ascendingly/descendingly (including client-side ordering for SQLite decimal compatibility).
- **Projection to DTO:** Mapping query results directly into data transfer objects (`ProductDTO`).
- **ToListAsync:** Executing database queries asynchronously.

## Project Structure

- **`Program.cs`:** Application entry point containing the configuration setup, database context initialization, seeding logic, and LINQ demo queries.
- **`Data/AppDbContext.cs`:** The EF Core DbContext definition registering model sets (`Products`, `Categories`).
- **`Data/AppDbContextFactory.cs`:** Design-time factory resolving DbContext construction during EF migrations.
- **`Models/`:** Contains database entities (`Product`, `Category`).
- **`DTOs/`:** Contains data transfer object classes (`ProductDTO`).

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [EF Core CLI Tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) (optional, if you want to modify migrations)

### Run the Application

1. Clone or download the repository.
2. Open your terminal in the `LINQQueriesDemo` project directory.
3. Build and run the project:
   ```bash
   dotnet run
   ```
4. The database (`LINQQueriesDemoDB.db`) will be automatically created on the first run, seeded with sample records, and the demo query results will print out to the console.

## EF Core 8 LINQ Concepts Illustrated

### 1. Deferred Execution vs. Immediate Execution
LINQ queries in EF Core are *deferred*. This means that defining a query does not immediately run it against the database. Instead, EF Core builds an expression tree representation of the query. 
The query is only sent to the database and executed when the results are actually requested, for example when:
- Iterating over the results in a `foreach` loop.
- Calling terminal methods like `ToListAsync()`, `ToList()`, `CountAsync()`, or `FirstAsync()`.

### 2. Database Provider Translations
EF Core translates LINQ expression trees into SQL statements optimized for the target database provider (in this case, SQLite). 
However, different databases support different features. For instance, SQLite does not support expressions of type `decimal` inside SQL `ORDER BY` clauses natively. 

In this project, we illustrate how to handle provider limitations cleanly by executing the projection query first and applying client-side sorting:
```csharp
var productDtos = (await db.Products
    .Select(p => new ProductDTO
    {
        Name = p.Name,
        Price = p.Price
    })
    .ToListAsync()) // Fetches data from database
    .OrderByDescending(p => p.Price) // Sorts in-memory (client-side)
    .ToList();
```

### 3. Projection to DTOs
Retrieving entire entity classes when you only need a subset of properties is inefficient. By projecting results into a Data Transfer Object (DTO) using `.Select()`, EF Core translates the query to request only the required database columns (e.g. `SELECT Name, Price FROM Products` instead of `SELECT * FROM Products`), reducing database load and network traffic.
