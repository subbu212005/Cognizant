# Using Services for State Management in Angular

## Overview

Angular Services provide a simple and effective way to share data between multiple components. Instead of storing the same data in different components, a shared service acts as a centralized source of state. Components can access and modify the shared data through Dependency Injection, ensuring that all components stay synchronized.

This exercise demonstrates how to use an Angular Service to manage shared state between components.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand Service-Based State Management.
- Create an Angular Service.
- Share data between components.
- Update shared state.
- Use Dependency Injection.
- Build reusable services.

---

## Prerequisites

Before starting this exercise, ensure you have:

- Angular CLI installed
- Basic knowledge of Angular Components
- Basic understanding of Angular Services
- Dependency Injection concepts

---

## What is Service-Based State Management?

Service-Based State Management stores shared data inside an Angular Service. Components access the service using Dependency Injection, allowing them to read and update the same data.

This approach is suitable for small and medium-sized Angular applications.

---

## Step 1

Generate a service.

```bash
ng generate service services/counter
```

---

## Step 2

Create a shared state.

```typescript
count = 0;
```

---

## Step 3

Create methods to update the state.

```typescript
increment() {
  this.count++;
}

getCount() {
  return this.count;
}
```

---

## Step 4

Use the service inside a component.

```typescript
constructor(private counterService: CounterService) {}

increase() {
  this.counterService.increment();
}
```

---

## Expected Output

```
Service-Based State Management

Counter : 0

[Increment]

↓

Counter : 1

↓

Counter : 2
```

---

## Advantages

- Centralized state.
- Reusable services.
- Easy component communication.
- Cleaner code.
- Better maintainability.

---

## Real-World Applications

- Shopping Cart
- Student Management
- Employee Portal
- Banking Dashboard
- Inventory Systems

---

## Interview Questions

1. What is Service-Based State Management?
2. Why do we use Angular Services?
3. What is Dependency Injection?
4. What is a Singleton Service?
5. How do components share data?

---

## Summary

Angular Services provide a simple mechanism for sharing state across multiple components. They improve code reusability, maintainability, and consistency by centralizing shared data.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Create Angular Services.
- Share data between components.
- Manage shared state.
- Use Dependency Injection effectively.
