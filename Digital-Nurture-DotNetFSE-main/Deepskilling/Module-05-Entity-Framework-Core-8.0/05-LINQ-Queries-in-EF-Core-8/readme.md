# LINQ Queries in EF Core 8

## Introduction

Language Integrated Query (LINQ) is a powerful feature in C# that enables developers to query collections and databases using strongly typed syntax. In Entity Framework Core 8, LINQ queries are automatically translated into SQL statements, making data retrieval simple, efficient, and type-safe.

This topic covers filtering, selecting, ordering, projecting data into DTOs, aggregating data, and executing asynchronous queries.

---

## Writing Queries Using Where()

The `Where()` method filters records based on a specified condition.

### Example

```csharp
var students = await context.Students
    .Where(s => s.Age > 18)
    .ToListAsync();
```

---

## Writing Queries Using Select()

The `Select()` method retrieves only the required columns instead of the entire entity.

### Example

```csharp
var studentNames = await context.Students
    .Select(s => s.Name)
    .ToListAsync();
```

---

## Writing Queries Using OrderBy()

The `OrderBy()` method sorts data in ascending order.

### Example

```csharp
var students = await context.Students
    .OrderBy(s => s.Name)
    .ToListAsync();
```

For descending order:

```csharp
var students = await context.Students
    .OrderByDescending(s => s.Age)
    .ToListAsync();
```

---

## Projection into DTOs (Data Transfer Objects)

DTOs are used to transfer only the required data between layers of an application.

### Example

```csharp
public class StudentDTO
{
    public string Name { get; set; }

    public int Age { get; set; }
}
```

Projecting data into a DTO:

```csharp
var students = await context.Students
    .Select(s => new StudentDTO
    {
        Name = s.Name,
        Age = s.Age
    })
    .ToListAsync();
```

---

## Filtering and Aggregating Data

Entity Framework Core supports aggregate functions such as `Count()`, `Sum()`, `Average()`, `Max()`, and `Min()`.

### Count Example

```csharp
int totalStudents = await context.Students.CountAsync();
```

### Average Example

```csharp
double averageAge = await context.Students
    .AverageAsync(s => s.Age);
```

### Sum Example

```csharp
decimal totalFees = await context.Students
    .SumAsync(s => s.Fees);
```

---

## Asynchronous Queries with ToListAsync()

`ToListAsync()` retrieves data asynchronously, improving application responsiveness.

### Example

```csharp
var students = await context.Students.ToListAsync();
```

---

## Advantages of LINQ in EF Core

* Strongly typed queries
* Automatic SQL generation
* Improved readability
* Compile-time error checking
* Better performance with asynchronous execution
* Easy filtering, sorting, and projection

---

## Learning Outcome

After completing this topic, I learned how to write LINQ queries in Entity Framework Core 8 using `Where()`, `Select()`, `OrderBy()`, projection into DTOs, aggregate functions, and asynchronous methods like `ToListAsync()` for efficient data retrieval.

---

## Conclusion

LINQ simplifies database querying in Entity Framework Core by allowing developers to use C# syntax instead of SQL. It improves code readability, maintainability, and performance while providing powerful data filtering, sorting, and aggregation capabilities.

