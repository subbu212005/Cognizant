# RouterLink and RouterOutlet in Angular

## Overview

Angular provides **RouterLink** and **RouterOutlet** to enable navigation between different components in a Single Page Application (SPA). `RouterLink` is a directive used to navigate to a route, while `RouterOutlet` is a placeholder where the routed component is displayed.

This exercise demonstrates how to navigate between Home, About, and Contact pages using Angular routing.

---

# Learning Objectives

After completing this exercise, you will be able to:

- Understand the RouterLink directive.
- Use RouterOutlet to display routed components.
- Navigate between multiple pages.
- Build a simple navigation menu.

---

# What is RouterLink?

`RouterLink` is an Angular directive that creates links for navigating between routes without reloading the page.

Example:

```html
<a routerLink="/home">Home</a>
```

---

# What is RouterOutlet?

`RouterOutlet` is a placeholder where Angular displays the component that matches the current route.

Example:

```html
<router-outlet></router-outlet>
```

---

# Step 1: Generate Contact Component

```bash
ng generate component contact
```

---

# Step 2: Update app.routes.ts

```typescript
import { Routes } from '@angular/router';
import { HomeComponent } from './home/home';
import { AboutComponent } from './about/about';
import { ContactComponent } from './contact/contact';

export const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'about', component: AboutComponent },
  { path: 'contact', component: ContactComponent },
  { path: '**', redirectTo: 'home' }
];
```

---

# Step 3: Update app.ts

```typescript
import { Component } from '@angular/core';
import { RouterOutlet, RouterLink } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, RouterLink],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class AppComponent {}
```

---

# Step 4: Update app.html

```html
<h1>Angular Navigation Demo</h1>

<nav>
  <a routerLink="/home">Home</a> |
  <a routerLink="/about">About</a> |
  <a routerLink="/contact">Contact</a>
</nav>

<hr>

<router-outlet></router-outlet>
```

---

# Step 5: Update home.html

```html
<h2>Home Page</h2>

<p>Welcome to Angular Routing.</p>
```

---

# Step 6: Update about.html

```html
<h2>About Page</h2>

<p>This page contains information about our application.</p>
```

---

# Step 7: Update contact.html

```html
<h2>Contact Page</h2>

<p>Email: support@example.com</p>

<p>Phone: +91 9876543210</p>
```

---

# Expected Output

Angular Navigation Demo

Home | About | Contact

------------------------

Home Page

Welcome to Angular Routing.

Click **About** to open the About page.

Click **Contact** to open the Contact page.

---

# Advantages

- Easy navigation
- No page reload
- Better user experience
- Cleaner application structure
- Supports browser history

---

# Interview Questions

1. What is RouterLink?
2. What is RouterOutlet?
3. What happens if RouterOutlet is removed?
4. Why do we use Angular Routing?
5. What is a Single Page Application?

---

# Summary

RouterLink provides navigation between routes, while RouterOutlet displays the routed component. Together they form the foundation of Angular navigation.

---

# Learning Outcome

After completing this exercise, you will be able to:

- Navigate between pages using RouterLink.
- Display routed components using RouterOutlet.
- Configure navigation menus.
- Build a basic multi-page Angular application.
