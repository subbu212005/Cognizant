# Creating and Using Services in Angular

## Overview

Services in Angular are used to share data and business logic across multiple components. They help keep components simple by moving reusable logic into separate classes.

In this exercise, you will create a service that returns a list of students and display that list in a component.

---

# Learning Objectives

After completing this exercise, you will be able to:

- Create an Angular service.
- Return data from a service.
- Inject a service into a component.
- Display service data using *ngFor.

---

# Step 1: Generate a Service

```bash
ng generate service student-data --skip-tests
```

---

# Step 2: Update student-data.service.ts

```typescript
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentDataService {

  students = [
    'Subbu',
    'Rahul',
    'Anjali',
    'Kiran',
    'Priya'
  ];

  getStudents() {
    return this.students;
  }

}
```

---

# Step 3: Update student.ts

```typescript
import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentDataService } from '../student-data.service';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  students: string[] = [];

  constructor(private studentService: StudentDataService) {
    this.students = this.studentService.getStudents();
  }

}
```

---

# Step 4: Update student.html

```html
<h2>Student List</h2>

<ul>
  <li *ngFor="let student of students">
    {{ student }}
  </li>
</ul>
```

---

# Step 5: Update student.css

```css
h2{
    color:darkblue;
}

ul{
    font-size:20px;
}

li{
    margin:8px 0;
}
```

---

# Expected Output

Student List

• Subbu

• Rahul

• Anjali

• Kiran

• Priya

---

# Advantages

- Code reusability
- Centralized business logic
- Easier maintenance
- Better testing
- Cleaner components

---

# Interview Questions

1. What is an Angular Service?
2. Why do we use services?
3. What is Dependency Injection?
4. How do services share data?
5. What is `providedIn: 'root'`?

---

# Summary

Angular services allow reusable logic and data sharing between components, making applications more modular and maintainable.

---

# Learning Outcome

After completing this exercise, you can:

- Create services.
- Return data from services.
- Inject services into components.
- Display data using *ngFor.
