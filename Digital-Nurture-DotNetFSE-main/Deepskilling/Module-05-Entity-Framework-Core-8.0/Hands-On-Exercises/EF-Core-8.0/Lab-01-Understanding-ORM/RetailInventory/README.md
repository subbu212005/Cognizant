# Lab 1 - Understanding ORM with a Retail Inventory System

## Objective

Learn the fundamentals of Object Relational Mapping (ORM) and understand how Entity Framework Core 8.0 simplifies database operations by mapping C# objects to SQL Server tables.

---

## Scenario

A retail store wants to build an inventory management system to manage products, categories, and stock levels using SQL Server.

---

## What You Will Learn

- What is ORM?
- Advantages of ORM
- Difference between EF Core and Entity Framework 6
- New Features in EF Core 8
- Creating a .NET Console Application
- Installing Entity Framework Core Packages

---

## Software Requirements

- Visual Studio 2022 / VS Code
- .NET 8 SDK
- SQL Server
- EF Core 8.0 Packages

---

## Create Project

```bash
dotnet new console -n RetailInventory
cd RetailInventory
```

Install EF Core Packages

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Design
```

---

## What is ORM?

Object Relational Mapping (ORM) is a technique that maps C# classes to database tables.

Instead of writing SQL queries manually, developers work with C# objects while EF Core automatically generates SQL commands.

Example:

| C# Class | SQL Table |
|----------|-----------|
| Product | Products |
| Category | Categories |

---

## Benefits of ORM

- Less SQL code
- Faster development
- Better maintainability
- Strongly typed queries
- LINQ support
- Database independence

---

## EF Core vs Entity Framework 6

| EF Core | EF6 |
|-----------|------|
| Cross Platform | Windows Only |
| Lightweight | Large Framework |
| High Performance | Moderate |
| Supports .NET 8 | No |
| Better LINQ | Basic LINQ |
| Active Development | Maintenance Mode |

---

## New Features in EF Core 8

- JSON Column Mapping
- Compiled Models
- Better Performance
- Improved Bulk Operations
- Interceptors
- Async Database Operations

---

## Expected Output

```
Retail Inventory System

Project Created Successfully.

Entity Framework Core Packages Installed.

Ready to connect SQL Server.
```

---

## Conclusion

In this lab we understood the basics of ORM and Entity Framework Core. We also created our first .NET Console project and installed the required EF Core packages.

