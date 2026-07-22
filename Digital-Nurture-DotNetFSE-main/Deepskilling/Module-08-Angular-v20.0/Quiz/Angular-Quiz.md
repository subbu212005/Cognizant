# Angular Quiz Results (22/25 - 88%)

## Question 20
**How do you set an attribute when no corresponding property exists?**

- A. bind-attr
- ✅ B. [attr.*]
- C. [class.*]
- D. [style.*]

**Correct Answer:** **[attr.*]**

**Explanation:** Use attribute binding when an HTML attribute has no corresponding DOM property.

**Example:**
```html
<button [attr.aria-label]="'Close'">X</button>
```

---

## Question 24
**Which package exports `bootstrapApplication`?**

- A. @angular/core
- B. @angular/router
- ✅ C. @angular/platform-browser
- D. @angular/common

**Correct Answer:** **@angular/platform-browser**

**Explanation:**
`bootstrapApplication()` is exported from the `@angular/platform-browser` package.

**Example:**
```typescript
import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';

bootstrapApplication(AppComponent);
```

---

## Question 25
**To use `*ngIf` and `*ngFor` in a standalone component, import:**

- A. RouterModule
- B. FormsModule
- ✅ C. CommonModule
- D. BrowserModule

**Correct Answer:** **CommonModule**

**Explanation:**
`CommonModule` provides commonly used directives such as:
- `*ngIf`
- `*ngFor`
- `ngClass`
- `ngStyle`

**Example:**
```typescript
import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  standalone: true,
  imports: [CommonModule],
  selector: 'app-example',
  template: `
    <div *ngIf="show">Hello</div>
    <li *ngFor="let item of items">{{ item }}</li>
  `
})
export class ExampleComponent {}
```

---

# Final Score

- **Correct:** 22 / 25
- **Score:** **88%**
- **Missed Questions:** 20, 24, 25
