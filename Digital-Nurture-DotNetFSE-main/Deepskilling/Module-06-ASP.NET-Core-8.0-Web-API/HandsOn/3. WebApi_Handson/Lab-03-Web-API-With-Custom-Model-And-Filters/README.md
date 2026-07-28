# Lab 3: Web API with Custom Model, Filters, and Exception Handling

## Objective

This hands-on demonstrates how to create a custom model class, return custom objects from Web API methods, implement custom authorization filters, and handle exceptions using custom exception filters in ASP.NET Core Web API.

---

# Learning Objectives

After completing this lab, you will be able to:

- Create custom model classes.
- Return a list of custom objects from a Web API.
- Use the AllowAnonymous attribute.
- Read request data using the FromBody attribute.
- Implement custom authorization filters.
- Implement custom exception filters.
- Test APIs using Swagger.

---

# Software Requirements

- Visual Studio 2022
- .NET 8 SDK
- ASP.NET Core Web API
- Swashbuckle.AspNetCore
- Microsoft.AspNetCore.Mvc.WebApiCompatShim

---

# Custom Employee Model

Properties

- Id
- Name
- Salary
- Permanent
- Department
- Skills
- DateOfBirth

---

# Employee Controller

Features

- GET
- POST
- PUT
- Private GetStandardEmployeeList() method

---

# ProducesResponseType

```csharp
[ProducesResponseType(StatusCodes.Status200OK)]
```

```csharp
[ProducesResponseType(StatusCodes.Status500InternalServerError)]
```

---

# FromBody Attribute

Reads complex objects from the request body.

Example

```csharp
public IActionResult Post([FromBody] Employee employee)
```

---

# Custom Authorization Filter

Checks

- Authorization header exists.
- Bearer token exists.

Error Messages

```
Invalid request - No Auth token
```

```
Invalid request - Token present but Bearer unavailable
```

---

# Custom Exception Filter

Responsibilities

- Capture exceptions.
- Write logs to a file.
- Return Internal Server Error.

---

# Testing

Use Swagger

- GET
- POST
- PUT

Verify

- 200 OK
- 400 Bad Request
- 500 Internal Server Error

---

# Conclusion

Successfully created a custom Employee Web API, implemented authorization filters, exception filters, and verified API responses using Swagger.