# Custom Pipes in Angular

## Overview

A Custom Pipe is a user-defined pipe that transforms data according to application requirements. While Angular provides several built-in pipes, custom pipes allow developers to implement their own formatting logic.

In this example, we will create a **Reverse Pipe** that reverses a string.

---

# What is a Custom Pipe?

A Custom Pipe is created using the `@Pipe` decorator and implements the `PipeTransform` interface.

**Syntax**

```typescript
@Pipe({
  name: 'reverse',
  standalone: true
})
export class ReversePipe implements PipeTransform {
  transform(value: string): string {
    return value.split('').reverse().join('');
  }
}
```

---

# Step 1: Generate a Pipe

Run the following command:

```bash
ng generate pipe reverse
```

This creates:

```text
src/app/reverse/
├── reverse.ts
└── reverse.spec.ts
```

---

# Step 2: reverse.ts

Replace the generated file with:

```typescript
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'reverse',
  standalone: true
})
export class ReversePipe implements PipeTransform {

  transform(value: string): string {
    return value.split('').reverse().join('');
  }

}
```

---

# Step 3: student.ts

```typescript
import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReversePipe } from '../reverse/reverse';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [CommonModule, ReversePipe],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  message = 'Angular Framework';

}
```

---

# Step 4: student.html

```html
<h2>Custom Pipe Example</h2>

<p><b>Original Text:</b> {{ message }}</p>

<p><b>Reversed Text:</b> {{ message | reverse }}</p>
```

---

# Step 5: student.css

```css
h2 {
    color: darkblue;
}

p {
    font-size: 18px;
}
```

---

# Expected Output

```text
Custom Pipe Example

Original Text:
Angular Framework

Reversed Text:
krowemarF ralugnA
```

---

# Advantages

* Reusable transformation logic
* Cleaner templates
* Easy maintenance
* Improves code readability

---

# Interview Questions

1. What is a Custom Pipe?
2. What is `PipeTransform`?
3. How do you create a Custom Pipe?
4. Difference between Built-in and Custom Pipes?
5. Can a pipe accept parameters?

---

# Summary

Custom Pipes enable developers to define reusable data transformations tailored to specific application needs.

---

# Learning Outcome

After completing this exercise, you will be able to:

* Create a Custom Pipe.
* Implement the `PipeTransform` interface.
* Use custom pipes in Angular templates.
* Reuse custom data transformations across components.
