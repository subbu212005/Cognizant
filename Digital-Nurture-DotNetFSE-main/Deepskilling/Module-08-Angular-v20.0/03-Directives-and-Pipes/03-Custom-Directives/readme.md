# Custom Directives in Angular

## Overview

Custom Directives allow developers to create their own reusable behavior that can be applied to HTML elements. They are useful when the built-in Angular directives do not meet application requirements.

A custom directive can change the appearance or behavior of an element in response to user actions such as hovering, clicking, or focusing.

---

# What is a Custom Directive?

A Custom Directive is a user-defined directive created using the `@Directive` decorator.

It allows developers to:

* Modify element styles
* Handle events
* Reuse UI behavior
* Improve code reusability

---

# Example: Highlight Directive

In this example, a custom directive changes the background color of an element when the mouse pointer moves over it.

---

## Step 1: Create the Directive

Run the following command:

```bash
ng generate directive highlight
```

Angular creates:

```
src/app/highlight/
├── highlight.ts
└── highlight.spec.ts
```

---

## Step 2: highlight.ts

```typescript
import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appHighlight]',
  standalone: true
})
export class HighlightDirective {

  constructor(private element: ElementRef) {}

  @HostListener('mouseenter')
  onMouseEnter() {
    this.element.nativeElement.style.backgroundColor = 'yellow';
    this.element.nativeElement.style.color = 'red';
  }

  @HostListener('mouseleave')
  onMouseLeave() {
    this.element.nativeElement.style.backgroundColor = '';
    this.element.nativeElement.style.color = '';
  }
}
```

---

## Step 3: student.ts

```typescript
import { Component } from '@angular/core';
import { HighlightDirective } from '../highlight/highlight';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [HighlightDirective],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {
}
```

---

## Step 4: student.html

```html
<h2>Custom Directive Example</h2>

<p appHighlight>
    Move the mouse over this text.
</p>
```

---

## Output

Initially:

```
Custom Directive Example

Move the mouse over this text.
```

When the mouse pointer is placed over the paragraph:

* Background becomes Yellow
* Text becomes Red

When the mouse leaves:

* Original appearance is restored.

---

# Advantages

* Reusable
* Cleaner code
* Easy maintenance
* Better UI interaction
* Improves user experience

---

# Interview Questions

1. What is a Custom Directive?
2. Difference between Component and Directive?
3. What is `@Directive`?
4. What is `ElementRef`?
5. What is `HostListener`?
6. Why are custom directives used?

---

# Summary

Custom Directives extend Angular by allowing developers to define reusable behavior that can be attached to HTML elements.

---

# Learning Outcome

After completing this exercise, you will be able to:

* Create a custom directive.
* Use `ElementRef`.
* Use `HostListener`.
* Apply reusable behavior to HTML elements.
