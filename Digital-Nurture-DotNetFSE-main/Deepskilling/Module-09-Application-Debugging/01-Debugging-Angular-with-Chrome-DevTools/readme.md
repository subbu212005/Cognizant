# Debugging Angular with Chrome DevTools

## Aim

To learn how to debug Angular applications using Google Chrome DevTools by inspecting the DOM, setting breakpoints, analyzing TypeScript code, and identifying runtime errors.

---

## Prerequisites

- Visual Studio Code
- Node.js
- Angular CLI
- Google Chrome
- Angular Application

---

## Steps to Perform

### Step 1: Start the Angular Application

Open the project folder and run:

```bash
ng serve
```

The application will be available at:

```
http://localhost:4200
```

---

### Step 2: Open Chrome DevTools

- Open Google Chrome.
- Navigate to `http://localhost:4200`.
- Press **F12** or **Ctrl + Shift + I**.

---

### Step 3: Inspect the DOM

- Select the **Elements** tab.
- Inspect HTML elements.
- View applied CSS styles.
- Modify HTML or CSS temporarily.

---

### Step 4: Debug Using Console

Select the **Console** tab.

Example:

```javascript
console.log("Angular Application Started");
```

Observe console messages and runtime errors.

---

### Step 5: Debug Using Sources Panel

- Open the **Sources** tab.
- Locate the TypeScript source file.
- Set breakpoints.
- Refresh the application.
- Execution pauses at the breakpoint.

---

### Step 6: Inspect Variables

When execution pauses:

- View Local Variables
- View Scope
- View Call Stack
- Step Over
- Step Into
- Step Out

---

### Step 7: Verify Source Maps

Angular automatically generates source maps in development mode.

This allows debugging TypeScript instead of compiled JavaScript.

---

## Expected Outcome

- Successfully inspected Angular components.
- Used Chrome DevTools for debugging.
- Set breakpoints.
- Examined variables and call stack.
- Identified runtime issues.

---

## Learning Outcome

After completing this exercise, I learned how to inspect Angular applications using Chrome DevTools, debug TypeScript code with source maps, analyze runtime behavior, and troubleshoot frontend issues efficiently.
