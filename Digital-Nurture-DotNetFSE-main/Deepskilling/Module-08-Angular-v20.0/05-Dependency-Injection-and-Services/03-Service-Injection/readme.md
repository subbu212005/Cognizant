# Service Injection in Angular

## Overview

Service Injection is the process of providing a service instance to a component using Angular's Dependency Injection (DI) system. Instead of creating objects manually using the `new` keyword, Angular automatically creates and injects the service into the component.

This approach promotes loose coupling, code reusability, and easier testing.

---

# Learning Objectives

After completing this exercise, you will be able to:

- Understand Service Injection.
- Inject a service into a component.
- Access methods from the injected service.
- Display service data in the browser.

---

# Step 1: Update student-data.service.ts

```typescript
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentDataService {

  getCollegeName(): string {
    return 'Vignan University';
  }

}
```

---

# Step 2: Update student.ts

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

  college = '';

  constructor(private studentService: StudentDataService) {
    this.college = this.studentService.getCollegeName();
  }

}
```

---

# Step 3: Update student.html

```html
<h2>Service Injection Example</h2>

<p>College Name: {{ college }}</p>
```

---

# Step 4: Update student.css

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

# Expected Output

Service Injection Example

College Name: Vignan University

---

# Advantages

- Loose coupling
- Reusable code
- Better maintainability
- Easy testing
- Cleaner architecture

---

# Interview Questions

1. What is Service Injection?
2. How does Angular inject services?
3. What is constructor injection?
4. Why is Dependency Injection important?
5. What is `providedIn: 'root'`?

---

# Summary

Angular automatically injects services into components through constructors. This makes applications modular, reusable, and easier to maintain.

---

# Learning Outcome

After completing this exercise, you can:

- Inject services into components.
- Access service methods.
- Display injected data.
- Build modular Angular applications.
