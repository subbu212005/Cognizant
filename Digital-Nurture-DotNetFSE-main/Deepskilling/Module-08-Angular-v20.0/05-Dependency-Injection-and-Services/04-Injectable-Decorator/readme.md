# Injectable Decorator in Angular

## Overview

The `@Injectable()` decorator tells Angular that a class can participate in the Dependency Injection (DI) system. It allows Angular to create and inject service instances into components or other services.

The `providedIn: 'root'` option registers the service with the application's root injector, making it available throughout the application as a singleton.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand the purpose of `@Injectable()`.
- Learn how Angular registers services.
- Use `providedIn: 'root'`.
- Inject services into components.

---

## What is @Injectable()?

`@Injectable()` is a decorator that marks a class as a service that can be injected.

Example:

```typescript
@Injectable({
  providedIn: 'root'
})
```

Angular automatically creates and manages the service instance.

---

## Step 1: Update student-data.service.ts

```typescript
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentDataService {

  getStudentInfo(): string {
    return 'Student Service is provided using @Injectable decorator.';
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

  info = '';

  constructor(private studentService: StudentDataService) {
    this.info = this.studentService.getStudentInfo();
  }

}
```

---

## Step 3: Update student.html

```html
<h2>@Injectable Decorator Example</h2>

<p>{{ info }}</p>
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
```

---

## Expected Output

@Injectable Decorator Example

Student Service is provided using @Injectable decorator.

---

## Advantages

- Makes services injectable.
- Simplifies Dependency Injection.
- Encourages reusable code.
- Supports singleton services.
- Improves maintainability.

---

## Interview Questions

1. What is `@Injectable()`?
2. Why do we use `providedIn: 'root'`?
3. Can Angular inject a class without `@Injectable()`?
4. What is a singleton service?
5. What are the benefits of Dependency Injection?

---

## Summary

The `@Injectable()` decorator enables Angular to manage service creation and injection, promoting modular and reusable applications.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Use `@Injectable()`.
- Register services with Angular.
- Inject services into components.
- Understand singleton services.
