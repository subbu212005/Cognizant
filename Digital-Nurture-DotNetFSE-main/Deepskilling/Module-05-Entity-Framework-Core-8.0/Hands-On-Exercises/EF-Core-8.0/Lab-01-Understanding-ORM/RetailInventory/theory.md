# Theory

## Object Relational Mapping (ORM)

ORM is a programming technique that connects object-oriented applications with relational databases.

Instead of writing SQL manually, developers manipulate objects.

Example:

```csharp
Product product = new Product();
product.Name = "Laptop";
```

EF Core converts it into

```sql
INSERT INTO Products(Name)
VALUES('Laptop');
```

---

## Why ORM?

- Easy maintenance
- Less coding
- Automatic CRUD operations
- Better security
- Supports LINQ

---

## Entity Framework Core

Entity Framework Core is Microsoft's modern ORM framework.

It supports

- SQL Server
- SQLite
- PostgreSQL
- MySQL
- Oracle

---

## EF Core Architecture

```
Application

↓

Entity Framework Core

↓

SQL Server Database
```

---

## Workflow

1. Create Model Classes
2. Create DbContext
3. Add Migration
4. Update Database
5. Perform CRUD Operations

---

## Advantages

- Automatic SQL Generation
- Strongly Typed Queries
- Database Migration
- Change Tracking
- High Performance
