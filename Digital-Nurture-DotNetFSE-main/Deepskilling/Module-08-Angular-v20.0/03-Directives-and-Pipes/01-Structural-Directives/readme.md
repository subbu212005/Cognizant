# Structural Directives in Angular

## Overview

Structural Directives are special Angular directives that change the structure of the DOM (Document Object Model). They can add, remove, or manipulate HTML elements dynamically based on conditions or data.

Angular provides three built-in structural directives:

* `*ngIf`
* `*ngFor`
* `*ngSwitch`

Structural directives are identified by the `*` (asterisk) symbol.

---

# What are Structural Directives?

Structural Directives control how HTML elements are rendered in the browser.

They can:

* Show or hide elements
* Repeat elements
* Display different views based on conditions

---

# 1. *ngIf Directive

The `*ngIf` directive displays an element only if the given condition is **true**.

### Syntax

```html
<div *ngIf="isLoggedIn">
  Welcome User
</div>
```

---

# 2. *ngFor Directive

The `*ngFor` directive repeats an HTML element for each item in a collection.

### Syntax

```html
<li *ngFor="let student of students">
  {{ student }}
</li>
```

---

# 3. *ngSwitch Directive

The `*ngSwitch` directive displays different HTML blocks based on a matching value.

### Syntax

```html
<div [ngSwitch]="role">

  <p *ngSwitchCase="'Admin'">Administrator</p>

  <p *ngSwitchCase="'Student'">Student User</p>

  <p *ngSwitchDefault>Guest User</p>

</div>
```

---

# Example

## student.ts

```typescript
import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  isLoggedIn = true;

  students = [
    'John',
    'Rahul',
    'Priya',
    'Anjali'
  ];

  role = 'Student';

}
```

---

## student.html

```html
<h2>Structural Directives Example</h2>

<h3>*ngIf</h3>

<p *ngIf="isLoggedIn">
  Welcome to Angular!
</p>

<hr>

<h3>*ngFor</h3>

<ul>
  <li *ngFor="let student of students">
    {{ student }}
  </li>
</ul>

<hr>

<h3>*ngSwitch</h3>

<div [ngSwitch]="role">

  <p *ngSwitchCase="'Admin'">
    Administrator Login
  </p>

  <p *ngSwitchCase="'Student'">
    Student Login
  </p>

  <p *ngSwitchDefault>
    Guest User
  </p>

</div>
```

---

## student.css

```css
h2{
    color:darkblue;
}

h3{
    color:green;
}

ul{
    margin-left:20px;
}
```

---

# Output

```
Structural Directives Example

*ngIf

Welcome to Angular!

-------------------------

*ngFor

• John
• Rahul
• Priya
• Anjali

-------------------------

*ngSwitch

Student Login
```

---

# Advantages

* Dynamic DOM manipulation
* Cleaner templates
* Better readability
* Easy conditional rendering
* Efficient list rendering

---

# Interview Questions

1. What are Structural Directives?
2. Why do Structural Directives use `*`?
3. Explain `*ngIf`.
4. Explain `*ngFor`.
5. Explain `*ngSwitch`.
6. Difference between Structural and Attribute Directives?

---

# Summary

Structural Directives modify the layout of the DOM by adding, removing, or repeating elements. They are essential for creating dynamic Angular applications.

---

# Learning Outcome

After completing this topic, you will be able to:

* Use `*ngIf`.
* Use `*ngFor`.
* Use `*ngSwitch`.
* Dynamically control the DOM.
* Build interactive Angular templates.
