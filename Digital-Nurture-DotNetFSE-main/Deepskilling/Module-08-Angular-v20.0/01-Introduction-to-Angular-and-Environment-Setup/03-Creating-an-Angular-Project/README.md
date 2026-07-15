# Creating an Angular Project

## Overview

Angular CLI provides an easy way to create a new Angular application with a predefined project structure.

---

## Creating a New Project

Run:

```bash
ng new AngularDemo
```

This command creates a new Angular application named **AngularDemo**.

---

## Project Creation Options

During project creation, Angular CLI asks:

- Stylesheet format (CSS, SCSS, Sass, Less)
- Enable Server-Side Rendering (SSR)

For this project:

- Stylesheet: CSS
- SSR: No

---

## Navigate to Project

```bash
cd AngularDemo
```

---

## Open in Visual Studio Code

```bash
code .
```

---

## Run the Application

```bash
ng serve
```

---

## Open in Browser

```
http://localhost:4200
```

---

## Important Commands

| Command | Description |
|---------|-------------|
| `ng new AngularDemo` | Create a new Angular project |
| `cd AngularDemo` | Navigate to the project directory |
| `code .` | Open project in VS Code |
| `ng serve` | Start the development server |

---

## Advantages

- Automatically creates project structure
- Configures TypeScript
- Includes development server
- Supports hot reloading
- Ready for Angular development

---

## Interview Questions

1. What does `ng new` do?
2. What is the default Angular development port?
3. Why do we use `ng serve`?
4. What is Angular CLI?
5. What files are created by `ng new`?

---

## Summary

Angular CLI simplifies project creation by generating a complete project structure with all necessary configuration files, allowing developers to start building applications quickly.

---

## Learning Outcome

After completing this topic, you will be able to:

- Create an Angular project.
- Open it in VS Code.
- Run the development server.
- Access the application in a browser.
