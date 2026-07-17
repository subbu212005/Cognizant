# Built-in Pipes in Angular

## Overview

Pipes in Angular are used to transform data directly in templates without changing the original value. Angular provides several built-in pipes to format text, numbers, dates, currency, percentages, and JSON data.

---

# What are Pipes?

A Pipe takes input data and transforms it into a desired format for display.

**Syntax:**

```html
{{ value | pipeName }}
```

---

# Common Built-in Pipes

* UpperCasePipe (`uppercase`)
* LowerCasePipe (`lowercase`)
* TitleCasePipe (`titlecase`)
* DatePipe (`date`)
* CurrencyPipe (`currency`)
* PercentPipe (`percent`)
* JsonPipe (`json`)

---

# student.ts

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

  name = 'angular framework';
  today = new Date();
  salary = 50000;
  percentage = 0.85;

  student = {
    id: 101,
    name: 'John',
    department: 'Computer Science'
  };

}
```

---

# student.html

```html
<h2>Built-in Pipes Example</h2>

<p><b>Uppercase:</b> {{ name | uppercase }}</p>

<p><b>Lowercase:</b> {{ name | lowercase }}</p>

<p><b>Titlecase:</b> {{ name | titlecase }}</p>

<p><b>Date:</b> {{ today | date:'fullDate' }}</p>

<p><b>Currency:</b> {{ salary | currency:'INR' }}</p>

<p><b>Percent:</b> {{ percentage | percent }}</p>

<p><b>JSON:</b></p>

<pre>{{ student | json }}</pre>
```

---

# student.css

```css
h2 {
    color: darkblue;
}

p {
    font-size: 18px;
}

pre {
    background-color: #f2f2f2;
    padding: 10px;
    border-radius: 5px;
}
```

---

# Expected Output

```text
Built-in Pipes Example

Uppercase: ANGULAR FRAMEWORK
Lowercase: angular framework
Titlecase: Angular Framework
Date: Friday, July 17, 2026
Currency: ₹50,000.00
Percent: 85%

JSON:
{
  "id": 101,
  "name": "John",
  "department": "Computer Science"
}
```

---

# Advantages

* Formats data without modifying the original value.
* Improves readability.
* Reduces manual formatting code.
* Built into Angular.

---

# Interview Questions

1. What are Pipes in Angular?
2. What is the syntax of a Pipe?
3. Name five built-in pipes.
4. Difference between built-in and custom pipes.
5. What is JsonPipe?

---

# Summary

Built-in Pipes help transform and display data in different formats directly within Angular templates.

---

# Learning Outcome

After completing this exercise, you will be able to:

* Use Angular built-in pipes.
* Format strings, dates, currency, percentages, and JSON.
* Improve the presentation of application data.
