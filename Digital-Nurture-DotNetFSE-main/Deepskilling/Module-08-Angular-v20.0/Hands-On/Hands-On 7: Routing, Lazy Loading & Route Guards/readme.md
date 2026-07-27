# Hands-On 7: Routing, Lazy Loading & Route Guards

## Overview

This project is the implementation of **Hands-On 7** from the **Digital Nurture 5.0 – Angular (v20.0)** exercise book.

In this hands-on, the **Student Course Portal** is upgraded into a complete Single Page Application (SPA) using Angular Routing. Navigation between pages is implemented with the Angular Router, dynamic route parameters are used to display course details, lazy loading improves application performance, and route guards protect secured pages and prevent accidental navigation away from unsaved forms.

---

## Learning Objectives

- Understand Angular Routing
- Configure Routes
- Navigate Between Components
- Use Route Parameters
- Use Query Parameters
- Create Nested Routes
- Implement Lazy Loading
- Create CanActivate Guard
- Create CanDeactivate Guard
- Handle 404 (Not Found) Routes

---

## Technologies Used

- Angular 20
- TypeScript
- Angular Router
- Lazy Loading
- Route Guards
- HTML5
- CSS3

---

## Prerequisites

- Hands-On 1 completed
- Hands-On 2 completed
- Hands-On 3 completed
- Hands-On 4 completed
- Hands-On 5 completed
- Hands-On 6 completed

---

# Topics Covered

- Angular Routing
- RouterLink
- RouterOutlet
- Route Parameters
- Query Parameters
- Nested Routes
- Lazy Loading
- CanActivate Guard
- CanDeactivate Guard
- Wildcard Route
- Navigation

---

# Features Implemented

## Home Page

```
/
```

Displays

- Dashboard
- Student Portal Overview

---

## Course List

```
/courses
```

Displays all available courses.

---

## Course Detail

```
/courses/:id
```

Displays

- Course Name
- Course Code
- Credits
- Status

---

## Student Profile

```
/profile
```

Protected by

```
Auth Guard
```

---

## Enrollment Module

```
/enroll
```

Loaded lazily.

---

## Search Query

Example

```
/courses?search=Angular
```

---

## 404 Page

```
**
```

Displays

```
Page Not Found
```

---

# Route Guards

## CanActivate

Protects

- Profile
- Enrollment

Redirects to

```
Home
```

if user is not logged in.

---

## CanDeactivate

Checks

```
Reactive Enrollment Form
```

If unsaved changes exist

↓

Shows

```
You have unsaved changes.
Leave this page?
```

---

# Lazy Loading

Enrollment feature loads only when

```
/enroll
```

is visited.

Improves

- Initial loading speed
- Bundle size
- Performance

---

# Angular CLI Commands

Generate Course Detail

```bash
ng generate component pages/course-detail
```

Generate Courses Layout

```bash
ng generate component pages/courses-layout
```

Generate Not Found

```bash
ng generate component pages/not-found
```

Generate Auth Guard

```bash
ng generate guard guards/auth
```

Generate Unsaved Changes Guard

```bash
ng generate guard guards/unsaved-changes
```

Generate Enrollment Module

```bash
ng generate module features/enrollment --routing
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

# Application Workflow

```
Application Starts
        │
        ▼
Home Page
        │
        ▼
Courses
        │
        ▼
Course Details
        │
        ▼
Student Profile
        │
        ▼
Protected by Auth Guard
        │
        ▼
Enrollment Module
        │
        ▼
Loaded Lazily
        │
        ▼
Unsaved Changes Guard
```

---

# Angular Concepts Demonstrated

- Angular Router
- RouterLink
- RouterOutlet
- ActivatedRoute
- Router
- Route Parameters
- Query Parameters
- Nested Routes
- Lazy Loading
- Feature Module
- CanActivate
- CanDeactivate

---

# Expected Output

```
Home

Courses

Profile

Enroll

--------------------------------

Courses

Angular

Java

Spring

Click

↓

Course Details

↓

Enroll

↓

Protected Route

↓

Confirmation Dialog
```

---

# Files Included

- Source Code
- README.md
- Notes.md
- Output.md

---

# Learning Outcome

After completing this hands-on, you will be able to:

- Configure Angular Routing.
- Create nested routes.
- Pass route parameters.
- Read query parameters.
- Implement lazy loading.
- Secure routes using guards.
- Prevent accidental navigation using CanDeactivate.

---

# Conclusion

Hands-On 7 transforms the Student Course Portal into a fully navigable Angular Single Page Application (SPA). Routing enables seamless navigation, lazy loading improves performance, and route guards enhance security and user experience.

---

**Course:** Digital Nurture 5.0 – .NET Full Stack Engineer

**Module:** Angular (v20.0)

**Hands-On:** 7 – Routing, Lazy Loading & Route Guards
