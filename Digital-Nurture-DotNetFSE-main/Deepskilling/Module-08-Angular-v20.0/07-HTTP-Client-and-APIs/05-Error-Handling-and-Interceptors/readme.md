# Error Handling and Interceptors in Angular

## Overview

Error handling is an essential part of every Angular application. It helps developers manage unexpected situations such as server failures, network issues, or invalid API responses without crashing the application.

Angular provides powerful error handling through the `HttpClient` service and HTTP Interceptors. Interceptors allow developers to inspect, modify, log, and handle HTTP requests and responses globally before they reach the application.

In this exercise, you will learn how to handle HTTP errors gracefully and use an HTTP Interceptor to log requests and responses.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand HTTP error handling.
- Handle API errors using HttpClient.
- Create and configure HTTP Interceptors.
- Log HTTP requests and responses.
- Display user-friendly error messages.
- Improve application reliability.

---

## Prerequisites

Before starting this exercise, ensure you have:

- Angular CLI installed
- HttpClient configured
- Basic understanding of Angular Services
- Internet connection

---

## What is Error Handling?

Error handling is the process of detecting and responding to errors that occur during HTTP communication.

Common HTTP errors include:

- Network connection failure
- Server unavailable
- Invalid API endpoint
- Unauthorized access (401)
- Resource not found (404)
- Internal server error (500)

Proper error handling improves user experience by displaying meaningful messages instead of application crashes.

---

## What is an HTTP Interceptor?

An HTTP Interceptor is a special Angular service that intercepts every HTTP request and response.

It can be used to:

- Log requests
- Modify request headers
- Add authentication tokens
- Handle errors globally
- Log server responses
- Measure request execution time

---

## Step 1

Generate an interceptor.

```bash
ng generate interceptor interceptors/logging
```

---

## Step 2

Create the interceptor.

```typescript
export const loggingInterceptor: HttpInterceptorFn = (req, next) => {

  console.log(req.url);

  return next(req);

};
```

---

## Step 3

Register the interceptor in `app.config.ts`.

```typescript
provideHttpClient(
    withInterceptors([loggingInterceptor])
)
```

---

## Step 4

Handle HTTP errors.

```typescript
this.studentService.getStudents().subscribe({

    next: data => {

        this.students = data;

    },

    error: () => {

        this.errorMessage =
        'Unable to load student data.';

    }

});
```

---

## Step 5

Display the error message.

```html
<p *ngIf="errorMessage">

{{ errorMessage }}

</p>
```

---

## Expected Output

```
Angular Error Handling and Interceptors

---------------------------------------

Student List

ID    Name               Email

1     Leanne Graham      Sincere@april.biz
2     Ervin Howell       Shanna@melissa.tv
3     Clementine Bauch   Nathan@yesenia.net

...

10    Clementina DuBuque Rey.Padberg@karina.biz
```

If an error occurs:

```
Unable to load student data.
```

The browser console displays the intercepted request URL and any HTTP errors.

---

## Advantages

- Centralized error handling.
- Cleaner application code.
- Improved debugging.
- Easy request logging.
- Better user experience.
- Reusable across the application.

---

## Real-World Applications

- Banking Applications
- E-Commerce Platforms
- Hospital Management Systems
- Student Management Systems
- Inventory Management
- Enterprise Dashboards
- Online Learning Platforms

---

## Interview Questions

1. What is an HTTP Interceptor in Angular?
2. Why do we use HTTP Interceptors?
3. How does Angular handle HTTP errors?
4. What is the purpose of `catchError()`?
5. What is `withInterceptors()`?
6. Can multiple interceptors be used in an Angular application?
7. What are the benefits of centralized error handling?

---

## Summary

In this exercise, you learned how to implement error handling and HTTP Interceptors in Angular. Error handling ensures that applications respond gracefully to failures, while Interceptors provide a centralized mechanism for logging, modifying, and monitoring all HTTP requests and responses. Together, they improve application reliability, maintainability, and user experience.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Handle HTTP errors using Angular HttpClient.
- Create and configure HTTP Interceptors.
- Log and monitor HTTP requests.
- Display meaningful error messages.
- Build robust and reliable Angular applications.
```
