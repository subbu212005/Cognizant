# RxJS Observables in Angular

## Overview

RxJS (Reactive Extensions for JavaScript) is a library used by Angular for reactive programming. It helps manage asynchronous operations such as HTTP requests, user events, routing, and real-time data streams using Observables.

An Observable is a stream of data that emits values over time. Components can subscribe to Observables to receive data whenever it becomes available.

This exercise demonstrates how to create an Observable, subscribe to it, and display emitted values in an Angular application.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand Reactive Programming.
- Understand RxJS Observables.
- Create an Observable.
- Subscribe to an Observable.
- Display emitted values.
- Understand the Observable lifecycle.

---

## Prerequisites

Before starting this exercise, ensure you have:

- Angular CLI installed
- Basic knowledge of Angular Components
- Basic knowledge of TypeScript

---

## What is an Observable?

An Observable is a stream of data that emits one or more values over time.

Examples include:

- HTTP Responses
- User Click Events
- Keyboard Events
- Timers
- WebSocket Messages

Angular uses Observables because they efficiently handle asynchronous operations.

---

## Observable Lifecycle

1. Create an Observable.
2. Subscribe to the Observable.
3. Receive emitted values.
4. Complete the Observable.
5. Unsubscribe (if required).

---

## Step 1

Import Observable.

```typescript
import { Observable } from 'rxjs';
```

---

## Step 2

Create an Observable.

```typescript
numbers$ = new Observable<number>(observer => {

  observer.next(10);
  observer.next(20);
  observer.next(30);

  observer.complete();

});
```

---

## Step 3

Subscribe to the Observable.

```typescript
this.numbers$.subscribe(value => {
    console.log(value);
});
```

---

## Expected Output

```
RxJS Observables

Observable Values

10
20
30
```

---

## Advantages

- Simplifies asynchronous programming.
- Supports multiple values.
- Easy event handling.
- Improves application responsiveness.
- Integrates seamlessly with Angular.

---

## Real-World Applications

- HTTP Requests
- Live Search
- Chat Applications
- Stock Market Updates
- Notification Systems
- Weather Applications

---

## Interview Questions

1. What is an Observable?
2. Why does Angular use RxJS?
3. What is the difference between Observable and Promise?
4. What is subscribe()?
5. What is observer.next()?
6. What is observer.complete()?
7. When should an Observable be unsubscribed?

---

## Summary

RxJS Observables are a core feature of Angular for handling asynchronous data streams. They allow applications to react to data changes efficiently and provide a flexible approach for managing events and HTTP communication.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Create Observables.
- Subscribe to Observables.
- Emit multiple values.
- Understand the Observable lifecycle.
- Build reactive Angular applications.
