# Introduction to Web APIs and ASP.NET Core

## Introduction

ASP.NET Core Web API is a lightweight, cross-platform framework developed by Microsoft for building RESTful web services. Web APIs enable communication between different software applications over the HTTP protocol and exchange data in formats such as JSON or XML.

ASP.NET Core 8.0 provides improved performance, security, scalability, and cloud integration, making it ideal for developing modern web services and microservices.

---

## What is a Web API?

A Web API (Application Programming Interface) is an interface that allows different applications to communicate with each other over the internet using the HTTP protocol.

Web APIs expose data and functionality through endpoints that can be accessed by clients such as:

- Web applications
- Mobile applications
- Desktop applications
- IoT devices
- Other APIs

### Advantages of Web APIs

- Platform independent
- Lightweight communication
- Easy integration
- Supports multiple clients
- High scalability
- Faster development

---

## REST vs SOAP

REST (Representational State Transfer) and SOAP (Simple Object Access Protocol) are two common approaches for building web services.

| REST | SOAP |
|------|------|
| Architectural style | Communication protocol |
| Uses HTTP | Can use HTTP, SMTP, TCP |
| Lightweight | Heavyweight |
| Faster | Slower |
| Uses JSON or XML | Uses XML only |
| Stateless | Can be Stateful or Stateless |
| Easier to develop | More complex |
| Better for Web APIs | Better for enterprise services |

---

## Setting up .NET 8 Development Environment

To develop ASP.NET Core Web APIs, install the following tools.

### Required Software

- Visual Studio 2022
- .NET 8 SDK
- ASP.NET Core Runtime
- SQL Server
- SQL Server Management Studio (SSMS)
- Postman (for API testing)

Verify the installation using:

```bash
dotnet --version
```

Example Output

```text
8.0.xxx
```

---

## Creating an ASP.NET Core Web API Project

Create a new project using the .NET CLI.

```bash
dotnet new webapi -n StudentApi
```

Navigate to the project folder.

```bash
cd StudentApi
```

Run the application.

```bash
dotnet run
```

By default, the API will run on:

```text
https://localhost:7xxx
```

---

## ASP.NET Core Web API Project Structure

A typical ASP.NET Core Web API project contains the following folders and files.

```text
StudentApi
│
├── Controllers
├── Models
├── Data
├── Services
├── Properties
├── appsettings.json
├── Program.cs
└── StudentApi.csproj
```

### Controllers

Contains API controllers that handle HTTP requests and responses.

Example:

```text
StudentController.cs
```

---

### Models

Contains entity classes representing application data.

Example:

```text
Student.cs
```

---

### Data

Contains the `DbContext` class and database configuration.

Example:

```text
AppDbContext.cs
```

---

### Services

Contains business logic and reusable services.

Example:

```text
StudentService.cs
```

---

### appsettings.json

Stores application configuration such as database connection strings and logging settings.

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

---

### Program.cs

The entry point of the application where services and middleware are configured.

Example:

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
```

---

## Features of ASP.NET Core Web API

- Cross-platform support
- High performance
- RESTful architecture
- Built-in Dependency Injection
- Middleware pipeline
- Routing support
- Model validation
- JSON serialization
- Authentication and Authorization
- Swagger/OpenAPI integration

---

## Advantages of ASP.NET Core Web API

- Fast and lightweight
- Open-source
- Cloud-ready
- Easy integration with Entity Framework Core
- Secure and scalable
- Supports microservices architecture
- Excellent performance

---

## Learning Outcome

After completing this topic, I understood the fundamentals of Web APIs, the differences between REST and SOAP, how to set up the .NET 8 development environment, create an ASP.NET Core Web API project, and understand its project structure.

---

## Conclusion

ASP.NET Core Web API is a modern framework for building secure, scalable, and high-performance RESTful services. Its cross-platform capabilities, built-in dependency injection, middleware support, and seamless integration with .NET 8 make it an excellent choice for developing enterprise-grade backend applications.
