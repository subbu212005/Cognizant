# Overview of EF Core 8 and .NET 8 Integration

## Introduction

Entity Framework (EF) Core 8 is Microsoft's modern, lightweight, and cross-platform Object-Relational Mapper (ORM) for .NET applications. It enables developers to work with databases using C# objects instead of writing SQL queries manually.

.NET 8 is the latest Long-Term Support (LTS) release that offers improved performance, security, cloud integration, and seamless compatibility with Entity Framework Core 8.

---

## What is ORM (Object-Relational Mapping)?

Object-Relational Mapping (ORM) is a programming technique that maps database tables to C# classes and database records to objects.

Instead of writing SQL queries, developers interact with the database using C# objects.

### Benefits of ORM

- Reduces the amount of SQL code.
- Improves developer productivity.
- Simplifies database operations.
- Provides type safety.
- Easier maintenance and scalability.
- Supports database migrations.

---

## EF Core vs EF Framework

| Entity Framework | Entity Framework Core |
|------------------|----------------------|
| Windows only | Cross-platform |
| Supports .NET Framework | Supports .NET 8, .NET 7, .NET 6 |
| Larger framework | Lightweight |
| Slower performance | Faster performance |
| Limited cloud support | Excellent cloud support |
| Less flexible | Highly modular |

---

## New Features in EF Core 8

### Primitive Collections

Supports collections of primitive data types.

Example:

```csharp
public List<string> Skills { get; set; }
```

---

### Better Performance

- Faster query execution
- Improved memory usage
- Optimized SQL generation

---

### JSON Column Mapping

EF Core 8 provides improved support for JSON columns in supported databases.

---

### Complex Types

Supports reusable complex value objects without requiring separate tables.

---

### Improved LINQ Translation

Generates more efficient SQL queries from LINQ expressions.

---

### Raw SQL Improvements

Enhanced support for executing raw SQL queries.

---

### Bulk Updates and Deletes

Execute update and delete operations without loading entities into memory.

---

## Advantages of EF Core 8

- Cross-platform support
- High performance
- Automatic change tracking
- Strong LINQ support
- Easy migrations
- Better scalability
- Cloud-ready development

---

## Learning Outcome

After completing this topic, I understood the fundamentals of Object-Relational Mapping (ORM), differences between Entity Framework and Entity Framework Core, and the new features introduced in EF Core 8 with .NET 8 integration.

---

## Conclusion

Entity Framework Core 8 simplifies database development by allowing developers to work with C# objects while automatically handling SQL generation, making applications faster, cleaner, and easier to maintain.
