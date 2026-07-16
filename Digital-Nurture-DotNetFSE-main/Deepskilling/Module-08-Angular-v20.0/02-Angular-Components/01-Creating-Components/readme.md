# Creating Components in Angular

## Overview

Components are the fundamental building blocks of Angular applications. Every Angular application is composed of one or more components. A component controls a part of the user interface and contains the HTML template, CSS styles, and TypeScript logic required for that part of the application.

Angular CLI makes it easy to generate components automatically.

---

# What is a Component?

A component is a reusable UI element that consists of:

* HTML Template
* CSS Styles
* TypeScript Logic

Each component is independent and can be reused across the application.

---

# Component Structure

A typical Angular component contains:

```text
student/
├── student.ts
├── student.html
├── student.css
└── student.spec.ts
```

---

# Creating a Component

Open the terminal inside the Angular project and run:

```bash
ng generate component student
```

or the short form:

```bash
ng g c student
```

Angular CLI automatically creates the component files.

---

# Generated Files

| File            | Purpose          |
| --------------- | ---------------- |
| student.ts      | Component logic  |
| student.html    | HTML template    |
| student.css     | Component styles |
| student.spec.ts | Unit test file   |

---

# Component Decorator

Angular components use the `@Component` decorator.

Example:

```typescript
import { Component } from '@angular/core';

@Component({
  selector: 'app-student',
  standalone: true,
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {}
```

---

# Using the Component

Add the component selector to another template:

```html
<app-student></app-student>
```

Angular renders the component wherever the selector is used.

---

# Advantages

* Reusable UI
* Better code organization
* Easier maintenance
* Modular development
* Improved testing

---

# Interview Questions

1. What is a component?
2. Which command creates a component?
3. What files are generated?
4. What is the purpose of `@Component`?
5. What is a selector?

---

# Summary

Components are the core building blocks of Angular applications. They encapsulate the UI, logic, and styles into reusable units, making applications modular and easier to maintain.

---

# Learning Outcome

After completing this topic, you will be able to:

* Create Angular components using Angular CLI.
* Understand the generated files.
* Use the `@Component` decorator.
* Display components in an Angular application.
