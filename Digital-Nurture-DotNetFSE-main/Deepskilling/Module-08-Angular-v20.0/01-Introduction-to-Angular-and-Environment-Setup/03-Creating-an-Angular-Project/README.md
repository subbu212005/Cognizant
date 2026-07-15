# Creating an Angular Project

## Overview

Angular CLI (Command Line Interface) is the official tool provided by the Angular team to simplify the creation, development, testing, and deployment of Angular applications. It automatically generates a complete project structure with the necessary configuration files and dependencies.

This guide demonstrates how to create a new Angular project using Angular CLI and run it locally.

---

# Prerequisites

Before creating an Angular project, ensure that the following software is installed:

* Node.js
* npm (Node Package Manager)
* Angular CLI
* Visual Studio Code (Recommended)

Verify the installations using:

```bash
node -v
npm -v
ng version
```

---

# Creating a New Angular Project

Open **Command Prompt**, **PowerShell**, or the **VS Code Terminal**, then execute the following command:

```bash
ng new AngularDemo
```

This command creates a new Angular project named **AngularDemo**.

---

# Project Configuration

During project creation, Angular CLI asks for a few configuration options.

### Stylesheet System

Select:

```text
CSS
```

### Server-Side Rendering (SSR)

Select:

```text
No
```

### AI Tool Configuration

Select:

```text
None
```

After confirming these options, Angular CLI automatically generates the project files and installs the required packages.

---

# Project Creation Output

After successful execution, Angular CLI creates files such as:

* angular.json
* package.json
* tsconfig.json
* README.md
* src/
* public/
* .vscode/
* app/

Finally, it displays:

```text
Packages installed successfully.
Successfully initialized git.
```

---

# Navigate to the Project

Move into the project directory:

```bash
cd AngularDemo
```

---

# Open the Project in Visual Studio Code

```bash
code .
```

This opens the Angular project in VS Code.

---

# Run the Angular Application

Start the development server using:

```bash
ng serve
```

Angular CLI compiles the application and starts a local development server.

---

# Open in Browser

Open the following URL in your browser:

```text
http://localhost:4200
```

The default Angular welcome page will be displayed, confirming that the application is running successfully.

---

# Common Angular CLI Commands

| Command                                | Description                             |
| -------------------------------------- | --------------------------------------- |
| `ng new AngularDemo`                   | Creates a new Angular project           |
| `cd AngularDemo`                       | Navigates to the project folder         |
| `code .`                               | Opens the project in Visual Studio Code |
| `ng serve`                             | Starts the development server           |
| `ng build`                             | Builds the application                  |
| `ng test`                              | Runs unit tests                         |
| `ng generate component component-name` | Creates a new component                 |
| `ng generate service service-name`     | Creates a new service                   |

---

# Advantages of Angular CLI

* Generates the complete project structure automatically.
* Installs required dependencies.
* Simplifies project creation.
* Provides a built-in development server.
* Supports code generation for components, services, modules, and pipes.
* Creates optimized production builds.
* Includes testing support.

---

# Interview Questions

1. What is Angular CLI?
2. What does the `ng new` command do?
3. What is the default port used by Angular applications?
4. What is the purpose of `ng serve`?
5. Why do we use `code .`?
6. What files are generated when creating an Angular project?
7. What is the purpose of `package.json`?
8. What is the purpose of `angular.json`?
9. How do you build an Angular application for production?
10. What is the difference between `ng serve` and `ng build`?

---

# Summary

Angular CLI simplifies Angular application development by automatically creating the project structure, installing dependencies, and providing commands to build, run, and test applications. It significantly reduces setup time and allows developers to focus on application development.

---

# Learning Outcome

After completing this topic, you will be able to:

* Create a new Angular project using Angular CLI.
* Configure project options during creation.
* Open the project in Visual Studio Code.
* Run the application using `ng serve`.
* Access the application in a web browser.
* Understand the basic Angular project creation workflow.
