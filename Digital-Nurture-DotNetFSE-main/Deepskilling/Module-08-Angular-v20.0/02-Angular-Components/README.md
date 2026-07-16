# Module 08 - Angular (v20.0)

# 02 - Angular Components

## Overview

Angular Components are the fundamental building blocks of every Angular application. Each component represents a portion of the user interface (UI) and consists of a TypeScript class, an HTML template, and CSS styles.

Components make Angular applications modular, reusable, maintainable, and easy to test. They communicate with each other through data binding, input/output properties, and lifecycle hooks.

This section covers the core concepts of Angular Components, including component creation, data binding, lifecycle hooks, and parent-child communication.

---

# Learning Objectives

After completing this section, you will be able to:

* Understand Angular Components and their architecture.
* Create components using Angular CLI.
* Implement Property Binding.
* Handle user interactions using Event Binding.
* Apply Two-Way Data Binding using `ngModel`.
* Understand Angular Component Lifecycle Hooks.
* Implement Parent-Child Communication using `@Input()` and `@Output()`.

---

# Folder Structure

```text id="klnc5y"
02-Angular-Components
│
├── 01-Creating-Components
├── 02-Property-Binding
├── 03-Event-Binding
├── 04-Two-Way-Binding
├── 05-Component-Lifecycle
└── 06-Parent-Child-Communication
```

---

# Topics Covered

## 01 - Creating Components

Learn how to create reusable Angular components using Angular CLI.

### Key Concepts

* Angular Components
* Angular CLI
* Component Files
* Component Decorator
* Component Selector

---

## 02 - Property Binding

Learn how to bind data from the component to the HTML view.

### Key Concepts

* One-Way Data Binding
* HTML Property Binding
* Dynamic UI Updates
* `[property]="value"`

---

## 03 - Event Binding

Learn how Angular handles user events.

### Key Concepts

* Click Events
* Keyboard Events
* Mouse Events
* `(event)="method()"`

---

## 04 - Two-Way Data Binding

Synchronize data between the component and the HTML view.

### Key Concepts

* `[(ngModel)]`
* FormsModule
* Automatic UI Updates
* Form Controls

---

## 05 - Component Lifecycle

Understand the lifecycle of Angular components.

### Lifecycle Hooks Covered

* constructor()
* ngOnInit()
* ngOnChanges()
* ngDoCheck()
* ngAfterViewInit()
* ngAfterViewChecked()
* ngOnDestroy()

---

## 06 - Parent-Child Communication

Exchange data between Angular components.

### Key Concepts

* @Input()
* @Output()
* EventEmitter
* Component Communication

---

# Prerequisites

Before starting this module, you should know:

* HTML
* CSS
* JavaScript
* TypeScript Basics
* Angular CLI
* Angular Project Structure

---

# Software Requirements

* Node.js
* npm
* Angular CLI
* Visual Studio Code
* Google Chrome

---

# Commands Used

### Create Component

```bash id="xdlz8i"
ng generate component student
```

or

```bash id="hl0yt9"
ng g c student
```

### Run Application

```bash id="m6mvwy"
ng serve
```

### Build Application

```bash id="9wd4lo"
ng build
```

---

# Skills Gained

After completing this section, you will be able to:

* Create Angular Components.
* Build reusable UI elements.
* Use Property Binding.
* Handle events using Event Binding.
* Implement Two-Way Data Binding.
* Understand Angular Lifecycle Hooks.
* Pass data between components.
* Develop modular Angular applications.

---

# Real-World Applications

Angular Components are widely used in:

* Student Management Systems
* E-Commerce Websites
* Banking Applications
* Healthcare Portals
* Inventory Management Systems
* CRM Applications
* Enterprise Dashboards
* HR Management Systems

---

# Interview Questions

1. What is an Angular Component?
2. What files are generated when creating a component?
3. What is the purpose of the `@Component` decorator?
4. Explain Property Binding.
5. Explain Event Binding.
6. What is Two-Way Data Binding?
7. What is `ngModel`?
8. Explain Angular Lifecycle Hooks.
9. What is the difference between `constructor()` and `ngOnInit()`?
10. Explain Parent-Child Communication.
11. What is `@Input()`?
12. What is `@Output()`?
13. What is `EventEmitter`?
14. Difference between Property Binding and Event Binding?
15. Difference between One-Way and Two-Way Data Binding?

---

# Summary

Angular Components form the core of every Angular application. They help developers create modular, reusable, and maintainable user interfaces. By understanding components, data binding, lifecycle hooks, and component communication, developers can build scalable and interactive web applications using Angular.

---

# Learning Outcome

After completing this section, you will be able to:

* Create and manage Angular Components.
* Implement different types of data binding.
* Handle user interactions.
* Understand the Angular Component Lifecycle.
* Communicate between parent and child components.
* Build reusable and scalable Angular applications using component-based architecture.
