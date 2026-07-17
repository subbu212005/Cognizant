# Form Validation in Angular

## Overview

Form Validation ensures that user input is correct before it is processed or stored. Angular provides built-in validators to enforce rules such as required fields, minimum length, and valid email format.

In this exercise, we will build a Student Registration Form using Reactive Forms with validation.

---

# Learning Objectives

After completing this exercise, you will be able to:

* Use Angular Validators.
* Validate required fields.
* Validate email addresses.
* Validate minimum character length.
* Display validation error messages.
* Prevent invalid form submission.

---

# Prerequisites

* Angular CLI
* Visual Studio Code
* Reactive Forms knowledge

---

# Step 1: Update student.ts

```typescript
import { Component } from '@angular/core';
import {
  ReactiveFormsModule,
  FormGroup,
  FormControl,
  Validators
} from '@angular/forms';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  studentForm = new FormGroup({
    name: new FormControl('', [
      Validators.required,
      Validators.minLength(3)
    ]),

    email: new FormControl('', [
      Validators.required,
      Validators.email
    ]),

    course: new FormControl('', [
      Validators.required
    ])
  });

  onSubmit() {

    if(this.studentForm.valid){
      alert("Form Submitted Successfully!");
      console.log(this.studentForm.value);
    }

  }

}
```

---

# Step 2: Update student.html

```html
<h2>Student Registration Form (Validation)</h2>

<form [formGroup]="studentForm" (ngSubmit)="onSubmit()">

  <label>Name:</label><br>

  <input type="text" formControlName="name">

  <div *ngIf="studentForm.controls.name.touched &&
              studentForm.controls.name.invalid">

    <small *ngIf="studentForm.controls.name.errors?.['required']">
      Name is required.
    </small>

    <small *ngIf="studentForm.controls.name.errors?.['minlength']">
      Minimum 3 characters required.
    </small>

  </div>

  <br>

  <label>Email:</label><br>

  <input type="email" formControlName="email">

  <div *ngIf="studentForm.controls.email.touched &&
              studentForm.controls.email.invalid">

    <small *ngIf="studentForm.controls.email.errors?.['required']">
      Email is required.
    </small>

    <small *ngIf="studentForm.controls.email.errors?.['email']">
      Enter a valid email.
    </small>

  </div>

  <br>

  <label>Course:</label><br>

  <input type="text" formControlName="course">

  <div *ngIf="studentForm.controls.course.touched &&
              studentForm.controls.course.invalid">

    <small>Course is required.</small>

  </div>

  <br><br>

  <button
      type="submit"
      [disabled]="studentForm.invalid">

      Register

  </button>

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
h2{
    color:darkblue;
}

input{

    width:250px;
    padding:8px;
    margin-top:5px;
}

button{

    background:darkblue;
    color:white;
    padding:10px 20px;
    border:none;
    cursor:pointer;
}

button:disabled{

    background:gray;
    cursor:not-allowed;
}

small{

    color:red;
    display:block;
    margin-top:5px;
}

hr{

    margin:20px 0;
}
```

---

# Expected Output

```text
Student Registration Form (Validation)

Name
[__________]

Email
[__________]

Course
[__________]

Register

Validation Messages

• Name is required.
• Minimum 3 characters required.
• Email is required.
• Enter a valid email.
• Course is required.

Submitted Data

Name:
Email:
Course:
```

When all fields are valid and the Register button is clicked:

```text
Form Submitted Successfully!
```

---

# Advantages

* Improves data accuracy.
* Prevents invalid input.
* Enhances user experience.
* Provides immediate feedback.
* Supports secure applications.

---

# Interview Questions

1. What is Form Validation?
2. What are Angular Validators?
3. What is Validators.required?
4. What is Validators.email?
5. Why disable the submit button?

---

# Summary

Angular Form Validation ensures user input meets predefined rules before submission, improving data quality and application reliability.

---

# Learning Outcome

After completing this exercise, you will be able to:

* Apply built-in Angular validators.
* Display validation errors.
* Disable submission for invalid forms.
* Build reliable and user-friendly forms.
