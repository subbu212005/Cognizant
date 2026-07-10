# Lab 2 - Setting Up the Database Context for a Retail Store

## Objective

Learn how to configure Entity Framework Core by creating model classes, defining a DbContext, and connecting to a SQL Server database.

---

## Scenario

A retail store wants to store product and category information in a SQL Server database. Entity Framework Core is used to map C# objects to relational database tables.

---

## Prerequisites

- .NET 8 SDK
- SQL Server
- Visual Studio 2022 or VS Code
- EF Core Packages Installed

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Design
```

---

## Project Structure

```
RetailInventory
│
├── Models
│   ├── Category.cs
│   └── Product.cs
│
├── Data
│   └── AppDbContext.cs
│
└── Program.cs
```

---

## What is DbContext?

DbContext is the primary class in Entity Framework Core. It manages the database connection and performs CRUD operations.

---

## Steps Performed

- Created Category model
- Created Product model
- Created AppDbContext
- Added DbSet properties
- Configured SQL Server connection

---

## Expected Output

```
Retail Inventory Database Context Configured Successfully.

Connected to SQL Server using Entity Framework Core.
```

---

## Conclusion

This lab demonstrates how to configure DbContext and establish a connection between a .NET application and SQL Server using Entity Framework Core.
