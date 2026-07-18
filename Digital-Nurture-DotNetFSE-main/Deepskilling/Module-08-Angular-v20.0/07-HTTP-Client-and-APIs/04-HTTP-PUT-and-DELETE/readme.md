# HTTP PUT and DELETE Requests in Angular

## Overview

HTTP PUT and DELETE requests are essential operations used to update and remove existing data from a server or REST API. Angular's HttpClient service provides simple methods to perform these operations asynchronously using Observables.

In this exercise, you will learn how to update an existing student's information using the PUT method and delete a student record using the DELETE method.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand HTTP PUT requests.
- Understand HTTP DELETE requests.
- Update existing records using HttpClient.
- Delete records from a REST API.
- Handle server responses using Observables.

---

## Prerequisites

Before starting this exercise, ensure you have:

- Angular CLI installed
- HttpClient configured
- Basic knowledge of Angular Forms
- Internet connection

---

## What is HTTP PUT?

The PUT method is used to update an existing resource on the server. The request sends the complete updated data for the resource.

Example applications include:

- Updating student details
- Editing employee information
- Updating product details
- Modifying customer profiles

---

## What is HTTP DELETE?

The DELETE method is used to remove an existing resource from the server.

Example applications include:

- Deleting student records
- Removing products
- Deleting user accounts
- Cancelling bookings

---

## Step 1

Create methods in the service for PUT and DELETE requests.

```typescript
updateStudent(id: number, student: any) {
  return this.http.put(`${this.api}/${id}`, student);
}

deleteStudent(id: number) {
  return this.http.delete(`${this.api}/${id}`);
}
```

---

## Step 2

Call the update method.

```typescript
updateStudent() {
  this.studentService
      .updateStudent(1, this.student)
      .subscribe(data => {
        this.response = data;
      });
}
```

---

## Step 3

Call the delete method.

```typescript
deleteStudent() {
  this.studentService
      .deleteStudent(1)
      .subscribe(data => {
        this.response = data;
      });
}
```

---

## Step 4

Display the server response.

```html
<pre>
{{ response | json }}
</pre>
```

---

## Expected Output

```
Angular HTTP PUT and DELETE

Name:
Subbu

Email:
subbu@gmail.com

[Update]

[Delete]

----------------------------

Server Response

{
"id":1,
"name":"Subbu",
"email":"subbu@gmail.com"
}
```

---

## Advantages

- Updates existing records efficiently.
- Deletes unwanted records.
- Uses asynchronous communication.
- Integrates seamlessly with REST APIs.
- Supports JSON data exchange.

---

## Real-World Applications

- Student Management System
- Banking Applications
- Hospital Management
- Inventory Management
- Employee Management
- E-Commerce Platforms

---

## Interview Questions

1. What is an HTTP PUT request?
2. What is an HTTP DELETE request?
3. What is the difference between PUT and POST?
4. What is the difference between PUT and PATCH?
5. What happens when a DELETE request is successful?
6. Why are Observables used with HttpClient?
7. How do you update data using Angular HttpClient?

---

## Summary

In this exercise, you learned how to update and delete resources using Angular's HttpClient service. The PUT method is used to modify existing data, while the DELETE method removes resources from the server. These operations are fundamental for building full-featured CRUD applications.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Send HTTP PUT requests.
- Send HTTP DELETE requests.
- Update existing records.
- Delete resources from REST APIs.
- Build complete CRUD applications using Angular.
