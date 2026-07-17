# Template-Driven Forms in Angular

## Overview

Template-Driven Forms are one of the two approaches Angular provides for building forms. They rely on Angular directives in the template and are suitable for simple forms with minimal validation.

In this exercise, we will create a simple Student Registration Form using `FormsModule` and `ngModel`.

---

# Learning Objectives

After completing this exercise, you will be able to:

* Understand Template-Driven Forms.
* Import `FormsModule`.
* Use `[(ngModel)]` for two-way data binding.
* Handle form submission using `ngSubmit`.
* Display submitted form data.

---

# Prerequisites

* Node.js installed
* Angular CLI installed
* Visual Studio Code
* Basic knowledge of Angular Components

---

# Step 1: Import FormsModule

Update `student.ts`:

```typescript
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  student = {
    name: '',
    email: '',
    course: ''
  };

  onSubmit() {
    alert('Form Submitted Successfully!');
    console.log(this.student);
  }
}
```

---

# Step 2: Create the Form

Update `student.html`:

```html
<h2>Student Registration Form</h2>

<form (ngSubmit)="onSubmit()">

  <label>Name:</label><br>
  <input
    type="text"
    name="name"
    [(ngModel)]="student.name">

  <br><br>

  <label>Email:</label><br>
  <input
    type="email"
    name="email"
    [(ngModel)]="student.email">

  <br><br>

  <label>Course:</label><br>
  <input
    type="text"
    name="course"
    [(ngModel)]="student.course">

  <br><br>

  <button type="submit">
    Register
  </button>

</form>

<hr>

<h3>Submitted Data</h3>

<p><strong>Name:</strong> {{ student.name }}</p>
<p><strong>Email:</strong> {{ student.email }}</p>
<p><strong>Course:</strong> {{ student.course }}</p>
```

---

# Step 3: student.css

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
    background: darkblue;
    color: white;
    padding: 10px 18px;
    border: none;
    cursor: pointer;
}

button:hover {
    background: navy;
}

hr {
    margin: 20px 0;
}
```

---

# Expected Output

```text
Student Registration Form

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

After entering values, the submitted data is displayed below the form.

---

# Advantages

* Easy to implement.
* Uses Angular directives.
* Suitable for small forms.
* Less TypeScript code.
* Supports two-way data binding.

---

# Interview Questions

1. What is a Template-Driven Form?
2. What is `ngModel`?
3. Why is the `name` attribute required?
4. What is `ngSubmit`?
5. When should Template-Driven Forms be used?

---

# Summary

Template-Driven Forms simplify form creation by using Angular directives directly in HTML. They are ideal for small and straightforward applications.

---

# Learning Outcome

After completing this exercise, you will be able to:

* Build Template-Driven Forms.
* Use `FormsModule`.
* Bind form fields using `ngModel`.
* Submit and display form data.
