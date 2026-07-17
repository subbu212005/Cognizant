# Reactive Forms in Angular

## Overview

Reactive Forms provide a model-driven approach for creating and managing forms in Angular. They offer greater control, scalability, and testability compared to Template-Driven Forms.

In this exercise, we will create a Student Registration Form using `ReactiveFormsModule`, `FormGroup`, and `FormControl`.

---

# Learning Objectives

After completing this exercise, you will be able to:

* Understand Reactive Forms.
* Import `ReactiveFormsModule`.
* Create a `FormGroup`.
* Use `FormControl`.
* Handle form submission.
* Display submitted form values.

---

# Prerequisites

* Node.js installed
* Angular CLI installed
* Visual Studio Code
* Basic knowledge of Angular Components

---

# Step 1: Update student.ts

```typescript
import { Component } from '@angular/core';
import { ReactiveFormsModule, FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  studentForm = new FormGroup({
    name: new FormControl(''),
    email: new FormControl(''),
    course: new FormControl('')
  });

  onSubmit() {
    alert('Reactive Form Submitted Successfully!');
    console.log(this.studentForm.value);
  }
}
```

---

# Step 2: Update student.html

```html
<h2>Reactive Student Registration Form</h2>

<form [formGroup]="studentForm" (ngSubmit)="onSubmit()">

  <label>Name:</label><br>
  <input type="text" formControlName="name">

  <br><br>

  <label>Email:</label><br>
  <input type="email" formControlName="email">

  <br><br>

  <label>Course:</label><br>
  <input type="text" formControlName="course">

  <br><br>

  <button type="submit">Register</button>

</form>

<hr>

<h3>Submitted Data</h3>

<p><strong>Name:</strong> {{ studentForm.value.name }}</p>
<p><strong>Email:</strong> {{ studentForm.value.email }}</p>
<p><strong>Course:</strong> {{ studentForm.value.course }}</p>
```

---

# Step 3: Update student.css

```css
h2 {
    color: darkblue;
}

input {
    width: 250px;
    padding: 8px;
    margin-top: 5px;
}

button {
    background-color: darkblue;
    color: white;
    padding: 10px 18px;
    border: none;
    cursor: pointer;
}

button:hover {
    background-color: navy;
}

hr {
    margin: 20px 0;
}
```

---

# Expected Output

```text
Reactive Student Registration Form

Name:
[____________]

Email:
[____________]

Course:
[____________]

[ Register ]

Submitted Data

Name:
Email:
Course:
```

After entering values and clicking **Register**, an alert appears:

```text
Reactive Form Submitted Successfully!
```

The submitted data is displayed below the form.

---

# Advantages

* Better scalability.
* Easier testing.
* Strong validation support.
* Explicit form model.
* Suitable for complex forms.

---

# Interview Questions

1. What are Reactive Forms?
2. Difference between Template-Driven and Reactive Forms?
3. What is `FormGroup`?
4. What is `FormControl`?
5. Why use `ReactiveFormsModule`?

---

# Summary

Reactive Forms provide a robust, model-driven approach to building forms and are recommended for medium and large Angular applications.

---

# Learning Outcome

After completing this exercise, you will be able to:

* Build Reactive Forms.
* Use `FormGroup` and `FormControl`.
* Handle form submission.
* Display form data dynamically.
