# EF Core Migrations and Database Updates

## Introduction

Entity Framework Core Migrations provide a way to manage and apply database schema changes while preserving existing data. Migrations enable developers to evolve the database structure as the application's data model changes.

This topic covers creating, removing, and updating migrations, seeding initial data, and managing database schema changes using Entity Framework Core 8.

---

## What are Migrations?

A migration is a set of instructions that describes changes to the database schema based on modifications made to entity classes.

Migrations help:

* Create databases automatically.
* Update database schema.
* Preserve existing data.
* Track schema changes.
* Simplify database version control.

---

## Adding a Migration

A migration is created whenever the entity model changes.

### Command

```bash
dotnet ef migrations add InitialCreate
```

This command creates a migration file containing the SQL operations required to create or modify the database.

---

## Updating the Database

Apply pending migrations to the database.

### Command

```bash
dotnet ef database update
```

This command creates or updates the database according to the latest migration.

---

## Removing a Migration

If the latest migration has not yet been applied, it can be removed.

### Command

```bash
dotnet ef migrations remove
```

---

## Listing Migrations

Display all available migrations in the project.

### Command

```bash
dotnet ef migrations list
```

---

## Seeding Data During Migrations

Entity Framework Core allows initial data to be inserted automatically using the `HasData()` method.

### Example

```csharp
modelBuilder.Entity<Student>().HasData(

    new Student
    {
        StudentId = 1,
        Name = "John",
        Age = 20
    },

    new Student
    {
        StudentId = 2,
        Name = "Alice",
        Age = 22
    }

);
```

When a migration is applied, these records are automatically inserted into the database.

---

## Managing Database Schema Changes

Whenever entity classes are modified:

1. Update the entity class.
2. Add a new migration.

```bash
dotnet ef migrations add AddCourseTable
```

3. Update the database.

```bash
dotnet ef database update
```

Entity Framework Core automatically applies the required schema changes.

---

## Advantages of EF Core Migrations

* Automatic database creation
* Version-controlled schema changes
* Easy rollback and updates
* Data preservation
* Simplified deployment
* Supports Code-First development

---

## Best Practices

* Create small, meaningful migrations.
* Review generated migration files before applying them.
* Keep migrations under source control.
* Test migrations before deploying to production.
* Seed only essential initial data.

---

## Learning Outcome

After completing this topic, I learned how to create, remove, and apply Entity Framework Core migrations, seed initial data, and manage database schema changes efficiently using Code-First development.

---

## Conclusion

Entity Framework Core Migrations simplify database evolution by automatically generating and applying schema changes. They provide a reliable and maintainable approach to keeping the database synchronized with application models throughout the development lifecycle.

