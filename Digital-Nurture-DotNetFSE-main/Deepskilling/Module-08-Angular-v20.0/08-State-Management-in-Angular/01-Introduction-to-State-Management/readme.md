# Introduction to State Management in Angular

## Overview

State Management is the process of storing, updating, and sharing data across different components in an Angular application. Every Angular application contains data (state) that changes over time based on user interactions, API responses, or application events.

For small applications, component state is usually sufficient. As applications grow, sharing data between multiple components becomes more challenging. Angular provides different techniques to manage application state efficiently, ranging from simple component variables to shared services and advanced libraries like NgRx.

This exercise introduces the concept of State Management and demonstrates how component state works.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand what State is.
- Understand State Management.
- Differentiate between Local State and Shared State.
- Manage state within a component.
- Update the UI dynamically when state changes.

---

## Prerequisites

Before starting this exercise, ensure you have:

- Angular CLI installed
- Basic knowledge of Angular Components
- Basic knowledge of Property Binding
- Basic knowledge of Event Binding

---

## What is State?

State is the data that an application stores and uses while it is running.

Examples include:

- User information
- Shopping cart items
- Login status
- Theme (Light/Dark)
- Product details
- Student information

Whenever this data changes, the application's UI updates accordingly.

---

## Types of State

### Local State

State that belongs to a single component.

Example:

- Counter value
- Form input
- Toggle button

### Shared State

State shared between multiple components using Angular Services.

### Global State

Application-wide state managed using libraries such as NgRx.

---

## Step 1

Create a component variable.

```typescript
count = 0;
```

---

## Step 2

Update the state.

```typescript
increment() {
  this.count++;
}
```

---

## Step 3

Display the state.

```html
<h2>Counter : {{ count }}</h2>

<button (click)="increment()">
Increment
</button>
```

---

## Expected Output

```
Introduction to State Management

Counter : 0

[Increment]

↓

Counter : 1

↓

Counter : 2
```

---

## Advantages

- Easy data management.
- Dynamic UI updates.
- Better component communication.
- Foundation for scalable applications.
- Improves maintainability.

---

## Real-World Applications

- Shopping Cart
- Banking Dashboard
- Student Portal
- Hospital Management
- Employee Management
- Inventory Systems

---

## Interview Questions

1. What is State in Angular?
2. What is State Management?
3. What is Local State?
4. What is Shared State?
5. What is Global State?
6. How does Angular update the UI when state changes?
7. Why is State Management important?

---

## Summary

State Management enables Angular applications to store, update, and synchronize data efficiently. Understanding local state is the first step toward building scalable applications that share data across multiple components.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Understand application state.
- Manage local component state.
- Update UI dynamically.
- Build the foundation for advanced state management using Services and NgRx.
