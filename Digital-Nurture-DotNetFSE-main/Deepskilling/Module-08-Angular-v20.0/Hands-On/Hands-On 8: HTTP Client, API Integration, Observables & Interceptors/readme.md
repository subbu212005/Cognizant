# Hands-On 8: HTTP Client, API Integration, Observables & Interceptors

## Overview

This project is the implementation of **Hands-On 8** from the **Digital Nurture 5.0 – Angular (v20.0)** exercise book.

In this hands-on, the **Student Course Portal** is upgraded from using hardcoded data to consuming a REST API using Angular **HttpClient**. The project integrates **JSON Server** as a mock backend, applies **RxJS operators** for data transformation and error handling, and implements **HTTP Interceptors** for authentication, logging, and global loading indicators.

---

## Learning Objectives

- Configure Angular HttpClient
- Consume REST APIs
- Perform CRUD operations
- Understand Observables
- Use RxJS Operators
- Handle HTTP Errors
- Retry Failed Requests
- Chain HTTP Calls with switchMap
- Implement HTTP Interceptors
- Create Global Loading Indicator

---

## Technologies Used

- Angular 20
- TypeScript
- HTML5
- CSS3
- Angular HttpClient
- RxJS
- JSON Server
- HTTP Interceptors

---

## Prerequisites

- Hands-On 1 to Hands-On 7 completed.

---

## Topics Covered

- HttpClient
- Observable
- GET
- POST
- PUT
- DELETE
- RxJS map
- tap
- catchError
- retry
- switchMap
- HTTP Interceptors
- Loading Spinner
- Error Handling

---

## Features Implemented

### Course API

- Get Courses
- Get Course By ID
- Add Course
- Update Course
- Delete Course

---

### Enrollment API

- Get Students
- Enroll Student
- Remove Enrollment

---

### RxJS Operators

- map()
- tap()
- catchError()
- retry()
- switchMap()

---

### HTTP Interceptors

#### Authentication Interceptor

Adds

```
Authorization: Bearer mock-token-12345
```

to every request.

---

#### Error Interceptor

Handles

- 401 Unauthorized
- 404 Not Found
- 500 Internal Server Error

---

#### Loading Interceptor

Displays a loading spinner during every API request.

---

## JSON Server

Mock Backend

```bash
npm install -g json-server
```

Start Server

```bash
json-server --watch db.json --port 3000
```

Server URL

```
http://localhost:3000
```

---

## Angular CLI Commands

Generate Interceptors

```bash
ng generate interceptor interceptors/auth
```

```bash
ng generate interceptor interceptors/error-handler
```

```bash
ng generate interceptor interceptors/loading
```

Generate Loading Service

```bash
ng generate service services/loading
```

Run Application

```bash
ng serve
```

Build

```bash
ng build
```

---

## Application Workflow

```
Application Starts
        │
        ▼
Loading Spinner
        │
        ▼
HTTP GET
        │
        ▼
Authorization Header Added
        │
        ▼
JSON Server
        │
        ▼
Response Received
        │
        ▼
RxJS Operators
        │
        ▼
Component Updated
        │
        ▼
Spinner Hidden
```

---

## Expected Output

```
Courses Loaded Successfully

Angular

Java

Spring

Python

--------------------------------

Loading...

--------------------------------

Authorization Header Added

--------------------------------

API Error

Retry Request

--------------------------------

Course Created Successfully
```

---

## Angular Concepts Demonstrated

- HttpClient
- Observable
- RxJS
- map
- tap
- retry
- catchError
- switchMap
- HTTP Interceptor
- BehaviorSubject
- Loading Spinner

---

## Files Included

- Source Code
- README.md
- Notes.md
- Output.md
- db.json

---

## Learning Outcome

After completing this hands-on, you will be able to:

- Consume REST APIs using Angular HttpClient.
- Perform CRUD operations.
- Use RxJS operators effectively.
- Handle HTTP errors gracefully.
- Implement retry strategies.
- Build reusable HTTP interceptors.
- Display global loading indicators.

---

## Conclusion

Hands-On 8 introduces Angular's HttpClient and RxJS, enabling the Student Course Portal to communicate with a backend service. By adding interceptors, centralized error handling, and a loading spinner, the application becomes more scalable, maintainable, and closer to a production-ready Angular application.

---

**Course:** Digital Nurture 5.0 – .NET Full Stack Engineer

**Module:** Angular (v20.0)

**Hands-On:** 8 – HTTP Client, API Integration, Observables & Interceptors
