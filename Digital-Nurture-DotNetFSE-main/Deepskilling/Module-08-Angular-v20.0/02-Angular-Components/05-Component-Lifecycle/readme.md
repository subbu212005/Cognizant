# Component Lifecycle in Angular

## Overview

Every Angular component goes through a series of stages from creation to destruction. These stages are called the **Component Lifecycle**. Angular provides special methods called **Lifecycle Hooks** that allow developers to execute code at different stages of a component's life.

Lifecycle hooks are useful for initializing data, responding to changes, managing resources, and cleaning up before a component is destroyed.

---

# What is a Lifecycle Hook?

A Lifecycle Hook is a predefined method that Angular calls automatically during the lifecycle of a component.

Examples include:

* `ngOnInit()`
* `ngOnChanges()`
* `ngDoCheck()`
* `ngAfterContentInit()`
* `ngAfterContentChecked()`
* `ngAfterViewInit()`
* `ngAfterViewChecked()`
* `ngOnDestroy()`

---

# Commonly Used Lifecycle Hooks

| Hook                | Description                                      |
| ------------------- | ------------------------------------------------ |
| `constructor()`     | Initializes the component class                  |
| `ngOnInit()`        | Called once after component initialization       |
| `ngOnChanges()`     | Called when input properties change              |
| `ngDoCheck()`       | Called during every change detection cycle       |
| `ngAfterViewInit()` | Called after the component's view is initialized |
| `ngOnDestroy()`     | Called before the component is destroyed         |

---

# Example

## student.ts

```typescript
import { Component, OnInit, OnDestroy } from '@angular/core';

@Component({
  selector: 'app-student',
  standalone: true,
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent implements OnInit, OnDestroy {

  constructor() {
    console.log("Constructor Called");
  }

  ngOnInit(): void {
    console.log("ngOnInit Called");
  }

  ngOnDestroy(): void {
    console.log("ngOnDestroy Called");
  }

}
```

---

## student.html

```html
<h2>Component Lifecycle Example</h2>

<p>Open the browser Developer Console (F12) to view lifecycle messages.</p>
```

---

## student.css

```css
h2{
    color:darkgreen;
}
```

---

# Expected Console Output

```
Constructor Called
ngOnInit Called
```

When the component is destroyed:

```
ngOnDestroy Called
```

---

# Advantages

* Initialize component data
* Manage API calls
* Perform cleanup tasks
* Improve application performance
* Control component behavior

---

# Interview Questions

1. What is a Lifecycle Hook?
2. What is `ngOnInit()`?
3. What is the difference between `constructor()` and `ngOnInit()`?
4. When is `ngOnDestroy()` called?
5. Name any five Angular lifecycle hooks.

---

# Summary

Lifecycle Hooks allow Angular developers to execute code during different stages of a component's lifecycle. They are essential for initialization, change detection, and cleanup.

---

# Learning Outcome

After completing this topic, you will be able to:

* Explain the Angular component lifecycle.
* Use common lifecycle hooks.
* Understand the purpose of `constructor()`, `ngOnInit()`, and `ngOnDestroy()`.
* Debug lifecycle events using the browser console.
