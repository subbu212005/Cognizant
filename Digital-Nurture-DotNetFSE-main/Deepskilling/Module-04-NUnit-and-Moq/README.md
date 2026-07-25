# Module 4 - NUnit and Moq
# MoqDependencyInjectionDemo

## Overview

**MoqDependencyInjectionDemo** is a .NET 8 console application that demonstrates how to break external dependencies using **Dependency Injection (DI)** and the **Moq** mocking framework. The project shows how to write unit tests for classes that depend on external services such as email and logging without relying on actual implementations.

This project introduces loose coupling, constructor dependency injection, mock objects, interaction testing, and state-based testing using NUnit and Moq.

---

## Objectives

After completing this project, you will be able to:

- Understand the importance of loose coupling.
- Apply Dependency Injection (DI) in .NET applications.
- Use interfaces to reduce dependencies.
- Create mock objects using the Moq framework.
- Write NUnit tests for classes with external dependencies.
- Verify interactions between collaborating objects.
- Understand state-based and interaction-based testing.

---

## Technologies Used

- .NET 8
- C#
- NUnit
- Moq
- Microsoft.NET.Test.Sdk
- NUnit3TestAdapter
- Visual Studio 2022 / Visual Studio Code

---

## Project Structure

```text
MoqDependencyInjectionDemo
│
├── Interfaces
│   ├── IEmailService.cs
│   └── ILoggerService.cs
│
├── Models
│   └── User.cs
│
├── Services
│   ├── EmailService.cs
│   ├── LoggerService.cs
│   └── UserService.cs
│
├── Tests
│   ├── UserServiceTests.cs
│   ├── InteractionTests.cs
│   └── StateBasedTests.cs
│
├── Program.cs
└── MoqDependencyInjectionDemo.csproj
```

---

## Features

- Loose coupling through interfaces.
- Constructor Dependency Injection.
- Mock external services using Moq.
- Unit testing with NUnit.
- Verify method calls using `Verify()`.
- Demonstrate interaction testing.
- Demonstrate state-based testing.

---

## Dependency Injection

The `UserService` depends on abstractions instead of concrete implementations.

```csharp
public UserService(IEmailService emailService,
                   ILoggerService loggerService)
{
    _email = emailService;
    _logger = loggerService;
}
```

This makes the service easier to test because dependencies can be replaced with mock objects.

---

## Mocking with Moq

Example:

```csharp
var emailMock = new Mock<IEmailService>();
var loggerMock = new Mock<ILoggerService>();

var service = new UserService(
    emailMock.Object,
    loggerMock.Object);
```

---

## Verifying Interactions

Moq verifies whether dependency methods were called.

```csharp
emailMock.Verify(
    e => e.SendEmail(
        "alice@test.com",
        "Welcome",
        "Registration Successful"),
    Times.Once);
```

---

## State-Based Testing

State-based testing checks whether the application's state changes as expected after executing a method.

Example:

- Object created successfully.
- Values updated correctly.
- Collection contains expected items.

---

## Interaction Testing

Interaction testing verifies communication between objects.

Example:

- Logger is called once.
- Email service is called once.
- Repository save method is invoked.

---

## Running the Application

Restore packages:

```bash
dotnet restore
```

Build the project:

```bash
dotnet build
```

Run the application:

```bash
dotnet run
```

Run unit tests:

```bash
dotnet test
```

---

## Sample Console Output

```text
LOG: Registering Alice
Email sent to alice@test.com
```

---

## Sample Unit Test

```csharp
[Test]
public void Register_CallsServices()
{
    var email = new Mock<IEmailService>();
    var logger = new Mock<ILoggerService>();

    var service = new UserService(
        email.Object,
        logger.Object);

    service.Register(
        new User
        {
            Name = "Alice",
            Email = "alice@test.com"
        });

    email.Verify(
        e => e.SendEmail(
            "alice@test.com",
            "Welcome",
            "Registration Successful"),
        Times.Once);

    logger.Verify(
        l => l.Log(It.IsAny<string>()),
        Times.Once);
}
```

---

## Expected Output

Application Output

```text
LOG: Registering Alice
Email sent to alice@test.com
```

NUnit Output

```text
Passed! All tests passed.
```

---

## Best Practices

- Depend on interfaces instead of concrete classes.
- Use constructor injection for required dependencies.
- Mock external services during unit testing.
- Verify important interactions.
- Keep business logic independent of infrastructure.
- Write isolated and repeatable tests.

---

## Learning Outcomes

After completing this project, you will be able to:

- Apply Dependency Injection in .NET applications.
- Design loosely coupled systems.
- Create mock objects using Moq.
- Test services with external dependencies.
- Verify interactions between collaborating objects.
- Build reliable and maintainable unit tests.

---

## References

- https://docs.nunit.org/
- https://github.com/devlooped/moq
- https://learn.microsoft.com/dotnet/core/testing/
- https://learn.microsoft.com/dotnet/core/extensions/dependency-injection

---

**Author:** Cognizant Digital Nurture 4.0 – .NET Full Stack Engineer Learning Program
