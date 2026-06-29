# Handling Relationships and Data Loading

## Introduction

Entity Framework Core provides powerful features to define relationships between entities and efficiently load related data. Relationships are established using navigation properties, primary keys, and foreign keys. EF Core also supports multiple data loading strategies, including Eager Loading, Lazy Loading, and Explicit Loading.

This topic explains relationship types, loading strategies, and handling circular references in Entity Framework Core 8.

---

## Entity Relationships

Relationships define how entities are connected within a database.

### Types of Relationships

* One-to-One
* One-to-Many
* Many-to-Many

---

## One-to-One Relationship

Each record in one table is associated with exactly one record in another table.

### Example

```csharp
public class Person
{
    public int PersonId { get; set; }

    public string Name { get; set; }

    public Passport Passport { get; set; }
}

public class Passport
{
    public int PassportId { get; set; }

    public string PassportNumber { get; set; }

    public int PersonId { get; set; }

    public Person Person { get; set; }
}
```

---

## One-to-Many Relationship

One parent record can have multiple child records.

### Example

```csharp
public class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; }

    public ICollection<Employee> Employees { get; set; }
}

public class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; }

    public int DepartmentId { get; set; }

    public Department Department { get; set; }
}
```

---

## Many-to-Many Relationship

Multiple records from one table are related to multiple records in another table.

### Example

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

    public ICollection<Student> Students { get; set; }
}
```

---

# Data Loading Techniques

## Eager Loading

Loads related entities together with the main entity using the `Include()` method.

### Example

```csharp
var departments = await context.Departments
    .Include(d => d.Employees)
    .ToListAsync();
```

### Advantages

* Fewer database queries
* Better performance when related data is always required

---

## Lazy Loading

Loads related entities only when they are accessed for the first time.

### Example

```csharp
var department = context.Departments.First();

var employees = department.Employees;
```

### Advantages

* Reduces initial data retrieval
* Loads data only when required

---

## Explicit Loading

Loads related entities manually after the main entity has been retrieved.

### Example

```csharp
var department = await context.Departments.FirstAsync();

await context.Entry(department)
             .Collection(d => d.Employees)
             .LoadAsync();
```

### Advantages

* Greater control over database queries
* Loads related data only when needed

---

## Navigation Properties

Navigation properties allow one entity to reference related entities.

### Example

```csharp
public Department Department { get; set; }

public ICollection<Employee> Employees { get; set; }
```

---

## Handling Circular References

Circular references occur when two entities reference each other, which can cause serialization issues.

### Solutions

* Use Data Transfer Objects (DTOs)
* Disable lazy loading when appropriate
* Configure JSON serialization using `ReferenceHandler.IgnoreCycles`

---

## Best Practices

* Use Eager Loading for frequently accessed related data.
* Use Explicit Loading when greater control is required.
* Avoid excessive Lazy Loading to reduce unnecessary database queries.
* Use DTOs to prevent circular reference issues.
* Configure relationships using Fluent API when needed.

---

## Learning Outcome

After completing this topic, I learned how to configure One-to-One, One-to-Many, and Many-to-Many relationships in Entity Framework Core 8, use Eager, Lazy, and Explicit Loading strategies, and handle circular references effectively.

---

## Conclusion

Entity relationships and data loading strategies are essential for building efficient database applications. Choosing the appropriate loading technique improves application performance, reduces unnecessary database operations, and simplifies data management in Entity Framework Core.


