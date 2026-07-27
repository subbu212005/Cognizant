# Hands-On 6: Services & Dependency Injection

## Overview

This project is the implementation of **Hands-On 6** from the **Digital Nurture 5.0 – Angular (v20.0)** exercise book.

In this hands-on, the **Student Course Portal** is enhanced by introducing **Angular Services** and **Dependency Injection (DI)**. Shared application data is moved from components into services, allowing multiple components to access the same data through a singleton service. The project also demonstrates service-to-service injection and hierarchical dependency injection.

---

## Learning Objectives

- Understand Angular Services
- Understand Dependency Injection (DI)
- Create Singleton Services
- Use `providedIn: 'root'`
- Inject Services into Components
- Inject Services into Services
- Share Data Between Components
- Implement Hierarchical Dependency Injection
- Create Component-Level Providers

---

## Technologies Used

- Angular 20
- TypeScript
- HTML5
- CSS3
- Angular Dependency Injection
- Angular Services

---

## Prerequisites

- Hands-On 1 completed
- Hands-On 2 completed
- Hands-On 3 completed
- Hands-On 4 completed
- Hands-On 5 completed

---

# Project Structure

```
Student-Course-Portal/
│
├── src/
│
├── app/
│
│── app.component.ts
│── app.component.html
│── app.component.css
│── app.component.spec.ts
│
│── app.routes.ts
│── app.config.ts
│
├── models/
│   └── course.ts
│
├── validators/
│   └── course-code.validator.ts
│
├── services/
│   ├── course.service.ts
│   ├── course.service.spec.ts
│   ├── enrollment.service.ts
│   ├── enrollment.service.spec.ts
│   ├── notification.service.ts
│   └── notification.service.spec.ts
│
├── components/
│   ├── header/
│   ├── course-card/
│   ├── course-summary-widget/
│   └── notification/
│
├── directives/
│   └── highlight/
│
├── pipes/
│   └── credit-label/
│
├── pages/
│   ├── home/
│   ├── course-list/
│   ├── student-profile/
│   ├── enrollment-form/
│   └── reactive-enrollment-form/
│
├── assets/
│   └── images/
│
├── README.md
├── Notes.md
└── Output.md
```

---

# Topics Covered

- Angular Services
- Dependency Injection
- Singleton Service
- providedIn: 'root'
- Service Injection
- Service-to-Service Injection
- Shared Data Store
- Component Providers
- Hierarchical DI

---

# Services Created

## CourseService

Stores all course information.

Methods

- getCourses()
- getCourseById()
- addCourse()

---

## EnrollmentService

Maintains enrolled courses.

Methods

- enroll()
- unenroll()
- isEnrolled()
- getEnrolledCourses()

---

## NotificationService

Displays notifications.

Used to demonstrate

- Component-Level Provider
- Hierarchical Dependency Injection

---

# Features Implemented

## Course Management

- Display all courses
- Add course
- Find course
- Shared course list

---

## Enrollment

Students can

- Enroll
- Unenroll

Student Profile automatically displays enrolled courses.

---

## Shared Service

The following components use the same CourseService instance:

- Home
- Course List
- Course Summary Widget

Any change in one component is reflected in the others.

---

## Dependency Injection

Implemented

```typescript
constructor(
private courseService: CourseService
){}
```

---

## Service-to-Service Injection

EnrollmentService injects

```
CourseService
```

to retrieve complete course information.

---

## Component-Level Provider

NotificationComponent creates

```
NotificationService
```

using

```typescript
providers:[
NotificationService
]
```

Each NotificationComponent has its own instance.

---

# Angular CLI Commands

Generate Course Service

```bash
ng generate service services/course
```

Generate Enrollment Service

```bash
ng generate service services/enrollment
```

Generate Notification Service

```bash
ng generate service services/notification
```

Generate Course Summary Widget

```bash
ng generate component components/course-summary-widget
```

Generate Notification Component

```bash
ng generate component components/notification
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
CourseService Created
        │
        ▼
Home Component
        │
        ▼
Course List Component
        │
        ▼
Course Summary Widget
        │
        ▼
Shared Course Data
        │
        ▼
Enroll Course
        │
        ▼
EnrollmentService Updates
        │
        ▼
Student Profile Updates
```

---

# Expected Output

Home Page

```
Courses Available : 5
```

Course List

```
Angular Basics

Enroll
```

After Clicking

```
Unenroll
```

Student Profile

```
Enrolled Courses

Angular Basics

Data Structures

Database Systems
```

---

# Angular Concepts Demonstrated

- Services
- Dependency Injection
- Singleton Pattern
- providedIn: 'root'
- Component Providers
- Hierarchical DI
- Service Injection
- Service-to-Service Injection

---

# Files Included

- Source Code
- README.md
- Notes.md
- Output.md

---

# Learning Outcome

After completing this hands-on, you will be able to:

- Create reusable Angular services.
- Share data across components.
- Understand Angular Dependency Injection.
- Create singleton services.
- Inject one service into another.
- Use component-level providers.
- Build maintainable Angular applications.

---

# Conclusion

Hands-On 6 introduces Angular Services and Dependency Injection, allowing business logic and shared data to be separated from components. This improves code reusability, maintainability, and scalability while demonstrating both singleton and component-scoped service instances.

---

**Course:** Digital Nurture 5.0 – .NET Full Stack Engineer

**Module:** Angular (v20.0)

**Hands-On:** 6 – Services & Dependency Injection
