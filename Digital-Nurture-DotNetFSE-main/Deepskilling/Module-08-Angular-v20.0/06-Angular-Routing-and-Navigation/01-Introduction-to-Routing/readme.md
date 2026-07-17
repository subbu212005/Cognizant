# Introduction to Routing in Angular

## Overview

Routing is a core feature of Angular that enables navigation between different views or components without reloading the entire web page. Angular applications are Single Page Applications (SPAs), where routing allows users to move between pages while maintaining a smooth user experience.

The Angular Router manages navigation by mapping URL paths to components.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand Angular Routing.
- Learn the concept of Single Page Applications (SPA).
- Understand the Angular Router.
- Configure basic routes.
- Navigate between multiple components.

---

## What is Routing?

Routing is the process of navigating between different components based on the URL.

Instead of loading a new HTML page, Angular dynamically loads the requested component.

Example:

```
http://localhost:4200/home
```

loads the Home Component.

```
http://localhost:4200/about
```

loads the About Component.

---

## Benefits of Routing

- Faster navigation
- No page refresh
- Better user experience
- Supports browser history
- Easy URL management

---

## Step 1: Generate Components

Open the terminal and run:

```bash
ng generate component home
ng generate component about
```

Angular creates:

```
src/app/home/
src/app/about/
```

---

## Step 2: Create Routes

Update `app.routes.ts`

```typescript
import { Routes } from '@angular/router';
import { HomeComponent } from './home/home';
import { AboutComponent } from './about/about';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'about', component: AboutComponent }
];
```

---

## Step 3: Update app.html

```html
<h1>Angular Routing Demo</h1>

<nav>
  <a routerLink="/">Home</a> |
  <a routerLink="/about">About</a>
</nav>

<hr>

<router-outlet></router-outlet>
```

---

## Step 4: Update app.ts

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

## Step 5: Update home.html

```html
<h2>Home Page</h2>

<p>Welcome to Angular Routing.</p>
```

---

## Step 6: Update about.html

```html
<h2>About Page</h2>

<p>This is the About Component.</p>
```

---

## Expected Output

Home Page

Welcome to Angular Routing.

Clicking **About** displays:

About Page

This is the About Component.

---

## Advantages

- Smooth navigation
- No full-page reload
- Better performance
- Supports browser navigation
- Improves user experience

---

## Interview Questions

1. What is Angular Routing?
2. What is a Single Page Application?
3. What is Angular Router?
4. What is RouterOutlet?
5. What is RouterLink?

---

## Summary

Angular Routing enables navigation between components using URL paths while keeping the application fast and responsive.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Configure Angular Routing.
- Create multiple routes.
- Navigate using RouterLink.
- Display routed components using RouterOutlet.
