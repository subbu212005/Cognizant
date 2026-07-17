# Singleton Services in Angular

## Overview

A Singleton Service is a service for which Angular creates only one instance during the application's lifetime. All components that inject the service share the same instance.

Using singleton services improves memory usage, ensures consistent shared data, and simplifies state management.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand Singleton Services.
- Learn how Angular creates a single service instance.
- Use `providedIn: 'root'`.
- Share data using a singleton service.

---

## What is a Singleton Service?

A Singleton Service is created only once by Angular's Dependency Injection system.

```typescript
@Injectable({
  providedIn: 'root'
})
```

The same service instance is shared throughout the application.

---

## Step 1: Update student-data.service.ts

```typescript
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentDataService {

  private count = 0;

  increment() {
    this.count++;
  }

  getCount() {
    return this.count;
  }

}
```

---

## Step 2: Update student.ts

```typescript
import { Component } from '@angular/core';
import { StudentDataService } from '../student-data.service';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  count = 0;

  constructor(private studentService: StudentDataService) {}

  increaseCount() {
    this.studentService.increment();
    this.count = this.studentService.getCount();
  }

}
```

---

## Step 3: Update student.html

```html
<h2>Singleton Service Example</h2>

<p>Counter: {{ count }}</p>

<button (click)="increaseCount()">
    Increment Counter
</button>
```

---

## Step 4: Update student.css

```css
h2{
    color: darkblue;
}

p{
    color: green;
    font-size:20px;
    font-weight:bold;
}

button{
    padding:10px 18px;
    font-size:16px;
    cursor:pointer;
}
```

---

## Expected Output

Singleton Service Example

Counter: 0

[Increment Counter]

After clicking:

Counter: 1

Counter: 2

Counter: 3

---

## Advantages

- Only one service instance.
- Saves memory.
- Shares data across components.
- Easier state management.
- Better application performance.

---

## Interview Questions

1. What is a Singleton Service?
2. How does `providedIn: 'root'` work?
3. Why are singleton services useful?
4. Can multiple components share the same service?
5. What are the benefits of Dependency Injection?

---

## Summary

Singleton Services ensure that Angular creates one shared service instance for the entire application. This simplifies data sharing and improves performance.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Create singleton services.
- Share state using services.
- Understand Angular's root injector.
- Build scalable Angular applications.
