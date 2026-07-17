# Module 03 – Directives and Pipes

## Overview

This module introduces **Angular Directives** and **Pipes**, two essential features used to create dynamic, interactive, and user-friendly web applications. Directives modify the structure or appearance of HTML elements, while Pipes transform data for display in Angular templates.

Through practical examples, this module demonstrates how to use built-in directives, create custom directives, apply built-in pipes, and develop custom pipes.

---

# Learning Objectives

After completing this module, you will be able to:

* Understand the purpose of Angular Directives.
* Use Structural Directives (`*ngIf`, `*ngFor`, `*ngSwitch`).
* Use Attribute Directives (`ngClass`, `ngStyle`).
* Create Custom Directives.
* Understand Angular Pipes.
* Use Built-in Pipes.
* Create Custom Pipes.
* Improve code reusability and maintainability.

---

# Folder Structure

```text
03-Directives-and-Pipes
│
├── README.md
│
├── 01-Structural-Directives
│   ├── AngularDemo/
│   ├── README.md
│   ├── Output.txt
│   └── Output.png
│
├── 02-Attribute-Directives
│   ├── AngularDemo/
│   ├── README.md
│   ├── Output.txt
│   └── Output.png
│
├── 03-Custom-Directives
│   ├── AngularDemo/
│   ├── README.md
│   ├── Output.txt
│   └── Output.png
│
├── 04-Built-in-Pipes
│   ├── AngularDemo/
│   ├── README.md
│   ├── Output.txt
│   └── Output.png
│
└── 05-Custom-Pipes
    ├── AngularDemo/
    ├── README.md
    ├── Output.txt
    └── Output.png
```

---

# Topics Covered

## 1. Structural Directives

Structural Directives modify the layout of the DOM by adding or removing HTML elements.

### Directives Covered

* `*ngIf`
* `*ngFor`
* `*ngSwitch`

### Example

* Display content conditionally using `*ngIf`.
* Display a list using `*ngFor`.
* Switch between multiple views using `*ngSwitch`.

---

## 2. Attribute Directives

Attribute Directives change the appearance or behavior of existing HTML elements without modifying the DOM structure.

### Directives Covered

* `ngClass`
* `ngStyle`

### Example

* Apply CSS classes dynamically.
* Apply inline styles dynamically.

---

## 3. Custom Directives

Custom Directives allow developers to define reusable behavior for HTML elements.

### Example

A Highlight Directive that:

* Changes the background color on mouse hover.
* Restores the original color when the mouse leaves.

---

## 4. Built-in Pipes

Built-in Pipes transform data for presentation.

### Pipes Covered

* `uppercase`
* `lowercase`
* `titlecase`
* `date`
* `currency`
* `percent`
* `json`

### Example

* Format text.
* Display dates.
* Display currency.
* Display percentages.
* Display JSON objects.

---

## 5. Custom Pipes

Custom Pipes allow developers to create their own reusable data transformations.

### Example

Reverse Pipe

Input:

```text
Angular Framework
```

Output:

```text
krowemarF ralugnA
```

---

# Prerequisites

Before starting this module, ensure you have:

* Node.js installed
* Angular CLI installed
* Visual Studio Code
* Basic knowledge of HTML, CSS, TypeScript, and Angular Components

---

# How to Run the Project

Navigate to the Angular project folder:

```bash
cd AngularDemo
```

Install dependencies (if required):

```bash
npm install
```

Run the development server:

```bash
ng serve
```

Open your browser and visit:

```text
http://localhost:4200/
```

---

# Skills Gained

By completing this module, you will gain the ability to:

* Build dynamic Angular user interfaces.
* Use built-in Angular directives.
* Apply dynamic styling.
* Create reusable custom directives.
* Format application data using pipes.
* Create custom data transformation logic.
* Develop cleaner and more maintainable Angular applications.

---

# Interview Questions

1. What are Angular Directives?
2. What is the difference between Structural and Attribute Directives?
3. What is the purpose of `*ngIf`?
4. Explain `*ngFor` with an example.
5. What is `ngClass`?
6. What is `ngStyle`?
7. What are Custom Directives?
8. What are Angular Pipes?
9. Name some Built-in Pipes.
10. What is the difference between Built-in Pipes and Custom Pipes?
11. What is the purpose of `PipeTransform`?
12. How do you create a Custom Pipe?

---

# Summary

This module provided hands-on experience with Angular Directives and Pipes. You learned how to control the DOM using Structural Directives, modify element appearance using Attribute Directives, build reusable Custom Directives, format data with Built-in Pipes, and implement your own Custom Pipes. These concepts are fundamental for developing modern Angular applications.

---

# Learning Outcome

After successfully completing this module, you will be able to:

* Use Structural Directives effectively.
* Apply Attribute Directives for dynamic styling.
* Create reusable Custom Directives.
* Transform data using Built-in Pipes.
* Develop Custom Pipes for application-specific requirements.
* Build cleaner, reusable, and maintainable Angular applications using Angular best practices.
