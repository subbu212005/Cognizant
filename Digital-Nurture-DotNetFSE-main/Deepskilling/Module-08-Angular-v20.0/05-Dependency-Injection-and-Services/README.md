# Module 05 – Dependency Injection and Services

## Overview

Dependency Injection (DI) is one of Angular's core features that enables components to receive dependencies such as services from Angular instead of creating them manually. Services help organize reusable business logic and data sharing across multiple components, making applications modular, maintainable, and easier to test.

This module introduces Angular's Dependency Injection framework, creating and using services, service injection, the `@Injectable()` decorator, and singleton services.

---

## Learning Objectives

After completing this module, you will be able to:

- Understand Dependency Injection in Angular.
- Create and use Angular services.
- Inject services into components.
- Use the `@Injectable()` decorator.
- Understand singleton services.
- Build modular and reusable Angular applications.

---

## Prerequisites

Before starting this module, ensure you have:

- Node.js installed
- Angular CLI installed
- Visual Studio Code
- Basic knowledge of Angular Components

---

## Folder Structure

```
Module-05-Dependency-Injection-and-Services
│
├── README.md
│
├── 01-Understanding-Dependency-Injection
│   ├── README.md
│   ├── Output.txt
│   └── Output.png
│
├── 02-Creating-and-Using-Services
│   ├── README.md
│   ├── Output.txt
│   └── Output.png
│
├── 03-Service-Injection
│   ├── README.md
│   ├── Output.txt
│   └── Output.png
│
├── 04-Injectable-Decorator
│   ├── README.md
│   ├── Output.txt
│   └── Output.png
│
└── 05-Singleton-Services
    ├── README.md
    ├── Output.txt
    └── Output.png
```

---

# Topics Covered

## 01 – Understanding Dependency Injection

### Concepts

- Introduction to Dependency Injection
- Constructor Injection
- Angular Injector
- Benefits of Dependency Injection

### Practical Exercise

- Create a service
- Inject the service into a component
- Display data returned from the service

---

## 02 – Creating and Using Services

### Concepts

- Angular Services
- Reusable Business Logic
- Data Sharing
- Service Methods

### Practical Exercise

- Create a Student Service
- Return student data
- Display data using `*ngFor`

---

## 03 – Service Injection

### Concepts

- Injecting Services
- Constructor Injection
- Accessing Service Methods
- Dependency Resolution

### Practical Exercise

- Inject StudentDataService
- Display college information
- Access methods from the service

---

## 04 – Injectable Decorator

### Concepts

- `@Injectable()`
- Dependency Injection Metadata
- `providedIn: 'root'`
- Root Injector

### Practical Exercise

- Create injectable service
- Register service using `providedIn`
- Inject service into component

---

## 05 – Singleton Services

### Concepts

- Singleton Pattern
- Root Injector
- Shared State
- Service Lifetime

### Practical Exercise

- Create counter service
- Share data using singleton service
- Update counter using button click

---

# Angular Concepts Learned

- Dependency Injection
- Angular Services
- Constructor Injection
- Root Injector
- Service Lifetime
- Reusable Business Logic
- Shared Data
- Singleton Pattern
- `@Injectable()`
- `providedIn: 'root'`

---

# Advantages of Dependency Injection

- Reduces coupling between classes.
- Promotes reusable code.
- Simplifies testing.
- Improves maintainability.
- Centralizes business logic.
- Supports modular application design.

---

# Advantages of Angular Services

- Share data between components.
- Store business logic separately.
- Reduce duplicate code.
- Improve scalability.
- Simplify application maintenance.

---

# Real-World Applications

- Authentication Service
- Login & Registration
- Product Management
- Student Management System
- Employee Portal
- Banking Applications
- E-Commerce Websites
- Hospital Management Systems

---

# Interview Questions

1. What is Dependency Injection?
2. Why is Dependency Injection important in Angular?
3. What is an Angular Service?
4. What is constructor injection?
5. What is the purpose of `@Injectable()`?
6. What does `providedIn: 'root'` mean?
7. What is a Singleton Service?
8. How do services improve code reusability?
9. What are the advantages of Angular services?
10. How does Angular create service instances?

---

# Skills Gained

After completing this module, you will be able to:

- Create Angular services.
- Use Dependency Injection effectively.
- Inject services into components.
- Share data between components.
- Implement singleton services.
- Build modular Angular applications.
- Organize reusable business logic.

---

# Summary

In this module, you learned Angular's Dependency Injection framework and how services are used to build modular applications. You created reusable services, injected them into components, explored the `@Injectable()` decorator, and understood how singleton services allow multiple components to share the same instance. These concepts form the foundation for scalable and maintainable Angular applications.

---

# Learning Outcome

After successfully completing this module, you can:

- Explain Dependency Injection.
- Create and inject Angular services.
- Use the `@Injectable()` decorator.
- Implement singleton services.
- Share data between components.
- Develop reusable and maintainable Angular applications.
