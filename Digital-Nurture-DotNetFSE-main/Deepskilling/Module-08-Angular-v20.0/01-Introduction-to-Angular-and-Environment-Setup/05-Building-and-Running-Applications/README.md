# Building and Running Angular Applications

## Overview

After creating an Angular project, the next step is to build and run the application. Angular CLI provides commands to start a development server, build the application for production, and verify that everything is working correctly.

This section explains the most commonly used Angular CLI commands for building and running applications.

---

# Running the Application

Navigate to the project folder:

```bash
cd AngularDemo
```

Start the development server:

```bash
ng serve
```

Angular CLI compiles the project and starts a local development server.

---

# Open the Application

After the build completes successfully, open the following URL in your web browser:

```
http://localhost:4200
```

The default Angular welcome page will appear.

---

# Live Reload

Angular supports **Live Reload**.

Whenever you save changes to your project files, Angular automatically recompiles the application and refreshes the browser.

Advantages:

* Faster development
* No need to restart the server
* Immediate preview of changes

---

# Building the Application

To create a development build:

```bash
ng build
```

Angular compiles the application and generates the output inside the `dist` folder.

---

# Production Build

To generate an optimized production build:

```bash
ng build --configuration production
```

The production build:

* Optimizes JavaScript
* Minifies CSS and HTML
* Removes unnecessary development code
* Improves application performance

---

# The dist Folder

After running `ng build`, Angular creates the following folder:

```text
dist/
└── AngularDemo/
```

This folder contains the compiled application that can be deployed to a web server.

---

# Common Angular CLI Commands

| Command                               | Description                                              |
| ------------------------------------- | -------------------------------------------------------- |
| `ng serve`                            | Runs the application locally                             |
| `ng serve --open`                     | Runs the application and opens the browser automatically |
| `ng build`                            | Creates a development build                              |
| `ng build --configuration production` | Creates an optimized production build                    |
| `ng test`                             | Runs unit tests                                          |
| `ng version`                          | Displays Angular CLI and package versions                |

---

# Advantages of Angular CLI Build Process

* Fast compilation
* Live Reload support
* Optimized production builds
* Easy deployment
* Automatic dependency management

---

# Interview Questions

1. What is the purpose of `ng serve`?
2. What is the default Angular development port?
3. What is Live Reload?
4. What is the difference between `ng serve` and `ng build`?
5. What is the purpose of the `dist` folder?
6. How do you create a production build?
7. Which command opens the browser automatically?
8. Where are compiled files stored?

---

# Summary

Angular CLI simplifies application development by providing commands to run, build, and optimize Angular applications. The development server supports Live Reload, while production builds generate optimized files ready for deployment.

---

# Learning Outcome

After completing this topic, you will be able to:

* Run an Angular application using `ng serve`.
* Build an Angular application using `ng build`.
* Generate a production build.
* Understand the purpose of the `dist` folder.
* Explain the difference between development and production builds.
