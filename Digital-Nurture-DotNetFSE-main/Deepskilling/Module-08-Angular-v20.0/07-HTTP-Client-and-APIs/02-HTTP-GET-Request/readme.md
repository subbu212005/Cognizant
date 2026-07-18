# HTTP GET Request in Angular

## Overview

The HTTP GET request is used to retrieve data from a server or REST API. Angular provides the HttpClient service, which makes it easy to send GET requests and receive JSON data asynchronously using Observables.

In this exercise, you will retrieve a list of users from a public REST API and display them in an Angular component.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Send HTTP GET requests.
- Consume REST APIs.
- Display JSON data.
- Use HttpClient.
- Work with Observables.

---

## Prerequisites

- Angular CLI
- HttpClient configured
- Internet connection

---

## Step 1: Student Service

```typescript
import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  private http = inject(HttpClient);

  api = 'https://jsonplaceholder.typicode.com/users';

  getStudents(): Observable<any> {
    return this.http.get<any>(this.api);
  }

}
```

---

## Step 2: Student Component

```typescript
import { Component, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentService } from '../services/student.service';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent implements OnInit {

  students: any[] = [];

  private studentService = inject(StudentService);

  ngOnInit(): void {
    this.studentService.getStudents().subscribe(data => {
      this.students = data;
    });
  }

}
```

---

## Step 3: student.html

```html
<h2>Student List</h2>

<table border="1" cellpadding="8">

<tr>
<th>ID</th>
<th>Name</th>
<th>Email</th>
</tr>

<tr *ngFor="let student of students">
<td>{{student.id}}</td>
<td>{{student.name}}</td>
<td>{{student.email}}</td>
</tr>

</table>
```

---

## Step 4: student.css

```css
table{
    border-collapse: collapse;
    width:100%;
}

th{
    background-color:#1976d2;
    color:white;
}

th,td{
    padding:10px;
}
```

---

## Expected Output

```
Student List

-------------------------------------

ID     Name              Email

1      Leanne Graham     Sincere@april.biz
2      Ervin Howell      Shanna@melissa.tv
3      Clementine Bauch  Nathan@yesenia.net

...

10     Clementina DuBuque
```

---

## Advantages

- Retrieves live data.
- Supports REST APIs.
- Easy JSON parsing.
- Asynchronous communication.
- Reactive programming.

---

## Real-World Applications

- Student Management System
- Employee Portal
- Banking Dashboard
- Product Catalog
- Hospital Management
- E-Commerce Websites

---

## Interview Questions

1. What is HTTP GET?
2. What is HttpClient?
3. What is an Observable?
4. Why do we use subscribe()?
5. What is JSON?

---

## Summary

Angular's HttpClient allows developers to retrieve data from REST APIs using HTTP GET requests. The returned Observable enables asynchronous programming and efficient data handling.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Send GET requests.
- Retrieve JSON data.
- Display API responses.
- Use Observables.
- Build data-driven Angular applications.
