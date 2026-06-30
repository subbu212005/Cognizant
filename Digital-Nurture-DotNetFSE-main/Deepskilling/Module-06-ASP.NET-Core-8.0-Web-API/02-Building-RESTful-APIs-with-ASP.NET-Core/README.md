# Building RESTful APIs with ASP.NET Core

## Introduction

RESTful APIs allow applications to communicate using HTTP protocols and standard HTTP methods. ASP.NET Core Web API provides controllers, routing, model binding, and Entity Framework Core integration to build secure and scalable REST APIs.

This topic explains controllers, actions, routing, CRUD operations, and JSON serialization.

---

## Controllers

Controllers handle incoming HTTP requests and return appropriate responses.

Example:

```csharp
[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
}
```

---

## Actions

Actions are methods inside a controller that respond to HTTP requests.

Example:

```csharp
[HttpGet]
public IActionResult GetStudents()
{
    return Ok();
}
```

---

## Routing

Routing maps incoming URLs to controller actions.

### Conventional Routing

```csharp
[Route("api/[controller]")]
```

### Attribute Routing

```csharp
[HttpGet("{id}")]
```

Example URL

```
GET /api/students/1
```

---

## CRUD Operations

### GET

Retrieve records.

```csharp
[HttpGet]
public async Task<IActionResult> GetStudents()
{
    return Ok(await _context.Students.ToListAsync());
}
```

---

### POST

Insert a new record.

```csharp
[HttpPost]
public async Task<IActionResult> AddStudent(Student student)
{
    _context.Students.Add(student);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetStudents), new { id = student.Id }, student);
}
```

---

### PUT

Update an existing record.

```csharp
[HttpPut("{id}")]
public async Task<IActionResult> UpdateStudent(int id, Student student)
{
    _context.Entry(student).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
}
```

---

### DELETE

Delete a record.

```csharp
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteStudent(int id)
{
    var student = await _context.Students.FindAsync(id);

    _context.Students.Remove(student);

    await _context.SaveChangesAsync();

    return NoContent();
}
```

---

## Entity Framework Core Integration

Entity Framework Core enables interaction with SQL Server using DbContext.

```csharp
public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}
```

---

## JSON Formatting and Serialization

ASP.NET Core automatically serializes C# objects into JSON.

Example Response

```json
{
  "id": 1,
  "name": "John",
  "age": 20
}
```

---

## Advantages

- RESTful architecture
- Easy CRUD implementation
- Automatic JSON serialization
- Entity Framework Core integration
- Clean controller-based design

---

## Learning Outcome

After completing this topic, I learned how to build RESTful APIs using controllers, routing, CRUD operations, Entity Framework Core, and JSON serialization.

---

## Conclusion

ASP.NET Core Web API simplifies REST API development by providing built-in support for routing, controllers, Entity Framework Core, and JSON serialization.
