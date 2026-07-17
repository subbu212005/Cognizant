# Lazy Loading in Angular

## Overview

Lazy Loading is an Angular feature that loads feature modules only when they are needed. Instead of loading the entire application at startup, Angular downloads specific modules when the user navigates to them.

This improves application performance, reduces the initial bundle size, and provides a faster user experience.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand Lazy Loading.
- Create a feature module.
- Configure lazy-loaded routes.
- Improve application performance.
- Reduce initial loading time.

---

## What is Lazy Loading?

Lazy Loading delays the loading of a module until the user navigates to its route.

Example:

Application starts

↓

Only the Home module loads.

↓

User clicks **Admin**

↓

Angular loads the Admin module.

---

## Benefits of Lazy Loading

- Faster application startup.
- Smaller initial bundle size.
- Better performance.
- Loads modules only when required.
- Improves user experience.

---

## Create a Feature Module

Generate a module with routing:

```bash
ng generate module admin --route admin --module app.routes
```

Angular creates:

```
src/app/admin/
```

containing the module, routing configuration, and component.

---

## Configure Lazy Loading

Example route:

```typescript
import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: 'admin',
    loadChildren: () =>
      import('./admin/admin.routes').then(m => m.ADMIN_ROUTES)
  }
];
```

---

## Home Page

```html
<h2>Home Page</h2>

<p>Welcome to Angular Lazy Loading.</p>

<a routerLink="/admin">Go to Admin</a>
```

---

## Admin Page

```html
<h2>Admin Module</h2>

<p>This module is loaded only when required.</p>
```

---

## Expected Output

Home Page

Welcome to Angular Lazy Loading.

Go to Admin

Clicking **Go to Admin** displays:

Admin Module

This module is loaded only when required.

---

## Advantages

- Faster startup.
- Better performance.
- Smaller initial download.
- Efficient resource usage.
- Improved scalability.

---

## Real-World Applications

- E-Commerce Websites
- Banking Applications
- Hospital Management Systems
- Learning Management Systems
- Enterprise Dashboards
- Employee Management Systems

---

## Interview Questions

1. What is Lazy Loading?
2. Why do we use Lazy Loading?
3. What is the difference between Lazy Loading and Eager Loading?
4. What is `loadChildren`?
5. What are the advantages of Lazy Loading?

---

## Summary

Lazy Loading improves Angular application performance by loading feature modules only when they are requested. It minimizes the initial application size and provides a faster, more responsive user experience.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Configure Lazy Loading.
- Create feature modules.
- Use `loadChildren`.
- Optimize Angular application performance.
- Build scalable Angular applications.
