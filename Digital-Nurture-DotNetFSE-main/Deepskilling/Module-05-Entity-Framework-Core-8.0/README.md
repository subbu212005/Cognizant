# Module 5 - Entity Framework Core 8.0

## Overview

Entity Framework Core (EF Core) 8.0 is Microsoft's modern, lightweight, open-source, and cross-platform Object-Relational Mapper (ORM) for .NET applications. It enables developers to interact with relational databases using C# objects instead of writing raw SQL queries, thereby reducing development time and improving code maintainability.

This module introduces the concepts of Object-Relational Mapping (ORM) using Entity Framework Core 8.0. It covers configuring EF Core in a .NET 8 application, creating database models using the Code-First approach, performing CRUD operations, executing LINQ queries, managing database migrations, handling relationships, and optimizing application performance using Entity Framework Core.

---

# Learning Objectives

After completing this module, learners will be able to:

- Understand the concept of Object-Relational Mapping (ORM).
- Explain the architecture and features of Entity Framework Core 8.0.
- Differentiate Entity Framework and Entity Framework Core.
- Configure Entity Framework Core in a .NET 8 project.
- Install and configure EF Core packages using NuGet.
- Configure DbContext and connect applications to SQL Server.
- Create database models using the Code-First approach.
- Define entities, primary keys, foreign keys, and navigation properties.
- Perform Create, Read, Update, and Delete (CRUD) operations.
- Write LINQ queries for data retrieval and manipulation.
- Create and manage database migrations.
- Seed initial data into the database.
- Configure One-to-One, One-to-Many, and Many-to-Many relationships.
- Apply Eager Loading, Lazy Loading, and Explicit Loading techniques.
- Optimize performance using AsNoTracking(), compiled queries, and batch processing.
- Follow best practices for developing scalable and maintainable data-driven applications.

---

# Prerequisites

Before starting this module, learners should have knowledge of:

- C# Programming
- Object-Oriented Programming (OOP)
- SQL and Relational Databases
- Microsoft SQL Server
- .NET 8 SDK
- Visual Studio 2022

---

# Why Entity Framework Core?

Developers traditionally write SQL queries for every database operation. As applications grow, managing SQL code becomes complex and time-consuming.

Entity Framework Core simplifies database development by allowing developers to interact with databases using C# objects while automatically generating SQL queries.

Example:

Without EF Core

```sql
SELECT * FROM Students WHERE StudentId = 1;
```

With EF Core

```csharp
var student = await context.Students.FindAsync(1);
```

---

# Features of Entity Framework Core 8

- Cross-platform support
- Lightweight and high performance
- Object-Relational Mapping (ORM)
- Code-First development
- Database-First support
- LINQ integration
- Automatic change tracking
- Database migrations
- Dependency Injection support
- Asynchronous database operations
- Relationship management
- Query optimization
- JSON column mapping
- Primitive collections
- Compiled queries

---

# Module Topics

This module consists of the following topics:

## 1. Overview of EF Core 8 and .NET 8 Integration

Topics Covered

- What is ORM?
- Benefits of ORM
- EF Core vs Entity Framework
- New Features in EF Core 8

---

## 2. Setting up EF Core in a .NET 8 Project

Topics Covered

- Installing EF Core Packages
- Configuring DbContext
- SQL Server Connection
- Connection Strings
- EF Core CLI Commands
- Database Configuration

---

## 3. Creating a Simple Database Model

Topics Covered

- Entity Classes
- Primary Keys
- Foreign Keys
- Navigation Properties
- Relationships
- Code-First Approach

---

## 4. Performing Basic CRUD Operations

Topics Covered

- AddAsync()
- FindAsync()
- FirstOrDefaultAsync()
- ToListAsync()
- Update()
- Remove()
- RemoveRange()
- SaveChangesAsync()

---

## 5. LINQ Queries in EF Core 8

Topics Covered

- Where()
- Select()
- OrderBy()
- Projection into DTOs
- Aggregate Functions
- Asynchronous Queries

---

## 6. EF Core Migrations and Database Updates

Topics Covered

- Add Migration
- Update Database
- Remove Migration
- List Migrations
- Seed Data
- Database Schema Management

---

## 7. Handling Relationships and Data Loading

Topics Covered

- One-to-One Relationship
- One-to-Many Relationship
- Many-to-Many Relationship
- Navigation Properties
- Eager Loading
- Lazy Loading
- Explicit Loading
- Circular References

---

## 8. Performance Optimizations and Best Practices

Topics Covered

- Query Caching
- AsNoTracking()
- Batch Processing
- Bulk Operations
- Compiled Queries
- RowVersion Concurrency
- Performance Best Practices

---

# Technologies Used

- .NET 8
- C#
- Entity Framework Core 8
- SQL Server
- SQL Server Management Studio (SSMS)
- Visual Studio 2022
- LINQ
- NuGet Package Manager

---

# Folder Structure

```text
Module-05-Entity-Framework-Core-8.0
│
├── README.md
│
├── 01-Overview-of-EF-Core-8-and-.NET-8-Integration
├── 02-Setting-up-EF-Core-in-a-.NET-8-Project
├── 03-Creating-a-Simple-Database-Model
├── 04-Performing-Basic-CRUD-Operations
├── 05-LINQ-Queries-in-EF-Core-8
├── 06-EF-Core-Migrations-and-Database-Updates
├── 07-Handling-Relationships-and-Data-Loading
├── 08-Performance-Optimizations-and-Best-Practices
│
├── Hands-On-Exercises
│
└── Module-5-Quiz
```

---

# Skills Gained

After completing this module, learners will gain experience in:

- Object-Relational Mapping (ORM)
- Entity Framework Core 8
- Code-First Development
- Database Modeling
- SQL Server Integration
- CRUD Operations
- LINQ Queries
- Database Migrations
- Relationship Management
- Data Loading Strategies
- Query Optimization
- Performance Tuning
- Asynchronous Programming
- Database Application Development

---

# Learning Outcome

After completing this module, I gained practical knowledge of Entity Framework Core 8.0 and its integration with .NET 8. I learned how to configure EF Core, create database models using the Code-First approach, perform CRUD operations, write LINQ queries, manage database migrations, implement entity relationships, optimize query performance, and build efficient, scalable, and maintainable database-driven applications.

---

# Conclusion

Entity Framework Core 8.0 is a powerful and modern Object-Relational Mapper that simplifies database development in .NET applications. Its support for Code-First development, LINQ, migrations, asynchronous programming, relationship management, and performance optimization enables developers to build secure, scalable, and maintainable enterprise applications with minimal database complexity.
