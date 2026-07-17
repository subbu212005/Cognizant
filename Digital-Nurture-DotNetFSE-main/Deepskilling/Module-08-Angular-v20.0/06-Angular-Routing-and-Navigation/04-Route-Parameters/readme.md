# Route Parameters in Angular

## Overview

Route Parameters allow Angular applications to pass dynamic values through the URL. These parameters help display specific data based on the requested route, such as a student ID, product ID, or employee ID.

Angular provides the `ActivatedRoute` service to access route parameters inside a component.

---

# Learning Objectives

After completing this exercise, you will be able to:

- Understand Route Parameters.
- Configure parameterized routes.
- Access route parameters using `ActivatedRoute`.
- Display dynamic content based on URL values.

---

# What are Route Parameters?

Route Parameters are dynamic values included in the URL.

Example:

```
http://localhost:4200/student/101
```

Here, **101** is the route parameter.

---

# Step 1: Generate Student Component

```bash
ng generate component student
```

---

# Step 2: Update app.routes.ts

```typescript
import { Routes } from '@angular/router';
import { StudentComponent } from './student/student';

export const routes: Routes = [
  { path: '', redirectTo: 'student/101', pathMatch: 'full' },
  { path: 'student/:id', component: StudentComponent }
];
```

---

# Step 3: Update student.ts

```typescript
import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  studentId = '';

  constructor(private route: ActivatedRoute) {
    this.studentId = this.route.snapshot.paramMap.get('id') ?? '';
  }

}
```

---

# Step 4: Update student.html

```html
<h2>Student Details</h2>

<p>Student ID: {{ studentId }}</p>
```

---

# Step 5: Update student.css

```css
h2{
    color: darkblue;
}

p{
    color: green;
    font-size:20px;
    font-weight:bold;
}
```

---

# Expected Output

Student Details

Student ID: 101

Changing the URL to:

```
http://localhost:4200/student/205
```

displays:

Student ID: 205

---

# Advantages

- Supports dynamic URLs.
- Displays personalized data.
- Improves application flexibility.
- Commonly used in CRUD applications.

---

# Interview Questions

1. What are Route Parameters?
2. What is `ActivatedRoute`?
3. What is `snapshot`?
4. How do you read URL parameters?
5. Where are Route Parameters commonly used?

---

# Summary

Route Parameters allow Angular applications to pass and retrieve dynamic values through URLs, making applications more flexible and interactive.

---

# Learning Outcome

After completing this exercise, you will be able to:

- Configure parameterized routes.
- Access URL parameters.
- Display dynamic data.
- Use the `ActivatedRoute` service.
