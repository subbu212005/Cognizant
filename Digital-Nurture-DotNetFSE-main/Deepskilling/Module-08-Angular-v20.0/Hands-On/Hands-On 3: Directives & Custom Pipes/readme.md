# Hands-On 3: Directives & Custom Pipes

## Overview

This project is the implementation of **Hands-On 3** from the **Digital Nurture 5.0 – Angular (v20.0)** exercise book.

In this hands-on, the **Student Course Portal** is enhanced using Angular Directives and Pipes. The application becomes more dynamic by controlling the DOM with structural directives, applying conditional styling through attribute directives, creating a reusable custom highlight directive, and implementing a custom pipe for formatting course credits.

---

## Learning Objectives

- Understand Structural Directives
- Implement *ngIf
- Implement *ngFor
- Implement *ngSwitch
- Use ng-template
- Apply Attribute Directives
- Use ngClass
- Use ngStyle
- Create Custom Attribute Directives
- Create Custom Pipes
- Improve UI using reusable Angular features

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

- Hands-On 1 completed
- Hands-On 2 completed

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
│   ├── directives/
│   │   └── highlight/
│   │       ├── highlight.directive.ts
│   │       └── highlight.directive.spec.ts
│   │
│   ├── pipes/
│   │   └── credit-label/
│   │       ├── credit-label.pipe.ts
│   │       └── credit-label.pipe.spec.ts
│   │
│   ├── pages/
│   │   ├── home/
│   │   ├── course-list/
│   │   └── student-profile/
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

## 1. Structural Directives

Implemented

- *ngIf
- *ngFor
- *ngSwitch
- ng-template

Example

```html
<div *ngIf="isLoading">
    Loading courses...
</div>
```

---

## 2. *ngFor

Display all available courses.

Example

```html
<div *ngFor="let course of courses">
```

Implemented with

- index
- trackBy

---

## 3. *ngSwitch

Display course status.

Possible Status

- Passed
- Failed
- Pending

Example

```html
<div [ngSwitch]="course.gradeStatus">
```

---

## 4. ngClass

Apply CSS classes dynamically.

Examples

- card--enrolled
- card--full
- expanded

---

## 5. ngStyle

Apply dynamic border colors.

Example

```html
[ngStyle]="{'border-left-color': borderColor}"
```

---

## 6. Custom Highlight Directive

Created using

```bash
ng generate directive directives/highlight
```

Features

- Mouse Enter
- Mouse Leave
- Configurable Highlight Color

Default Color

```
Yellow
```

Custom Example

```html
<app-course-card appHighlight="lightblue">
```

---

## 7. Custom Credit Label Pipe

Created using

```bash
ng generate pipe pipes/credit-label
```

Transforms

| Input | Output |
|--------|---------|
| 1 | 1 Credit |
| 2 | 2 Credits |
| 3 | 3 Credits |
| null | No Credits |
| 0 | No Credits |

Example

```html
{{ course.credits | creditLabel }}
```

---

# Features Implemented

## Course Loading

- Loading indicator
- 1.5-second simulation
- Dynamic course rendering

---

## Course Status

Displays

- Passed
- Failed
- Pending

using *ngSwitch.

---

## Dynamic Styling

Implemented using

- ngClass
- ngStyle

---

## Expand Card

Each course card contains

```
Show Details
```

button.

Expands the card dynamically.

---

## Hover Highlight

Mouse over course card

↓

Background changes.

---

## Credit Formatting

Instead of

```
3
```

Displays

```
3 Credits
```

---

# Angular CLI Commands

Generate Directive

```bash
ng generate directive directives/highlight
```

Generate Pipe

```bash
ng generate pipe pipes/credit-label
```

Run

```bash
ng serve
```

Build

```bash
ng build
```

---

# Application Flow

```
Application Starts
        │
        ▼
Loading Screen
        │
        ▼
Course List Appears
        │
        ▼
Hover Course
        │
        ▼
Highlight Activated
        │
        ▼
Click Show Details
        │
        ▼
Card Expands
        │
        ▼
Credits formatted by Pipe
```

---

# Expected Output

```
Student Course Portal

Loading Courses...

↓

Course Name

Credits : 4 Credits

Status : Passed

[Show Details]

Hover → Highlight

Expanded Card
```

---

# Angular Concepts Demonstrated

- Structural Directives
- *ngIf
- *ngFor
- *ngSwitch
- ng-template
- ngClass
- ngStyle
- HostListener
- ElementRef
- Renderer2
- Custom Directive
- Custom Pipe
- PipeTransform

---

# Files Included

- Source Code
- README.md
- Notes.md
- Output.md

---

# Learning Outcome

After completing this hands-on, you will be able to

- Dynamically render HTML using structural directives.
- Apply conditional CSS using attribute directives.
- Create reusable custom directives.
- Build custom Angular pipes.
- Improve Angular UI using reusable components.
- Format data before displaying it to users.

---

# Conclusion

Hands-On 3 extends the Student Course Portal by introducing Angular Directives and Pipes. Structural directives dynamically control the DOM, attribute directives enhance styling, custom directives add reusable behavior, and custom pipes improve data presentation. These concepts help build clean, maintainable, and interactive Angular applications.

---

**Course:** Digital Nurture 5.0 – .NET Full Stack Engineer

**Module:** Angular (v20.0)

**Hands-On:** 3 – Directives & Custom Pipes
