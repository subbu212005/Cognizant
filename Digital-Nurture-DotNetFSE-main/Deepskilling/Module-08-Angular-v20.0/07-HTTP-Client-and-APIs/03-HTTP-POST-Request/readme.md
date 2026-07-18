# HTTP POST Request in Angular

## Overview

The HTTP POST request is used to send data from an Angular application to a server or REST API. It is commonly used to create new records such as user registrations, student details, product information, or feedback forms.

Angular's `HttpClient` service makes it simple to send POST requests using Observables and process the server's response asynchronously.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand the HTTP POST method.
- Send data to a REST API.
- Use Angular HttpClient for POST requests.
- Work with Angular Forms.
- Display server responses.

---

## Prerequisites

Before starting this exercise, ensure you have:

- Angular CLI installed
- HttpClient configured
- Basic knowledge of Angular Forms
- Internet connection

---

## What is HTTP POST?

The POST method is used to send data to a server. Unlike GET requests, POST requests include data in the request body and are typically used to create new resources.

Example applications include:

- Student Registration
- User Signup
- Product Creation
- Feedback Forms
- Contact Forms

---

## Step 1

Create a service to send POST requests using HttpClient.

```typescript
addStudent(student: any): Observable<any> {
  return this.http.post<any>(this.api, student);
}
```

---

## Step 2

Create a form to collect student information.

```html
<input type="text" [(ngModel)]="student.name">

<input type="email" [(ngModel)]="student.email">
```

---

## Step 3

Call the service when the Submit button is clicked.

```typescript
addStudent() {
  this.studentService
      .addStudent(this.student)
      .subscribe(data => {
        this.response = data;
      });
}
```

---

## Step 4

Display the response returned by the server.

```html
<pre>
{{ response | json }}
</pre>
```

---

## Expected Output

```
Angular HTTP POST Request

Name:
Subbu

Email:
subbu@gmail.com

Submit

--------------------------

Server Response

{
"id":101,
"name":"Subbu",
"email":"subbu@gmail.com"
}
```

---

## Advantages

- Creates new records on the server.
- Supports sending JSON data.
- Easy integration with REST APIs.
- Works seamlessly with Angular Forms.
- Supports asynchronous communication.

---

## Real-World Applications

- Student Registration System
- Employee Management System
- Banking Applications
- Hospital Management System
- E-Commerce Product Management
- Customer Feedback Forms
- Online Job Portals

---

## Interview Questions

1. What is an HTTP POST request?
2. What is the difference between GET and POST?
3. Why is HttpClient used in Angular?
4. What is the purpose of `subscribe()`?
5. What data format is commonly used with POST requests?
6. What is the request body?
7. Why are Angular Forms commonly used with POST requests?

---

## Summary

In this exercise, you learned how to send data from an Angular application to a REST API using the HTTP POST method. By combining Angular Forms with HttpClient, you can collect user input, send it to the server, and display the server's response, enabling the creation of interactive and data-driven web applications.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Configure HTTP POST requests.
- Send JSON data to REST APIs.
- Integrate Angular Forms with HttpClient.
- Handle server responses.
- Develop applications that create new records using Angular.
```**
