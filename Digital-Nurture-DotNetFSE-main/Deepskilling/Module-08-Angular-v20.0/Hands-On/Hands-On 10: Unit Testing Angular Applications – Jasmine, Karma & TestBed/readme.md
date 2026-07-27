# Hands-On 10: Unit Testing Angular Applications – Jasmine, Karma & TestBed

## Overview

This project is the implementation of **Hands-On 10** from the **Digital Nurture 5.0 – Angular (v20.0)** exercise book.

In this hands-on, the **Student Course Portal** is tested using **Jasmine**, **Karma**, and **Angular TestBed**. Unit tests are written for Angular components, services, and NgRx-connected components. HTTP requests are tested using **HttpClientTestingModule**, and application state is tested using **MockStore**.

---

## Learning Objectives

- Understand Angular Unit Testing
- Configure TestBed
- Write Jasmine Test Cases
- Test Angular Components
- Test Services
- Test HTTP Requests
- Test NgRx Store
- Use MockStore
- Generate Code Coverage

---

## Technologies Used

- Angular 20
- Jasmine
- Karma
- TestBed
- HttpClientTestingModule
- HttpTestingController
- NgRx MockStore
- TypeScript

---

## Prerequisites

- Hands-On 1–9 completed.
- Angular CLI installed.
- Node.js installed.

---

## Topics Covered

- Jasmine
- Karma
- TestBed
- Fixtures
- DebugElement
- spyOn()
- expect()
- Component Testing
- Service Testing
- HTTP Testing
- MockStore
- Code Coverage

---

## Features Implemented

### Component Testing

Tested

- CourseCardComponent
- HomeComponent
- CourseListComponent

Tests include

- Component Creation
- Rendering
- @Input
- @Output
- ngOnChanges
- Button Click Events

---

### Service Testing

Tested

- CourseService
- EnrollmentService

Using

- HttpClientTestingModule
- HttpTestingController

---

### HTTP Testing

Verified

- GET
- POST
- PUT
- DELETE

Requests

Mock API responses

Error responses

---

### NgRx Testing

MockStore used for

- Course State
- Enrollment State

Verified

- Selectors
- Initial State
- Loading State

---

### Code Coverage

Generate Coverage

```bash
ng test --code-coverage
```

Coverage Folder

```
coverage/
```

---

## Angular CLI Commands

Run Tests

```bash
ng test
```

Run Coverage

```bash
ng test --code-coverage
```

Build

```bash
ng build
```

---

## Application Workflow

```
Run ng test
        │
        ▼
TestBed Created
        │
        ▼
Component Tests
        │
        ▼
Service Tests
        │
        ▼
HTTP Tests
        │
        ▼
NgRx Tests
        │
        ▼
Coverage Report Generated
```

---

## Expected Output

```
Chrome Headless

✔ CourseCardComponent

✔ CourseService

✔ EnrollmentService

✔ NgRx Store

✔ HTTP Requests

Executed 25 of 25 SUCCESS
```

Coverage

```
Statements

Functions

Branches

Lines

100%
```

---

## Angular Concepts Demonstrated

- Jasmine
- Karma
- TestBed
- Fixture
- DebugElement
- spyOn
- HttpTestingController
- MockStore
- Unit Testing
- Code Coverage

---

## Files Included

- Source Code
- README.md
- Notes.md
- Output.md

---

## Learning Outcome

After completing this hands-on, you will be able to:

- Write Angular unit tests using Jasmine.
- Test components with TestBed.
- Mock HTTP requests.
- Test services.
- Test NgRx Store using MockStore.
- Generate code coverage reports.
- Build reliable Angular applications.

---

## Conclusion

Hands-On 10 completes the Student Course Portal by introducing automated testing. Component tests, service tests, HTTP tests, and NgRx store tests ensure application reliability, maintainability, and production readiness.

---

**Course:** Digital Nurture 5.0 – .NET Full Stack Engineer

**Module:** Angular (v20.0)

**Hands-On:** 10 – Unit Testing with Jasmine, Karma & TestBed
