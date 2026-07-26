# Hands-On 2: Data Binding, Lifecycle Hooks & Component Communication

## Overview

This project is the implementation of **Hands-On 2** from the **Digital Nurture 5.0 – Angular (v20.0)** exercise book.

In this hands-on, the Student Course Portal is enhanced with Angular's data binding techniques, lifecycle hooks, and parent-child communication using `@Input` and `@Output`. These concepts are fundamental to building dynamic and reusable Angular applications.

---

## Learning Objectives

- Understand Angular Data Binding.
- Implement Interpolation.
- Use Property Binding.
- Implement Event Binding.
- Apply Two-Way Data Binding using `ngModel`.
- Learn Angular Lifecycle Hooks.
- Understand `ngOnInit`, `ngOnChanges`, and `ngOnDestroy`.
- Implement Parent-Child Communication.
- Use `@Input` and `@Output`.
- Emit events using `EventEmitter`.

---

## Technologies Used

- Angular 20
- TypeScript
- HTML5
- CSS3
- Node.js
- Angular CLI
- Visual Studio Code

---

## Prerequisites

- Hands-On 1 completed.
- Angular CLI installed.
- Node.js installed.

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
│   │   │
│   │   ├── header/
│   │   └── course-card/
│   │
│   ├── pages/
│   │   ├── home/
│   │   ├── course-list/
│   │   └── student-profile/
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

## 1. Interpolation

Display component data inside HTML.

Example:

```html
<h1>{{ portalName }}</h1>
```

---

## 2. Property Binding

Bind HTML element properties.

Example

```html
<button [disabled]="!isPortalActive">
    Enroll Now
</button>
```

---

## 3. Event Binding

Handle user events.

Example

```html
<button (click)="onEnrollClick()">
    Enroll Now
</button>
```

---

## 4. Two-Way Data Binding

Synchronize component and view using `ngModel`.

Example

```html
<input [(ngModel)]="searchTerm">

<p>Searching for: {{ searchTerm }}</p>
```

---

## 5. Lifecycle Hooks

Implemented:

- ngOnInit()
- ngOnChanges()
- ngOnDestroy()

Console Output

```
HomeComponent initialized — courses loaded

HomeComponent destroyed

Course input changed
```

---

## 6. Parent-Child Communication

Parent Component

```
CourseListComponent
```

Child Component

```
CourseCardComponent
```

Communication implemented using

- @Input
- @Output
- EventEmitter

---

# Features Implemented

## Home Component

Displays

- Portal Name
- Search Box
- Live Search Text
- Enroll Button
- Enrollment Message

---

## Course Card Component

Displays

- Course Name
- Course Code
- Credits

Provides

- Enroll Button

Emits

```
Course ID
```

using EventEmitter.

---

## Course List Component

Contains

- List of Courses
- Selected Course ID

Receives event from Course Card.

---

# Angular Concepts Demonstrated

- String Interpolation
- Property Binding
- Event Binding
- Two-Way Binding
- ngModel
- ngOnInit
- ngOnChanges
- ngOnDestroy
- @Input
- @Output
- EventEmitter

---

# Angular CLI Commands

Generate Course Card Component

```bash
ng generate component components/course-card
```

Run Project

```bash
ng serve
```

Build Project

```bash
ng build
```

---

# Application Flow

```
User opens Home Page
        │
        ▼
Portal loads
        │
        ▼
ngOnInit executes
        │
        ▼
Search Box updates in real time
        │
        ▼
Enroll Button clicked
        │
        ▼
Message displayed
        │
        ▼
Course Card emits Course ID
        │
        ▼
Course List receives event
        │
        ▼
Selected Course displayed
```

---

# Expected Output

Home Page

```
Student Course Portal

Welcome to Student Course Portal

Search Course

Searching for: Angular

[Enroll Now]

Enrollment opened!
```

Course List

```
Data Structures

CS101

Credits : 4

[Enroll]
```

After clicking Enroll

```
Selected Course ID : 101
```

Console

```
HomeComponent initialized — courses loaded

Course input changed

Enrolling in course : 101

HomeComponent destroyed
```

---

# Files Included

- Source Code
- README.md
- Notes.md
- Output.md

---

# Learning Outcome

After completing this hands-on, you will be able to

- Use all four types of Angular Data Binding.
- Understand Angular component lifecycle.
- Pass data from parent to child.
- Emit events from child to parent.
- Create reusable Angular components.
- Build interactive Angular applications.

---

# Conclusion

Hands-On 2 introduces Angular's most important concepts for building interactive web applications. By implementing data binding, lifecycle hooks, and component communication, the Student Course Portal becomes dynamic, reusable, and ready for more advanced features in subsequent hands-ons.

---

**Course:** Digital Nurture 5.0 – .NET Full Stack Engineer

**Module:** Angular (v20.0)

**Hands-On:** 2 – Data Binding, Lifecycle Hooks & Component Communication
