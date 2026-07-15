# Installing Node.js and Angular CLI

## Overview

Before developing Angular applications, you must install **Node.js**, **npm (Node Package Manager)**, and the **Angular CLI**. Angular CLI is the official command-line tool that helps developers create, build, test, and manage Angular applications efficiently.

---

# Prerequisites

Before installing Angular CLI, ensure that:

- Windows 10 or Windows 11
- Internet Connection
- Administrator Privileges
- Visual Studio Code (Recommended)

---

# Step 1: Install Node.js

Angular requires Node.js to run.

### Download Node.js

Visit the official website:

https://nodejs.org

Download the **LTS (Long Term Support)** version.

---

# Step 2: Verify Node.js Installation

Open **Command Prompt**, **PowerShell**, or **VS Code Terminal**.

Run:

```bash
node -v
```

Example Output:

```
v22.16.0
```

Check npm version:

```bash
npm -v
```

Example Output:

```
11.4.2
```

---

# Step 3: Install Angular CLI

Run the following command:

```bash
npm install -g @angular/cli
```

### Explanation

- **npm** → Node Package Manager
- **install** → Install a package
- **-g** → Install globally
- **@angular/cli** → Angular Command Line Interface

---

# Step 4: Verify Angular CLI Installation

Run:

```bash
ng version
```

Example Output:

```
Angular CLI: 20.x.x
Node: 22.x.x
Package Manager: npm
OS: win32 x64
```

---

# Step 5: Update Angular CLI

To update Angular CLI:

```bash
npm install -g @angular/cli@latest
```

---

# Step 6: Uninstall Angular CLI

If needed:

```bash
npm uninstall -g @angular/cli
```

---

# Common Angular CLI Commands

| Command | Description |
|----------|-------------|
| `ng version` | Displays Angular CLI version |
| `ng new project-name` | Creates a new Angular project |
| `ng serve` | Runs the application |
| `ng build` | Builds the application |
| `ng generate component component-name` | Creates a component |
| `ng test` | Runs unit tests |
| `ng help` | Shows Angular CLI help |

---

# Troubleshooting

## 'node' is not recognized

### Solution

- Reinstall Node.js
- Restart the terminal
- Ensure Node.js is added to the system PATH

---

## 'ng' is not recognized

### Solution

Run:

```bash
npm install -g @angular/cli
```

Restart the terminal and execute:

```bash
ng version
```

---

# Advantages of Angular CLI

- Generates project structure automatically
- Creates components, services, modules, and pipes
- Builds optimized production applications
- Includes development server
- Supports testing and linting
- Reduces development time

---

# Interview Questions

1. What is Node.js?
2. What is npm?
3. What is Angular CLI?
4. Why do we install Angular CLI globally?
5. Difference between local and global installation?
6. How do you verify Angular CLI installation?
7. Which command creates a new Angular project?
8. Which command runs an Angular application?

---

# Summary

Node.js provides the runtime environment required for Angular development, npm manages packages, and Angular CLI simplifies application creation, development, testing, and deployment.

---

# Learning Outcome

After completing this topic, you will be able to:

- Install Node.js
- Install Angular CLI
- Verify the installation
- Update Angular CLI
- Use basic Angular CLI commands
- Troubleshoot common installation issues
