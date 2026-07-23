# SharedLibrary

## Overview

**SharedLibrary** is a reusable Class Library developed as part of the **Cognizant Digital Nurture 5.0 – Module 07: Microservices Architecture**.

The library contains common classes, Data Transfer Objects (DTOs), interfaces, and shared utilities that can be referenced by multiple microservices such as **ProductService** and **OrderService**. Using a shared library reduces code duplication, improves maintainability, and ensures consistency across the application.

---

## Objectives

- Create reusable components for multiple microservices.
- Share common models and DTOs.
- Define common interfaces.
- Promote code reusability and maintainability.
- Reduce duplicate code across services.

---

## Technologies Used

- .NET 8 Class Library
- C#
- Visual Studio 2022
- ASP.NET Core Compatible

---

## Project Structure

```
SharedLibrary/
│── Common/
│     └── (Shared utility classes)
│
│── DTOs/
│     └── (Data Transfer Objects)
│
│── Interfaces/
│     └── (Common interfaces)
│
│── bin/
│── obj/
│
│── SharedLibrary.csproj
│── README.md
```

---

## Components

### Common

The **Common** folder contains reusable helper classes and shared constants that can be accessed by multiple services.

Examples include:

- Utility classes
- Shared constants
- Common helper methods
- Base classes

---

### DTOs (Data Transfer Objects)

The **DTOs** folder contains objects used for transferring data between microservices without exposing internal models.

Benefits include:

- Lightweight data exchange
- Improved security
- Loose coupling
- Better API design

---

### Interfaces

The **Interfaces** folder defines contracts that can be implemented by different services.

Benefits include:

- Consistent implementation
- Dependency Injection support
- Loose coupling
- Easier unit testing

---

## Advantages of Shared Library

- Eliminates duplicate code.
- Improves project maintainability.
- Encourages modular architecture.
- Provides reusable components.
- Simplifies communication between services.
- Ensures consistency across microservices.

---

## Building the Project

### Restore Packages

```bash
dotnet restore
```

---

### Build the Library

```bash
dotnet build
```

---

### Add Reference in Another Project

```bash
dotnet add reference ../SharedLibrary/SharedLibrary.csproj
```

---

## Usage

Once referenced, any microservice can use the shared components.

Example:

```csharp
using SharedLibrary.DTOs;
using SharedLibrary.Interfaces;
using SharedLibrary.Common;
```

---

## Learning Outcomes

After completing this project, you will be able to:

- Create reusable .NET Class Libraries.
- Share DTOs across multiple microservices.
- Design common interfaces for services.
- Improve code organization and maintainability.
- Reduce redundancy in distributed applications.
- Apply best practices for modular software development.

---

## Conclusion

The **SharedLibrary** project serves as a centralized repository for reusable components used by multiple microservices. By sharing common DTOs, interfaces, and utility classes, it improves maintainability, consistency, and scalability while supporting a clean and modular microservices architecture.
