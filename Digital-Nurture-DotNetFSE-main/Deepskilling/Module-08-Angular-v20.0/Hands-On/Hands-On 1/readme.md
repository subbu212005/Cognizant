# Hands-On 1: Environment Setup, Project Structure & First Component

## Overview

This project is the implementation of **Hands-On 1** from the **Digital Nurture 5.0 - Angular (v20.0)** exercise book.

The objective of this hands-on is to set up the Angular development environment, understand the generated project structure, create reusable components, and build the initial version of the **Student Course Portal** application.

---

## Learning Objectives

- Install and configure Angular CLI.
- Create a new Angular project.
- Understand the Angular project structure.
- Learn the purpose of important configuration files.
- Generate Angular components using Angular CLI.
- Create reusable UI components.
- Display the first Angular application successfully.
- Build and run an Angular application.

---

## Technologies Used

- Angular 20
- TypeScript
- HTML5
- CSS3
- Node.js
- npm
- Visual Studio Code

---

## Software Requirements

- Node.js (LTS)
- Angular CLI 20
- Visual Studio Code
- Chrome Browser

---

## Project Structure

```
Student-Course-Portal/
│
├── public/
│
├── src/
│   ├── app/
│   │
│   ├── components/
│   │   └── header/
│   │
│   ├── pages/
│   │   ├── home/
│   │   ├── course-list/
│   │   └── student-profile/
│   │
│   ├── app.component.*
│   ├── app.config.ts
│   ├── app.routes.ts
│   └── main.ts
│
├── angular.json
├── package.json
├── README.md
├── Notes.md
├── Output.md
└── tsconfig.json
```

---

## Components Created

### Header Component

Displays the navigation bar containing:

- Home
- Courses
- Profile

---

### Home Component

Displays:

- Welcome message
- Student Course Portal title
- Portal description
- Statistics

Example:

- Courses Available : 12
- Enrolled : 3
- GPA : 3.8

---

### Course List Component

Placeholder page for displaying available courses in future hands-ons.

---

### Student Profile Component

Placeholder page for displaying student profile information.

---

## Features Implemented

- Angular project creation using Angular CLI.
- Project successfully builds without errors.
- Header navigation component.
- Home page.
- Reusable Angular components.
- Router outlet configuration.
- Component-based architecture.

---

## Angular CLI Commands Used

### Create Project

```bash
ng new student-course-portal --routing --style=css
```

### Navigate to Project

```bash
cd student-course-portal
```

### Run Application

```bash
ng serve
```

### Build Project

```bash
ng build
```

### Generate Header Component

```bash
ng generate component components/header
```

### Generate Home Component

```bash
ng generate component pages/home
```

### Generate Course List Component

```bash
ng generate component pages/course-list
```

### Generate Student Profile Component

```bash
ng generate component pages/student-profile
```

---

## How to Run

### Install Dependencies

```bash
npm install
```

### Start Development Server

```bash
ng serve
```

Open your browser and visit:

```
http://localhost:4200
```

---

## Expected Output

The application displays:

- Student Course Portal navigation bar
- Welcome heading
- Portal description
- Statistics cards
- Angular application running successfully on localhost

---

## Files Included

- Source Code
- README.md
- Notes.md
- Output.md

---

## Learning Outcome

After completing this hands-on, you will be able to:

- Create Angular projects using Angular CLI.
- Understand Angular project structure.
- Generate Angular components.
- Organize Angular applications using reusable components.
- Configure routing.
- Build and run Angular applications successfully.

---

## Conclusion

Hands-On 1 establishes the foundation for the **Student Course Portal** project. It introduces Angular project creation, project structure, reusable components, and basic application layout. The project created in this exercise will be extended in the subsequent hands-ons to implement routing, forms, services, HTTP communication, state management, and testing.

---

**Course:** Digital Nurture 5.0 – .NET Full Stack Engineer  
**Module:** Angular (v20.0)  
**Hands-On:** 1 – Environment Setup, Project Structure & First Component
