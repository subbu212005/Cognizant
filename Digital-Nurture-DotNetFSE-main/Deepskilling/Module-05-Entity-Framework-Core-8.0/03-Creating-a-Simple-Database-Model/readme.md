# Creating a Simple Database Model

## Introduction

A database model defines the structure of a database using entities, relationships, and constraints. In Entity Framework Core, developers use the **Code-First** approach to create database models directly from C# classes.

This topic explains how to define entities, configure relationships, use primary and foreign keys, and implement navigation properties.

---

## Defining Entities

An entity represents a database table. Each entity is defined as a C# class, and each property represents a column in the table.

### Example

```csharp
public class Student
{
    public int StudentId { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }
}
```

---

## Defining Relationships

Relationships describe how entities are connected.

### Common Relationship Types

* One-to-One
* One-to-Many
* Many-to-Many

### Example (One-to-Many)

```csharp
public class Student
{
    public int StudentId { get; set; }

    public string Name { get; set; }

    public ICollection<Course> Courses { get; set; }
}

public class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; }

    public int StudentId { get; set; }

    public Student Student { get; set; }
}
```

---

## Primary Keys

A Primary Key uniquely identifies each record in a table.

Example:

```csharp
public int StudentId { get; set; }
```

By convention, Entity Framework Core automatically treats properties named **Id** or **<EntityName>Id** as primary keys.

---

## Foreign Keys

A Foreign Key creates a relationship between two tables.

Example:

```csharp
public int StudentId { get; set; }
```

The `StudentId` property in the `Course` entity references the `Student` entity.

---

## Navigation Properties

Navigation properties allow one entity to access related entities.

Example:

```csharp
public Student Student { get; set; }

public ICollection<Course> Courses { get; set; }
```

These properties simplify querying and loading related data.

---

## Code-First Approach Overview

The Code-First approach allows developers to create the database schema from C# classes.

### Steps

1. Create entity classes.
2. Create the `DbContext` class.
3. Configure the database connection.
4. Add a migration.

```bash
dotnet ef migrations add InitialCreate
```

5. Update the database.

```bash
dotnet ef database update
```

Entity Framework Core automatically creates the database tables based on the entity classes.

---

## Advantages of Code-First

* Database generated from C# classes
* Easy to modify models
* Supports automatic migrations
* Strong type safety
* Better maintainability
* Faster development

---

## Learning Outcome

After completing this topic, I learned how to define entities, configure relationships, use primary keys, foreign keys, and navigation properties, and create a database using the Entity Framework Core Code-First approach.

---

## Conclusion

Creating a simple database model is the foundation of Entity Framework Core development. The Code-First approach enables developers to design databases using C# classes while EF Core automatically generates and maintains the database schema.

