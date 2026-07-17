# Configuring Routes in Angular

## Overview

Route configuration is the process of mapping URL paths to Angular components. Angular uses the Router module to determine which component should be displayed when a user navigates to a specific URL.

A route configuration is defined in the `app.routes.ts` file.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Configure routes in Angular.
- Create default routes.
- Create wildcard routes.
- Navigate between pages.
- Handle invalid URLs.

---

## What is Route Configuration?

A route is an object that connects a URL path to a component.

Example:

```typescript
{
  path: 'home',
  component: HomeComponent
}
```

When the user visits:

```
http://localhost:4200/home
```

Angular displays the **HomeComponent**.

---

## Step 1: Update app.routes.ts

```typescript
import { Routes } from '@angular/router';
import { HomeComponent } from './home/home';
import { AboutComponent } from './about/about';

export const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'about', component: AboutComponent },
  { path: '**', redirectTo: 'home' }
];
```

---

## Step 2: Update app.html

```html
<h1>Angular Route Configuration</h1>

<nav>
  <a routerLink="/home">Home</a> |
  <a routerLink="/about">About</a>
</nav>

<hr>

<router-outlet></router-outlet>
```

---

## Step 3: Update app.ts

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

## Step 4: Update home.html

```html
<h2>Home Component</h2>

<p>Welcome to the Home Page.</p>
```

---

## Step 5: Update about.html

```html
<h2>About Component</h2>

<p>Welcome to the About Page.</p>
```

---

## Expected Output

Angular Route Configuration

Home | About

-----------------------

Home Component

Welcome to the Home Page.

Clicking **About** displays:

About Component

Welcome to the About Page.

If an invalid URL is entered, Angular redirects to the Home page.

---

## Advantages

- Clean URL management
- Easy navigation
- Supports redirects
- Handles invalid routes
- Improves user experience

---

## Interview Questions

1. What is route configuration?
2. What is the purpose of `pathMatch: 'full'`?
3. What is a wildcard route?
4. Why do we use `redirectTo`?
5. What is `RouterOutlet`?

---

## Summary

Angular route configuration maps URL paths to components, allowing efficient navigation within a Single Page Application.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Configure application routes.
- Redirect users.
- Handle invalid URLs.
- Build structured navigation.
