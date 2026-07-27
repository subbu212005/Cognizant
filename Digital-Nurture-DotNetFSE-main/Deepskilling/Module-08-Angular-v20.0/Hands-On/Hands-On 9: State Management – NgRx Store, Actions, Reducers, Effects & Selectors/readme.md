# Hands-On 9: State Management – NgRx Store, Actions, Reducers, Effects & Selectors

## Overview

This project is the implementation of **Hands-On 9** from the **Digital Nurture 5.0 – Angular (v20.0)** exercise book.

In this hands-on, the **Student Course Portal** is enhanced using **NgRx**, Angular's Redux-inspired state management library. Instead of managing application state inside services, the application stores course and enrollment data in a centralized **Store**. Actions trigger state changes, Reducers update immutable state, Effects handle asynchronous API calls, and Selectors expose application data efficiently.

---

## Learning Objectives

- Understand State Management
- Configure NgRx Store
- Create Actions
- Implement Reducers
- Create Selectors
- Implement Effects
- Use Store DevTools
- Manage Application State
- Handle HTTP using Effects
- Build Cross-State Selectors

---

## Technologies Used

- Angular 20
- TypeScript
- NgRx Store
- NgRx Effects
- NgRx Entity
- NgRx Store DevTools
- RxJS
- HttpClient

---

## Prerequisites

- Hands-On 1 completed
- Hands-On 2 completed
- Hands-On 3 completed
- Hands-On 4 completed
- Hands-On 5 completed
- Hands-On 6 completed
- Hands-On 7 completed
- Hands-On 8 completed

---

# Topics Covered

- NgRx Store
- Actions
- Reducers
- Selectors
- Effects
- Feature State
- Immutable State
- Store Dispatch
- Store Select
- Async Pipe
- Redux DevTools

---

# Features Implemented

## Course State

Stores

- Course List
- Loading Status
- Error Message

---

## Enrollment State

Stores

- Enrolled Course IDs
- Student Enrollment

---

## NgRx Actions

Course Actions

- Load Courses
- Load Courses Success
- Load Courses Failure

Enrollment Actions

- Enroll Course
- Unenroll Course
- Set Enrolled Courses

---

## Reducers

Maintains immutable application state.

---

## Effects

Handles

- HTTP GET
- API Errors
- Success Responses

using

- switchMap
- map
- catchError

---

## Selectors

Provides

- All Courses
- Loading Status
- Error Status
- Enrolled Courses

---

## Store DevTools

Tracks

- Every Action
- State Changes
- Reducer Execution

---

# Angular CLI Commands

Install NgRx

```bash
npm install @ngrx/store @ngrx/effects @ngrx/entity @ngrx/store-devtools
```

Run

```bash
ng serve
```

Build

```bash
ng build
```

---

# Application Workflow

```
Application Starts
        │
        ▼
Store Initialized
        │
        ▼
Dispatch LoadCourses
        │
        ▼
Effect Executes
        │
        ▼
HTTP Request
        │
        ▼
LoadCoursesSuccess
        │
        ▼
Reducer Updates Store
        │
        ▼
Selector Returns Data
        │
        ▼
Course List Updated
```

---

# Expected Output

```
Application Started

Loading Courses...

↓

Courses Loaded

Angular

Java

Spring Boot

↓

Enroll

↓

Redux DevTools

Action History

Load Courses

Load Success

Enroll Course
```

---

# Angular Concepts Demonstrated

- Store
- Actions
- Reducers
- Effects
- Selectors
- Dispatch
- Store Select
- RxJS
- Async Pipe
- Immutable State
- Redux Pattern

---

# Files Included

- Source Code
- README.md
- Notes.md
- Output.md

---

# Learning Outcome

After completing this hands-on, you will be able to:

- Configure NgRx Store.
- Dispatch actions.
- Update immutable state using reducers.
- Manage asynchronous API calls with Effects.
- Read state using Selectors.
- Debug application state with Redux DevTools.
- Build scalable Angular applications using centralized state management.

---

# Conclusion

Hands-On 9 introduces **NgRx**, enabling predictable and centralized state management for Angular applications. Using Store, Actions, Reducers, Effects, and Selectors improves scalability, maintainability, and debugging for large enterprise applications.

---

**Course:** Digital Nurture 5.0 – .NET Full Stack Engineer

**Module:** Angular (v20.0)

**Hands-On:** 9 – NgRx Store, Actions, Reducers, Effects & Selectors
