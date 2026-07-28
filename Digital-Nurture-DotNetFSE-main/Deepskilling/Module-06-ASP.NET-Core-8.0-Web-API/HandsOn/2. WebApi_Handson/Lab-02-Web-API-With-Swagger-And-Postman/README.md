# Lab 2: Web API using .NET Core with Swagger and Postman

## Objective

This hands-on demonstrates how to integrate Swagger with an ASP.NET Core Web API, test APIs using Swagger UI and Postman, and customize API routes using Route attributes.

---

# Learning Objectives

After completing this lab, you will be able to:

- Install Swagger in ASP.NET Core Web API.
- Configure Swagger middleware.
- Use Swagger UI to test Web APIs.
- Test APIs using Postman.
- Understand Route attributes.
- Modify API routes.
- Understand ActionName attribute.
- Perform CRUD API testing.

---

# Software Requirements

- Visual Studio 2022
- .NET 8 SDK
- ASP.NET Core Web API
- Swashbuckle.AspNetCore
- Postman

---

# What is Swagger?

Swagger is an API documentation and testing tool that automatically generates interactive API documentation.

Advantages

- Interactive API documentation
- Built-in API testing
- Easy debugging
- JSON request and response visualization

---

# Installing Swagger

Install NuGet Package

```

Swashbuckle.AspNetCore

```

---

# Configure Swagger

Program.cs

```csharp
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
```

```csharp
app.UseSwagger();

app.UseSwaggerUI();
```

---

# Swagger URL

```

https://localhost:5001/swagger

```

---

# Using Swagger

1. Run the application.
2. Open Swagger UI.
3. Expand Employee Controller.
4. Click **Try it out**.
5. Click **Execute**.
6. View JSON response.

---

# Using Postman

Steps

1. Open Postman.
2. Create GET request.
3. URL

```

https://localhost:5001/api/employee

```

4. Click Send.
5. Verify

- Status Code
- Response Body
- Headers

---

# Route Attribute

Example

```csharp
[Route("api/Emp")]
```

Endpoint

```

https://localhost:5001/api/Emp

```

---

# ActionName Attribute

Example

```csharp
[ActionName("GetEmployees")]
```

Provides meaningful action names.

---

# Expected Output

Swagger displays

- Employee Controller
- GET
- POST
- PUT
- DELETE

Postman returns

```json
[
    {
        "id":1,
        "name":"Pramod",
        "department":"IT"
    },
    {
        "id":2,
        "name":"Rahul",
        "department":"HR"
    }
]
```

Status

```

200 OK

```

---

# Conclusion

Successfully configured Swagger, tested APIs using Swagger UI and Postman, and modified API routes using Route attributes.