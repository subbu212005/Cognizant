# Parent-Child Communication in Angular

## Overview

Angular applications are built using reusable components. Often, one component (the **parent**) needs to send data to another component (the **child**), or the child needs to send data back to the parent.

Angular provides:

* **@Input()** → Pass data from Parent to Child.
* **@Output()** → Send data from Child to Parent.
* **EventEmitter** → Emits events from the child component.

These decorators help build modular and reusable applications.

---

# Parent to Child Communication

The **@Input()** decorator allows a child component to receive data from its parent.

### Parent Component

```html
<app-student [studentName]="name"></app-student>
```

### Child Component

```typescript
@Input()
studentName!: string;
```

---

# Child to Parent Communication

The **@Output()** decorator and **EventEmitter** allow a child component to send data back to its parent.

### Child Component

```typescript
@Output()
messageEvent = new EventEmitter<string>();

sendMessage() {
    this.messageEvent.emit("Hello Parent!");
}
```

### Parent Component

```html
<app-student
(messageEvent)="receiveMessage($event)">
</app-student>
```

---

# Example

## student.ts

```typescript
import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-student',
  standalone: true,
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  @Input()
  studentName: string = '';

}
```

---

## student.html

```html
<h2>Parent-Child Communication</h2>

<p>
Welcome,
<strong>{{ studentName }}</strong>
</p>
```

---

## app.ts

```typescript
import { Component } from '@angular/core';
import { StudentComponent } from './student/student';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [StudentComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {

  name = "John Doe";

}
```

---

## app.html

```html
<h1>Angular Components Demo</h1>

<app-student
[studentName]="name">
</app-student>
```

---

# Output

```
Angular Components Demo

Parent-Child Communication

Welcome, John Doe
```

---

# Advantages

* Reusable Components
* Better Code Organization
* Easy Data Sharing
* Improved Maintainability
* Supports Modular Design

---

# Difference Between @Input() and @Output()

| @Input()              | @Output()         |
| --------------------- | ----------------- |
| Parent → Child        | Child → Parent    |
| Receives data         | Sends data        |
| Uses Property Binding | Uses EventEmitter |

---

# Interview Questions

1. What is Parent-Child Communication?
2. What is @Input()?
3. What is @Output()?
4. What is EventEmitter?
5. Difference between @Input() and @Output()?

---

# Summary

Angular provides `@Input()` and `@Output()` decorators to exchange data between components. These features promote component reusability and make Angular applications easier to maintain.

---

# Learning Outcome

After completing this topic, you will be able to:

* Pass data from Parent to Child.
* Use the `@Input()` decorator.
* Understand `@Output()` and `EventEmitter`.
* Build reusable Angular components.
