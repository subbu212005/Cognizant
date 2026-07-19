# NgRx for Advanced State Management in Angular

## Overview

NgRx is a reactive state management library for Angular based on the Redux pattern. It provides a centralized store for managing application state, making it easier to build scalable and maintainable applications.

NgRx uses five main building blocks:

- Store
- Actions
- Reducers
- Effects
- Selectors

Together, these components provide predictable state changes and improve application architecture.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand NgRx architecture.
- Create an NgRx Store.
- Define Actions.
- Create Reducers.
- Dispatch Actions.
- Retrieve data using Selectors.
- Understand the purpose of Effects.

---

## Prerequisites

Before starting this exercise, ensure you have:

- Angular CLI installed
- Basic knowledge of Angular Services
- Understanding of RxJS
- Node.js installed

---

## What is NgRx?

NgRx is a state management library that stores application data in a single Store.

Whenever the application state changes:

1. A Component dispatches an Action.
2. The Reducer updates the Store.
3. The Store holds the latest state.
4. Components retrieve data using Selectors.
5. Effects handle asynchronous operations such as API calls.

---

## NgRx Architecture

```

Component
↓
Dispatch Action
↓
Reducer
↓
Store
↓
Selector
↓
Updated UI

```

---

## Store

The Store is a centralized container that holds the application's state.

---

## Actions

Actions describe what happened in the application.

Example:

```typescript
incrementCounter
```

---

## Reducers

Reducers receive the current state and an action, then return a new state.

Reducers never modify the existing state directly.

---

## Effects

Effects perform asynchronous operations such as:

- HTTP Requests
- API Calls
- Database Operations

Effects keep components and reducers clean.

---

## Selectors

Selectors retrieve specific pieces of data from the Store.

They improve performance by preventing unnecessary UI updates.

---

## Practical Exercise

Create a simple counter application using NgRx.

- Store the counter in the Store.
- Increment the counter using an Action.
- Update state using a Reducer.
- Display state using a Selector.

---

## Expected Output

```

NgRx State Management

Counter : 0

[Increment]

↓

Counter : 1

↓

Counter : 2

```

---

## Advantages

- Centralized State Management.
- Predictable State Changes.
- Easier Debugging.
- Better Scalability.
- Improved Maintainability.
- Excellent for Large Applications.

---

## Real-World Applications

- Banking Applications
- E-Commerce Platforms
- Hospital Management Systems
- Enterprise Dashboards
- CRM Applications
- Airline Reservation Systems
- Inventory Management

---

## Interview Questions

1. What is NgRx?
2. What is the Store?
3. What are Actions?
4. What is a Reducer?
5. What are Effects?
6. What are Selectors?
7. Why should Reducers be pure functions?
8. What is the difference between Redux and NgRx?
9. When should NgRx be used?
10. What are the advantages of centralized state management?

---

## Summary

NgRx provides a robust and scalable approach to state management in Angular applications. By using Store, Actions, Reducers, Effects, and Selectors, developers can build predictable, maintainable, and reactive applications with centralized state management.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Configure NgRx Store.
- Create Actions and Reducers.
- Dispatch Actions.
- Retrieve state using Selectors.
- Understand Effects for asynchronous operations.
- Build enterprise-level Angular applications using NgRx.
