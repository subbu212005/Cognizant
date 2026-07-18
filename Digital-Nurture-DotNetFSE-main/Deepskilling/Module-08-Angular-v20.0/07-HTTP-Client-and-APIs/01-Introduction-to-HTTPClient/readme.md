# Introduction to HTTPClient in Angular

## Overview

Angular provides the HttpClient module to communicate with REST APIs. It enables Angular applications to send HTTP requests such as GET, POST, PUT, DELETE, and PATCH to web servers.

The HttpClient service simplifies data exchange between the frontend and backend using JSON.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand HttpClient.
- Configure HttpClient in Angular.
- Send HTTP requests.
- Consume REST APIs.
- Display server data.

---

## What is HttpClient?

HttpClient is an Angular service used to communicate with backend servers.

It supports:

- GET
- POST
- PUT
- DELETE
- PATCH

---

## Features

- JSON Support
- Observable-based API
- Error Handling
- Request Interceptors
- Response Interceptors

---

## Step 1

Install HttpClient.

For standalone Angular applications:

```typescript
import { provideHttpClient } from '@angular/common/http';

bootstrapApplication(AppComponent, {
  providers: [
    provideHttpClient()
  ]
});
```

---

## Step 2

Generate a service.

```bash
ng generate service services/student
```

---

## Step 3

Student Service

```typescript
import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  private http = inject(HttpClient);

  api =
    'https://jsonplaceholder.typicode.com/users';

  getStudents() {
    return this.http.get(this.api);
  }

}
```

---

## Step 4

Component

```typescript
import { Component } from '@angular/core';

@Component({
  selector: 'app-student',
  standalone: true,
  templateUrl: './student.html'
})
export class StudentComponent {}
```

---

## Expected Output

The application successfully connects to a REST API and is ready to retrieve data using HttpClient.

---

## Advantages

- Simple API communication.
- Supports Observables.
- Built-in error handling.
- JSON support.
- Secure HTTP communication.

---

## Interview Questions

1. What is HttpClient?
2. Why is HttpClient preferred over XMLHttpRequest?
3. What is an Observable?
4. What is REST API?
5. What is JSON?

---

## Summary

HttpClient is Angular's standard service for interacting with REST APIs. It supports all common HTTP operations and integrates seamlessly with Angular's reactive programming model.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Configure HttpClient.
- Create HTTP services.
- Connect Angular to REST APIs.
- Prepare applications for backend integration.
