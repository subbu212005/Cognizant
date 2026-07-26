# Hands-On 4: Template-Driven Forms & Validation

## Overview

This project is the implementation of **Hands-On 4** from the **Digital Nurture 5.0 – Angular (v20.0)** exercise book.

In this hands-on, the **Student Course Portal** is enhanced by implementing **Template-Driven Forms**. Students can submit enrollment requests using Angular's `ngForm` and `ngModel` directives. The application also demonstrates built-in form validation, validation error messages, CSS validation states, form submission, and form reset functionality.

---

## Learning Objectives

- Understand Template-Driven Forms
- Use FormsModule
- Implement ngForm
- Use ngModel
- Implement Built-in Validators
- Display Validation Messages
- Apply Angular Form State CSS
- Handle Form Submission
- Reset Forms

---

## Technologies Used

- Angular 20
- TypeScript
- HTML5
- CSS3
- Angular FormsModule
- Visual Studio Code

---

## Prerequisites

- Hands-On 1 completed
- Hands-On 2 completed
- Hands-On 3 completed

---

# Project Structure

```
Student-Course-Portal/
│
├── src/
│
├── app/
│   │
│   ├── components/
│   │   ├── header/
│   │   └── course-card/
│   │
│   ├── directives/
│   │   └── highlight/
│   │
│   ├── pipes/
│   │   └── credit-label/
│   │
│   ├── pages/
│   │   │
│   │   ├── home/
│   │   ├── course-list/
│   │   ├── student-profile/
│   │   └── enrollment-form/
│   │       ├── enrollment-form.ts
│   │       ├── enrollment-form.html
│   │       ├── enrollment-form.css
│   │       └── enrollment-form.spec.ts
│   │
│   ├── models/
│   │   └── course.ts
│   │
│   ├── app.component.*
│   ├── app.routes.ts
│   └── app.config.ts
│
├── README.md
├── Notes.md
└── Output.md
```

---

# Topics Covered

- Template-Driven Forms
- FormsModule
- ngForm
- ngModel
- Built-in Validators
- Required Validation
- Email Validation
- MinLength Validation
- Form Submission
- Form Reset
- Validation Messages
- Angular Form CSS Classes

---

# Features Implemented

## Enrollment Form

The form collects:

- Student Name
- Student Email
- Course ID
- Preferred Semester
- Agree to Terms

---

## Form Validation

### Student Name

- Required
- Minimum Length = 3

### Student Email

- Required
- Valid Email Format

### Course ID

- Required

### Preferred Semester

- Required

### Agree to Terms

- Must be Checked

---

## Validation Messages

Displays messages like:

```
Name is required

Name must be at least 3 characters

Valid email required

Course ID is required

Please accept Terms and Conditions
```

---

## Angular Form States

Angular automatically adds CSS classes.

```
ng-valid

ng-invalid

ng-touched

ng-untouched

ng-pristine

ng-dirty
```

CSS Example

```css
.ng-invalid.ng-touched{
    border:2px solid red;
}

.ng-valid.ng-touched{
    border:2px solid green;
}
```

---

## Form Submission

When all validations pass

↓

Displays

```
Enrollment Request Submitted Successfully!
```

and logs

```
form.value

form.valid
```

---

## Reset Form

Click

```
Reset
```

↓

Clears

- Inputs
- Validation
- Form State

using

```typescript
enrollForm.resetForm();
```

---

# Angular CLI Commands

Generate Enrollment Form Component

```bash
ng generate component pages/enrollment-form
```

Run Application

```bash
ng serve
```

Build Project

```bash
ng build
```

---

# Application Workflow

```
Application Starts
        │
        ▼
Enrollment Form Opens
        │
        ▼
User Enters Details
        │
        ▼
Angular Validates Fields
        │
        ▼
Validation Errors Displayed
        │
        ▼
Form Valid
        │
        ▼
Submit Enabled
        │
        ▼
Enrollment Submitted
        │
        ▼
Success Message Displayed
        │
        ▼
Reset Form
```

---

# Expected Output

```
Enrollment Form

Student Name

Student Email

Course ID

Preferred Semester

Agree to Terms

[Submit]

[Reset]
```

Invalid Input

```
Name is required

Email is invalid

Course ID required
```

Successful Submission

```
Enrollment Request Submitted Successfully!
```

---

# Angular Concepts Demonstrated

- FormsModule
- ngForm
- ngModel
- Template-Driven Forms
- Required Validator
- Email Validator
- MinLength Validator
- Form Submission
- Form Reset
- Form Validation
- CSS Validation States

---

# Files Included

- Source Code
- README.md
- Notes.md
- Output.md

---

# Learning Outcome

After completing this hands-on, you will be able to:

- Build Template-Driven Forms in Angular.
- Bind form fields using `ngModel`.
- Validate user input with built-in validators.
- Display contextual validation messages.
- Handle form submission and reset.
- Style forms using Angular validation state classes.

---

# Conclusion

Hands-On 4 introduces **Template-Driven Forms** and demonstrates how Angular simplifies form handling and validation. By using `ngForm`, `ngModel`, and built-in validators, the Student Course Portal now supports a robust enrollment request form with real-time validation and user-friendly feedback.

---

**Course:** Digital Nurture 5.0 – .NET Full Stack Engineer

**Module:** Angular (v20.0)

**Hands-On:** 4 – Template-Driven Forms & Validation
