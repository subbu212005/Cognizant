# Advanced API Features

## Introduction

ASP.NET Core Web API provides advanced features such as attribute routing, query parameters, middleware, filters, and JWT authentication to build secure and scalable APIs.

---

## Attribute Routing

Attribute routing allows defining routes directly on controller actions.

```csharp
[HttpGet("{id}")]
public IActionResult GetStudent(int id)
{
    return Ok();
}
```

---

## Query Parameters

Query parameters allow filtering or passing additional values.

Example

```
GET /api/students?age=20
```

Controller

```csharp
[HttpGet]
public IActionResult GetStudents(int age)
{
    return Ok();
}
```

---

## Middleware

Middleware processes HTTP requests and responses.

Example

```csharp
app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();
```

---

## Filters

Filters execute code before or after controller actions.

Types

- Authorization Filters
- Action Filters
- Exception Filters
- Result Filters

---

## JWT Authentication

JSON Web Tokens (JWT) secure Web APIs by authenticating users.

Workflow

1. User Login
2. Generate JWT Token
3. Client stores Token
4. Client sends Token with requests
5. Server validates Token

Example

```csharp
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer();
```

---

## Authorization

Protect endpoints using the Authorize attribute.

```csharp
[Authorize]
public IActionResult GetProfile()
{
    return Ok();
}
```

---

## Advantages

- Secure APIs
- Flexible routing
- Middleware pipeline
- Easy authentication
- Better request processing

---

## Learning Outcome

After completing this topic, I learned attribute routing, query parameters, middleware, filters, JWT authentication, and authorization in ASP.NET Core Web API.

---

## Conclusion

Advanced API features improve API security, flexibility, and maintainability while providing better control over request processing.
