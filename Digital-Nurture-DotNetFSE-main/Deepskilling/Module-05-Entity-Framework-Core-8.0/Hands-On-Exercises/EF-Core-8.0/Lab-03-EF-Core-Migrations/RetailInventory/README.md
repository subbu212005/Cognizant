# Lab 3 - Using EF Core CLI to Create and Apply Migrations

## Objective

Learn how to create and apply Entity Framework Core migrations to generate a SQL Server database from C# model classes.

---

## Scenario

The retail store needs a database that matches the Product and Category models created in the previous lab.

---

## Prerequisites

- .NET 8 SDK
- SQL Server
- EF Core Packages Installed
- dotnet-ef CLI Tool

---

## Step 1: Install EF Core CLI

```bash
dotnet tool install --global dotnet-ef
```

If already installed:

```bash
dotnet tool update --global dotnet-ef
```

---

## Step 2: Verify Installation

```bash
dotnet ef --version
```

---

## Step 3: Create Initial Migration

```bash
dotnet ef migrations add InitialCreate
```

---

## Step 4: Apply Migration

```bash
dotnet ef database update
```

---

## Step 5: Verify Database

Open SQL Server Management Studio (SSMS).

Database:

RetailInventoryDB

Tables:

- Categories
- Products

---

## Result

Entity Framework automatically creates the database and tables based on the model classes.

---

## Conclusion

This lab demonstrates Code-First Migration using Entity Framework Core.
