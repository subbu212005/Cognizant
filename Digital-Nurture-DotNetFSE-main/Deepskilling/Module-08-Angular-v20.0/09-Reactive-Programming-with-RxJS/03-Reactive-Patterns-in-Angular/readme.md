# Reactive Patterns in Angular

## Overview

Reactive Programming is one of Angular's core concepts. Angular uses RxJS Observables to handle asynchronous operations such as HTTP requests, user interactions, routing events, and real-time data updates.

Reactive patterns allow applications to automatically respond to data changes, making the code cleaner, more maintainable, and highly scalable.

In this exercise, you will learn how to use HttpClient with Observables and display asynchronous data using the Async Pipe.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand Reactive Programming.
- Use HttpClient with Observables.
- Display data using the Async Pipe.
- Handle asynchronous data streams.
- Build reactive Angular applications.

---

## Prerequisites

Before starting this exercise, ensure you have:

- Angular CLI installed
- HttpClient configured
- Basic knowledge of RxJS Observables
- Internet connection

---

## What are Reactive Patterns?

Reactive Patterns allow Angular applications to respond automatically whenever data changes.

Examples include:

- HTTP API Calls
- Live Search
- Real-Time Notifications
- Chat Applications
- Stock Market Updates

---

## Step 1

Create a service that returns an Observable.

```typescript
getStudents() {
  return this.http.get<any[]>(this.api);
}
```

---

## Step 2

Assign the Observable inside the component.

```typescript
students$ = this.studentService.getStudents();
```

---

## Step 3

Display data using the Async Pipe.

```html
<li *ngFor="let student of students$ | async">
    {{ student.name }}
</li>
```

---

## Expected Output

```
Reactive Patterns in Angular

Student List

Leanne Graham
Ervin Howell
Clementine Bauch
...
```

---

## Advantages

- Automatic UI updates.
- Cleaner code.
- No manual subscriptions when using Async Pipe.
- Better memory management.
- Improved scalability.

---

## Real-World Applications

- Banking Applications
- E-Commerce Platforms
- Hospital Management Systems
- Online Learning Platforms
- Social Media Applications
- Live Dashboards

---

## Interview Questions

1. What is Reactive Programming?
2. What is the Async Pipe?
3. Why is Async Pipe preferred over subscribe()?
4. How does Angular use RxJS?
5. What are the advantages of Observables?

---

## Summary

Reactive patterns simplify asynchronous programming by using Observables and the Async Pipe. This approach improves code readability, reduces memory leaks, and keeps Angular applications responsive.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Build reactive Angular applications.
- Consume APIs using HttpClient.
- Display Observable data with Async Pipe.
- Manage asynchronous data efficiently.
