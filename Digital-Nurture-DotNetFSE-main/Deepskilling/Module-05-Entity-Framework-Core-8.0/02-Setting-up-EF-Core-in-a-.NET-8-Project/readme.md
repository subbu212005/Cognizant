# Setting up EF Core in a .NET 8 Project

## Introduction

Entity Framework Core (EF Core) is Microsoft's modern Object-Relational Mapper (ORM) for .NET applications. Before using EF Core, it must be installed and configured in a .NET project. This includes installing the required NuGet packages, configuring the `DbContext`, connecting to SQL Server, and using EF Core CLI commands to create and update the database.

---

## Installing EF Core Packages via NuGet

EF Core packages can be installed using the .NET CLI or the NuGet Package Manager.

### Required Packages

* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Tools
* Microsoft.EntityFrameworkCore.Design

### Install Using .NET CLI

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
```

---

## Configuring DbContext

`DbContext` is the primary class responsible for interacting with the database. It manages entity objects, database connections, and CRUD operations.

### Example

```csharp
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
}
```

---

## Connecting to SQL Server

The database connection string is stored in **appsettings.json**.

### Example

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

Register the `DbContext` in **Program.cs**.

```csharp
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));
```

---

## Basic EF Core CLI Commands

Entity Framework Core provides command-line tools to create and manage database migrations.

### Add Migration

Creates a new migration based on model changes.

```bash
dotnet ef migrations add InitialCreate
```

### Update Database

Applies pending migrations to the database.

```bash
dotnet ef database update
```

### Remove Migration

Removes the last migration if it has not been applied.

```bash
dotnet ef migrations remove
```

### List Migrations

Displays all available migrations.

```bash
dotnet ef migrations list
```

---

## Advantages of EF Core Setup

* Easy database configuration
* Strong integration with .NET 8
* Automatic database migrations
* Simplified CRUD operations
* Cross-platform support
* Better maintainability

---

## Learning Outcome

After completing this topic, I learned how to install Entity Framework Core packages, configure `DbContext`, connect a .NET 8 application to SQL Server, and use EF Core CLI commands to manage database migrations and updates.

---

## Conclusion

Setting up Entity Framework Core is the foundation of database-driven .NET applications. Proper configuration enables efficient database connectivity, automated schema management, and simplified data access using C# objects.

