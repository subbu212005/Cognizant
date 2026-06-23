# Breaking External Dependencies

## Introduction

Applications often depend on external resources such as databases, web services, file systems, and third-party APIs. These dependencies make unit testing difficult because tests become slow, unreliable, and difficult to maintain.

Breaking external dependencies helps create loosely coupled and testable code.

---

## Loosely Coupled and Testable Code

Loosely coupled code minimizes dependencies between components.

### Benefits

* Easier testing
* Better maintainability
* Improved flexibility
* Simplified code changes

### Example

Instead of directly creating objects inside a class, dependencies should be injected from outside.

---

## Refactoring Towards a Loosely Coupled Design

### Tightly Coupled Design

```csharp
public class OrderService
{
    private EmailService emailService =
        new EmailService();
}
```

### Loosely Coupled Design

```csharp
public class OrderService
{
    private readonly IEmailService emailService;

    public OrderService(
        IEmailService emailService)
    {
        this.emailService = emailService;
    }
}
```

---

## Dependency Injection

Dependency Injection (DI) is a design pattern used to provide dependencies from external sources instead of creating them internally.

---

## Dependency Injection via Method Parameters

```csharp
public void SendNotification(
    IEmailService emailService)
{
    emailService.Send();
}
```

### Benefits

* Simple implementation
* Easy testing

---

## Dependency Injection via Properties

```csharp
public IEmailService EmailService
{
    get;
    set;
}
```

### Benefits

* Flexible configuration
* Runtime replacement

---

## Dependency Injection via Constructor

```csharp
public class NotificationService
{
    private readonly IEmailService emailService;

    public NotificationService(
        IEmailService emailService)
    {
        this.emailService = emailService;
    }
}
```

### Benefits

* Most commonly used
* Enforces required dependencies
* Improves maintainability

---

## Dependency Injection Frameworks

Popular .NET Dependency Injection Frameworks:

* Microsoft Dependency Injection
* Autofac
* Ninject
* Unity

---

## Mocking Frameworks

Mocking frameworks create fake objects for testing.

### Benefits

* Isolate dependencies
* Faster tests
* Reliable results
* No external resource requirement

Popular Frameworks:

* Moq
* NSubstitute
* FakeItEasy

---

## Creating Mock Objects Using Moq

### Example

```csharp
using Moq;

var mockEmailService =
    new Mock<IEmailService>();

mockEmailService
    .Setup(x => x.Send())
    .Returns(true);
```

---

## State-Based Testing

State-based testing verifies the final state of an object after execution.

### Example

```csharp
Assert.AreEqual(
    "Completed",
    order.Status);
```

---

## Interaction Testing

Interaction testing verifies communication between objects.

### Example

```csharp
mockEmailService.Verify(
    x => x.Send(),
    Times.Once);
```

---

## Testing the Interaction Between Two Objects

```csharp
[Test]
public void PlaceOrder_ShouldSendEmail()
{
    var mockEmailService =
        new Mock<IEmailService>();

    var orderService =
        new OrderService(
            mockEmailService.Object);

    orderService.PlaceOrder();

    mockEmailService.Verify(
        x => x.Send(),
        Times.Once);
}
```

---

## Learning Outcome

After completing this topic, I understood dependency injection techniques, mocking frameworks, Moq usage, state-based testing, interaction testing, and how to create loosely coupled and testable applications.

---

## Conclusion

Breaking external dependencies improves software quality by enabling reliable, fast, and maintainable unit tests. Dependency Injection and Moq are essential tools for achieving testable application design.

