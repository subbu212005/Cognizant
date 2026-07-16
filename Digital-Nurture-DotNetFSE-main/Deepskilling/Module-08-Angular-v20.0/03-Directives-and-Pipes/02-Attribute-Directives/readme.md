# Attribute Directives in Angular

## Overview

Attribute Directives are Angular directives that modify the appearance or behavior of an existing HTML element without changing the structure of the DOM.

Unlike Structural Directives (`*ngIf`, `*ngFor`, `*ngSwitch`), Attribute Directives do not add or remove elements. Instead, they change styles, classes, or behavior.

Angular provides several built-in Attribute Directives such as:

* `ngClass`
* `ngStyle`

---

# What are Attribute Directives?

Attribute Directives change the appearance or behavior of an HTML element.

Examples:

* Change text color
* Apply CSS classes
* Apply inline styles
* Highlight elements

---

# Built-in Attribute Directives

## 1. ngClass

The `ngClass` directive dynamically adds or removes CSS classes.

### Syntax

```html
<div [ngClass]="{'highlight': isHighlighted}">
  Angular Directives
</div>
```

---

## 2. ngStyle

The `ngStyle` directive dynamically applies inline styles.

### Syntax

```html
<p [ngStyle]="{'color':'blue','font-size':'20px'}">
  Welcome to Angular
</p>
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

  isHighlighted = true;

}
```

---

## student.html

```html
<h2>Attribute Directives Example</h2>

<p [ngClass]="{'highlight': isHighlighted}">
    This text uses ngClass.
</p>

<p [ngStyle]="{
    'color':'blue',
    'font-size':'20px',
    'font-weight':'bold'
}">
    This text uses ngStyle.
</p>
```

---

## student.css

```css
h2{
    color:darkblue;
}

.highlight{
    background-color:yellow;
    color:red;
    padding:10px;
    border-radius:5px;
}
```

---

# Output

```text
Attribute Directives Example

This text uses ngClass.

This text uses ngStyle.
```

The first paragraph has a yellow background and red text using `ngClass`.

The second paragraph is blue, bold, and larger using `ngStyle`.

---

# Advantages

* Dynamic styling
* Cleaner HTML
* Reusable CSS classes
* Better UI customization
* Improved readability

---

# Difference Between Structural and Attribute Directives

| Structural Directives | Attribute Directives          |
| --------------------- | ----------------------------- |
| Modify DOM structure  | Modify element appearance     |
| Use `*` symbol        | Use property binding          |
| Example: `*ngIf`      | Example: `ngClass`, `ngStyle` |

---

# Interview Questions

1. What are Attribute Directives?
2. What is the purpose of `ngClass`?
3. What is the purpose of `ngStyle`?
4. Difference between Structural and Attribute Directives?
5. Can `ngClass` apply multiple CSS classes?

---

# Summary

Attribute Directives modify the appearance and behavior of existing HTML elements. `ngClass` is used for applying CSS classes dynamically, while `ngStyle` applies inline styles dynamically.

---

# Learning Outcome

After completing this topic, you will be able to:

* Understand Attribute Directives.
* Use `ngClass`.
* Use `ngStyle`.
* Apply dynamic styles to Angular components.
