# Property Binding in Angular

## Overview

Property Binding is a one-way data binding technique in Angular that allows data to flow **from the component (TypeScript) to the view (HTML)**.

It is used to dynamically set the value of HTML element properties such as `src`, `href`, `disabled`, `value`, and many others.

The syntax for property binding is:

```html
[property]="expression"
```

Angular evaluates the expression and assigns its value to the specified HTML property.

---

# Why Property Binding?

Property Binding helps create dynamic web applications by allowing the UI to update automatically when component data changes.

### Advantages

* One-way data flow
* Dynamic UI updates
* Better readability
* Easy to maintain
* Improved performance

---

# Syntax

```html
[property]="expression"
```

Examples:

```html
<img [src]="imageUrl">

<button [disabled]="isDisabled">Submit</button>

<input [value]="studentName">
```

---

# Example

## student.ts

```typescript
import { Component } from '@angular/core';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  studentName = "John Doe";
  department = "Computer Science";
  rollNumber = 101;
  isDisabled = false;

}
```

---

## student.html

```html
<h2>Student Information</h2>

<p><strong>Name:</strong> {{ studentName }}</p>

<p><strong>Department:</strong> {{ department }}</p>

<p><strong>Roll Number:</strong> {{ rollNumber }}</p>

<button [disabled]="isDisabled">
    Submit
</button>
```

---

# Output

```
Student Information

Name: John Doe

Department: Computer Science

Roll Number: 101

[Submit]
```

---

# Common Uses

* Image source
* Button enable/disable
* Input value
* Hyperlinks
* CSS classes
* Styles

---

# Interview Questions

1. What is Property Binding?
2. What is the syntax of Property Binding?
3. Is Property Binding one-way or two-way?
4. Difference between Interpolation and Property Binding?
5. Give examples of Property Binding.

---

# Summary

Property Binding allows Angular applications to bind component data to HTML element properties. It is an essential feature for building dynamic and interactive user interfaces.

---

# Learning Outcome

After completing this topic, you will be able to:

* Understand Property Binding.
* Use `[property]="expression"` syntax.
* Bind component data to HTML elements.
* Build dynamic Angular user interfaces.
