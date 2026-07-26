# Design Patterns in C# (.NET 8)

## Overview

This repository contains the implementation of **11 Design Patterns** using **C# (.NET 8 Console Applications)**. Each exercise demonstrates a commonly used software design pattern with a real-world scenario, clean code, and sample output.

These implementations follow the Cognizant Digital Nurture 4.0 learning objectives and help understand how design patterns improve software maintainability, flexibility, and scalability.

---

## Technologies Used

- C#
- .NET 8 Console Application
- Visual Studio 2022 / Visual Studio Code

---

## Repository Structure

```
Design-Patterns/
│
├── README.md
│
├── Exercise 1 Implementing the Singleton Pattern
│   └── SingletonPatternExample
│
├── Exercise 2 Implementing the Factory Method Pattern
│   └── FactoryMethodPatternExample
│
├── Exercise 3 Implementing the Builder Pattern
│   └── BuilderPatternExample
│
├── Exercise 4 Implementing the Adapter Pattern
│   └── AdapterPatternExample
│
├── Exercise 5 Implementing the Decorator Pattern
│   └── DecoratorPatternExample
│
├── Exercise 6 Implementing the Proxy Pattern
│   └── ProxyPatternExample
│
├── Exercise 7 Implementing the Observer Pattern
│   └── ObserverPatternExample
│
├── Exercise 8 Implementing the Strategy Pattern
│   └── StrategyPatternExample
│
├── Exercise 9 Implementing the Command Pattern
│   └── CommandPatternExample
│
├── Exercise 10 Implementing the MVC Pattern
│   └── MVCPatternExample
│
└── Exercise 11 Implementing Dependency Injection
    └── DependencyInjectionExample
```

---

## Exercises Included

### Exercise 1 – Singleton Pattern

- Implemented a Logger class using the Singleton Pattern.
- Ensures only one instance of Logger exists.

---

### Exercise 2 – Factory Method Pattern

- Created different document types.
- Uses Factory Method for object creation.

---

### Exercise 3 – Builder Pattern

- Built different Computer configurations.
- Uses nested Builder class.

---

### Exercise 4 – Adapter Pattern

- Integrated multiple payment gateways.
- Adapter provides a common payment interface.

---

### Exercise 5 – Decorator Pattern

- Extended notification functionality dynamically.
- Added Email, SMS, and Slack notifications.

---

### Exercise 6 – Proxy Pattern

- Demonstrated lazy loading of images.
- Loads the real image only when required.

---

### Exercise 7 – Observer Pattern

- Implemented Stock Market notification system.
- Multiple observers receive stock updates.

---

### Exercise 8 – Strategy Pattern

- Selected payment methods at runtime.
- Supports Credit Card and PayPal strategies.

---

### Exercise 9 – Command Pattern

- Implemented Home Automation Remote Control.
- Commands encapsulate Light ON/OFF operations.

---

### Exercise 10 – MVC Pattern

- Implemented Student Management using MVC.
- Demonstrates interaction between Model, View, and Controller.

---

### Exercise 11 – Dependency Injection

- Used constructor injection.
- CustomerService depends on CustomerRepository abstraction.

---

## Design Patterns Covered

| Exercise | Pattern |
|-----------|---------|
| 1 | Singleton |
| 2 | Factory Method |
| 3 | Builder |
| 4 | Adapter |
| 5 | Decorator |
| 6 | Proxy |
| 7 | Observer |
| 8 | Strategy |
| 9 | Command |
| 10 | MVC |
| 11 | Dependency Injection |

---

## How to Run

Open the required project folder.

Restore dependencies:

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

---

## Learning Outcomes

After completing these exercises, you will be able to:

- Understand the purpose of Gang of Four (GoF) Design Patterns.
- Apply Creational, Structural, and Behavioral Design Patterns.
- Improve software maintainability and reusability.
- Reduce tight coupling using Dependency Injection.
- Build flexible and scalable applications using best practices.

---

## Author

**Y. Subrahmanyeswara**

B.Tech Cyber Security

Vignan University
