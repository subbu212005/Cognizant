# Performing Basic CRUD Operations

## Introduction

CRUD stands for **Create, Read, Update, and Delete**, the four fundamental operations performed on database records. Entity Framework Core simplifies these operations by allowing developers to interact with the database using C# objects instead of writing SQL queries.

This topic demonstrates how to insert, retrieve, update, and delete data using Entity Framework Core 8.

---

## Create (Insert Records)

The `AddAsync()` method is used to add a new entity to the database asynchronously.

### Example

```csharp
var student = new Student
{
    Name = "John",
    Age = 20
};

await context.Students.AddAsync(student);
await context.SaveChangesAsync();
```

---

## Read (Retrieve Records)

Entity Framework Core provides several methods to retrieve data.

### Find()

Retrieves a record using its primary key.

```csharp
var student = await context.Students.FindAsync(1);
```

### FirstOrDefault()

Returns the first matching record or `null` if no record exists.

```csharp
var student = await context.Students
    .FirstOrDefaultAsync(s => s.Name == "John");
```

### ToListAsync()

Retrieves all records from a table.

```csharp
var students = await context.Students.ToListAsync();
```

---

## Update Records

To update a record, retrieve the entity, modify its properties, and save the changes.

### Example

```csharp
var student = await context.Students.FindAsync(1);

student.Age = 21;

await context.SaveChangesAsync();
```

Entity Framework Core automatically tracks changes and updates only the modified fields.

---

## Delete Records

### Remove()

Deletes a single record.

```csharp
var student = await context.Students.FindAsync(1);

context.Students.Remove(student);

await context.SaveChangesAsync();
```

---

### RemoveRange()

Deletes multiple records at once.

```csharp
var students = await context.Students
    .Where(s => s.Age < 18)
    .ToListAsync();

context.Students.RemoveRange(students);

await context.SaveChangesAsync();
```

---

## SaveChangesAsync()

After performing Create, Update, or Delete operations, changes must be committed using:

```csharp
await context.SaveChangesAsync();
```

---

## Advantages of CRUD Operations in EF Core

* Less SQL code
* Automatic change tracking
* Asynchronous database operations
* Better performance
* Strong type safety
* Improved maintainability

---

## Learning Outcome

After completing this topic, I learned how to perform Create, Read, Update, and Delete (CRUD) operations using Entity Framework Core 8 with methods such as `AddAsync()`, `FindAsync()`, `FirstOrDefaultAsync()`, `ToListAsync()`, `Remove()`, `RemoveRange()`, and `SaveChangesAsync()`.

---

## Conclusion

Entity Framework Core simplifies CRUD operations by enabling developers to work with C# objects instead of SQL queries. Its built-in change tracking, asynchronous methods, and LINQ support improve productivity and make database operations more efficient.

