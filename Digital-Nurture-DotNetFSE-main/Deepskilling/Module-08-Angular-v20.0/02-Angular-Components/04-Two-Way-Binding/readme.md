# Two-Way Data Binding in Angular

## Overview

Two-Way Data Binding is an Angular feature that synchronizes data between the **Component (TypeScript)** and the **View (HTML)**. Any change made in the input field updates the component automatically, and any change in the component updates the view.

Angular implements Two-Way Data Binding using the **`[(ngModel)]`** directive.

---

# What is Two-Way Data Binding?

Two-Way Data Binding combines:

* Property Binding (Component → View)
* Event Binding (View → Component)

This creates automatic synchronization between the UI and the component.

---

# Syntax

```html
[(ngModel)]="property"
```

---

# Prerequisites

To use `ngModel`, import `FormsModule`.

## app.ts

```typescript
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { StudentComponent } from './student/student';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [StudentComponent, FormsModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App { }
```

---

# Example

## student.ts

```typescript
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  studentName = "John Doe";

}
```

---

## student.html

```html
<h2>Two-Way Data Binding Example</h2>

<label>Enter Student Name:</label>
<br><br>

<input type="text" [(ngModel)]="studentName">

<p><strong>Student Name:</strong> {{ studentName }}</p>
```

---

## student.css

```css
h2{
    color: purple;
}

input{
    padding:8px;
    width:250px;
    margin-bottom:15px;
}

p{
    font-weight:bold;
}
```

---

# Output

Initially:

```text
Two-Way Data Binding Example

Enter Student Name:

John Doe

Student Name: John Doe
```

If the user types:

```text
Rahul Sharma
```

The output immediately becomes:

```text
Student Name: Rahul Sharma
```

No button click or page refresh is required.

---

# Advantages

* Automatic synchronization
* Less code
* Easy form handling
* Better user experience
* Faster development

---

# Difference Between Data Binding Types

| Type             | Syntax  | Direction        |
| ---------------- | ------- | ---------------- |
| Interpolation    | `{{ }}` | Component → View |
| Property Binding | `[ ]`   | Component → View |
| Event Binding    | `( )`   | View → Component |
| Two-Way Binding  | `[( )]` | Both Directions  |

---

# Common Use Cases

* Login Forms
* Registration Forms
* Search Boxes
* User Profile Editing
* Feedback Forms

---

# Interview Questions

1. What is Two-Way Data Binding?
2. Which directive is used for Two-Way Data Binding?
3. Why is `FormsModule` required?
4. Difference between Property Binding and Two-Way Binding?
5. What is the syntax of `ngModel`?

---

# Summary

Two-Way Data Binding keeps the component and the user interface synchronized automatically using `[(ngModel)]`. It is widely used in Angular forms to provide a smooth and interactive user experience.

---

# Learning Outcome

After completing this topic, you will be able to:

* Explain Two-Way Data Binding.
* Use the `[(ngModel)]` directive.
* Import `FormsModule`.
* Synchronize component data with user input.
