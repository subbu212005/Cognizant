# Common RxJS Operators in Angular

## Overview

RxJS Operators are functions that transform, filter, combine, and handle data emitted by Observables. Angular extensively uses RxJS operators while working with HTTP requests, user interactions, routing, and asynchronous programming.

In this exercise, you will learn some of the most commonly used RxJS operators:

- map()
- filter()
- switchMap()
- mergeMap()
- catchError()

These operators help process data streams efficiently and build responsive Angular applications.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand RxJS Operators.
- Transform data using map().
- Filter emitted values using filter().
- Understand switchMap().
- Understand mergeMap().
- Handle errors using catchError().

---

## Prerequisites

Before starting this exercise, ensure you have:

- Angular CLI installed
- Basic knowledge of Observables
- Basic knowledge of TypeScript

---

## What are RxJS Operators?

RxJS Operators are functions that process values emitted by an Observable. They allow developers to transform, filter, combine, and handle asynchronous data streams.

---

## map()

The `map()` operator transforms each emitted value into a new value.

Example:

```typescript
of(1,2,3).pipe(
  map(value => value * 10)
)
```

Output:

```
10
20
30
```

---

## filter()

The `filter()` operator emits only values that satisfy a specified condition.

Example:

```typescript
of(10,20,30,40).pipe(
  filter(value => value >= 30)
)
```

Output:

```
30
40
```

---

## switchMap()

The `switchMap()` operator switches to a new Observable whenever a new value is emitted. It automatically cancels the previous Observable.

Common uses:

- HTTP Search
- Auto-complete
- Live Search

---

## mergeMap()

The `mergeMap()` operator subscribes to multiple Observables simultaneously and merges their outputs.

Common uses:

- Multiple API calls
- Parallel processing

---

## catchError()

The `catchError()` operator handles errors from an Observable and returns an alternative Observable.

Example:

```typescript
catchError(error => {
  return of([]);
})
```

---

## Expected Output

```
RxJS Operators

Mapped Values

10
20
30
40
50
```

---

## Advantages

- Efficient asynchronous programming.
- Cleaner code.
- Easy data transformation.
- Simplifies error handling.
- Improves application performance.

---

## Real-World Applications

- HTTP Requests
- Search Suggestions
- Chat Applications
- Banking Systems
- E-Commerce Websites
- Live Notifications

---

## Interview Questions

1. What is an RxJS Operator?
2. What is map()?
3. What is filter()?
4. What is switchMap()?
5. What is mergeMap()?
6. What is catchError()?
7. Why are RxJS Operators important?

---

## Summary

RxJS Operators provide powerful tools for transforming, filtering, and handling asynchronous data streams. They are fundamental for building efficient, reactive Angular applications.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Use map().
- Use filter().
- Understand switchMap().
- Understand mergeMap().
- Handle errors using catchError().
