# Notes – Introduction to Microservices Architecture

## Definition

Microservices Architecture is a software design approach where an application is divided into multiple small, independent, and loosely coupled services. Each service performs a specific business function and communicates with other services through lightweight protocols such as HTTP, REST APIs, gRPC, or messaging systems.

---

## Key Characteristics

* Small and independent services
* Loosely coupled architecture
* Single Responsibility Principle (SRP)
* Independent deployment
* Independent scalability
* Database per service
* API-based communication
* Fault isolation
* Technology independence
* CI/CD support

---

## Advantages

* Independent deployment
* Better scalability
* Faster development
* Easy maintenance
* Fault isolation
* Technology flexibility
* Continuous delivery
* Improved reliability

---

## Challenges

* Distributed system complexity
* Network communication overhead
* Data consistency
* Service discovery
* Monitoring and logging
* Security management
* Deployment complexity
* Higher infrastructure cost

---

## Microservices vs Monolithic

| Monolithic                              | Microservices                     |
| --------------------------------------- | --------------------------------- |
| Single application                      | Multiple independent services     |
| Single deployment                       | Independent deployment            |
| Shared database                         | Database per service              |
| Tightly coupled                         | Loosely coupled                   |
| Difficult to scale                      | Easy to scale individual services |
| Entire application affected by failures | Failure isolated to one service   |

---

## Common Communication Methods

* REST API (HTTP)
* gRPC
* Message Queues (RabbitMQ, Kafka)
* Event-driven communication

---

## ASP.NET Core Features for Microservices

* High-performance Web API
* Cross-platform support
* Built-in Dependency Injection
* Middleware pipeline
* Swagger/OpenAPI
* JWT Authentication
* Docker support
* Kubernetes support
* Cloud-native architecture

---

## Basic Project Structure

```text
ProductService
│
├── Controllers
├── Models
├── Data
├── Services
├── Properties
├── appsettings.json
├── Program.cs
└── ProductService.csproj
```

---

## Basic Program.cs Configuration

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
```

---

## Best Practices

* Design services around business capabilities.
* Keep services small and focused.
* Use independent databases.
* Secure APIs with JWT or OAuth.
* Implement API versioning.
* Use centralized logging and monitoring.
* Containerize applications with Docker.
* Deploy using Kubernetes.
* Implement health checks.
* Automate deployments using CI/CD.

---

## Learning Outcome

* Understood the fundamentals of Microservices Architecture.
* Learned the differences between Monolithic and Microservices architectures.
* Studied the advantages and challenges of Microservices.
* Learned how to create an ASP.NET Core Web API project.
* Explored the best practices for building scalable and maintainable microservices.

---

## Summary

Microservices Architecture enables applications to be developed as independent, loosely coupled services that are easier to develop, deploy, maintain, and scale. ASP.NET Core Web API provides a robust platform for building secure, high-performance, and cloud-ready microservices.
