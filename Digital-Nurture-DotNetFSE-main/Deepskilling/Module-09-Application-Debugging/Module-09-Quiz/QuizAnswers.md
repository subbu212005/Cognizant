# Module 9 Quiz - Application Debugging

This document contains the questions, correct options, and detailed explanations for the quizzes recommended in **Module 9: Application Debugging**.

---

## 1. GeeksforGeeks: Error Handling and Debugging Quiz

### Q1. What is the purpose of the `try...catch` block in JavaScript?
* **Answer:** To handle errors during code execution.
* **Explanation:** The `try...catch` block is used to capture runtime errors (exceptions) so that custom error-handling logic can be run without crashing the entire script or application.

### Q2. Which statement is used to manually throw an error in JavaScript?
* **Answer:** `throw`
* **Explanation:** The `throw` statement allows developers to define and generate custom errors by providing a string, number, object, or an instance of the `Error` class.

### Q3. What is the `Error` object used for?
* **Answer:** To represent runtime errors in JavaScript.
* **Explanation:** The built-in `Error` object contains detailed context about the exception that occurred, including its name (type of error) and human-readable message.

### Q4. What is the output of the following code?
```javascript
try {
  console.log(a);
} catch (e) {
  console.log(e.message);
}
```
* **Answer:** `ReferenceError: a is not defined` (or its message `a is not defined`).
* **Explanation:** Since variable `a` is not declared anywhere in the scope, attempting to access it throws a `ReferenceError`. The `catch` block catches this error and prints its message.

### Q5. Which console method is used to display a table of data?
* **Answer:** `console.table()`
* **Explanation:** The `console.table()` method takes a collection of objects or arrays and renders them as a structured, interactive tabular layout in the console.

### Q6. What happens if there is no `catch` block for a thrown error?
* **Answer:** The program crashes or stops execution.
* **Explanation:** Uncaught exceptions bubble up the call stack. If they reach the top-level execution context without being caught, they terminate script execution and cause a crash.

### Q7. Which of the following methods halts the browser's execution to inspect the code?
* **Answer:** `debugger`
* **Explanation:** The `debugger` keyword acts as a programmatic breakpoint. When developer tools are open, execution pauses at this statement, letting developers inspect variables and the call stack.

### Q8. What is the purpose of the `finally` block in error handling?
* **Answer:** It executes after the `try` and `catch` blocks, regardless of whether an error occurred.
* **Explanation:** The `finally` block is used for cleanup actions (e.g., closing open connections, releasing resources) and is guaranteed to run after `try` and `catch` finish.

### Q9. Which of the following is NOT a valid `console` method?
* **Answer:** `console.alert()`
* **Explanation:** There is no `console.alert()` method. The browser provides a global `alert()` function, while valid console methods include `console.log()`, `console.warn()`, `console.error()`, etc.

### Q10. What is the primary advantage of using a linter like ESLint in debugging?
* **Answer:** Highlights potential errors and enforces coding standards.
* **Explanation:** Linters perform static code analysis to catch syntax issues, bad patterns, and potential runtime errors before the code is even run in a browser.

---

## 2. Wayground: Mastering Chrome DevTools Quiz

### Q1. What is the shortcut to open Chrome DevTools?
* **Answer:** `Ctrl + Shift + I` (Windows/Linux) or `Command + Option + I` (macOS) / `F12`.
* **Explanation:** These global key combinations toggle the developer tools drawer directly.

### Q2. Which panel in DevTools allows you to inspect HTML elements?
* **Answer:** Elements panel.
* **Explanation:** The Elements panel displays the live DOM tree structure of the page, allowing inspect, edit, and layout monitoring.

### Q3. What feature in DevTools helps you analyze network requests?
* **Answer:** Network panel.
* **Explanation:** The Network panel logs all resource requests (HTTP requests, CSS, images, JS, APIs) along with headers, payloads, status codes, and timings.

### Q4. How can you view and edit CSS styles in DevTools?
* **Answer:** Right-click an element, select 'Inspect', and edit styles in the Styles pane.
* **Explanation:** Once an element is inspected, its associated style declarations are listed in the Styles pane where they can be added, toggled, or modified in real-time.

### Q5. Which tab would you use to debug JavaScript/TypeScript code?
* **Answer:** Sources panel (or Debugger).
* **Explanation:** The Sources panel hosts the source files, maps transpiled JavaScript to original TypeScript files, and handles breakpoints, stepping, and watch expressions.

### Q6. What does the 'Console' tab in DevTools primarily do?
* **Answer:** Allows for debugging and executing JavaScript code, viewing logs, and examining errors.
* **Explanation:** The Console offers a REPL environment to interact with the current window context and logs printed messages.

### Q7. How can you simulate different device screens in DevTools?
* **Answer:** Use the device toggle toolbar (Toggle Device Toolbar icon).
* **Explanation:** The Device Mode button simulates mobile, tablet, and responsive screen viewports.

### Q8. What is the purpose of the 'Sources' panel in DevTools?
* **Answer:** To view and manage source files for debugging and inspection.
* **Explanation:** It lets you navigate workspace files, write script snippets, and debug javascript.

### Q9. Which tool in DevTools can help you optimize website performance?
* **Answer:** Performance panel.
* **Explanation:** The Performance panel records runtime performance, CPU profiling, paint times, and frame rates to locate bottleneck activities.

### Q10. How can you view application storage like cookies and local storage?
* **Answer:** Go to the 'Application' tab and check under 'Storage' (Cookies and Local Storage).
* **Explanation:** The Application panel inspects all client-side storage mechanisms including LocalStorage, SessionStorage, Cookies, and IndexedDB.

---

## 3. ToolsRail: Web Browsers & Developer Tools Quiz

### Q1. What is the primary purpose of browser developer tools?
* **Answer:** To help developers test, inspect, debug, and analyze web applications.
* **Explanation:** Developer tools provide runtime insight into HTML, CSS, JavaScript, networks, and performance.

### Q2. Which panel is used to inspect WebSocket connections and AJAX API calls?
* **Answer:** Network panel.
* **Explanation:** All outgoing and incoming client-server calls, including Fetch/XHR requests and WebSocket frame streams, are displayed in the Network tab.

### Q3. Can you set a breakpoint to pause execution when a DOM node is modified?
* **Answer:** Yes (DOM Breakpoints).
* **Explanation:** By right-clicking a DOM element in the Elements panel, you can set breakpoints for Subtree Modifications, Attribute Modifications, or Node Removal.

### Q4. What are Source Maps?
* **Answer:** Files that map transpiled/minified code back to the original source code (e.g., JavaScript back to TypeScript).
* **Explanation:** Source maps allow developers to debug their original code directly in the browser even after it has been built and minified.

### Q5. What does the status code `200 OK` indicate in the Network panel?
* **Answer:** The request succeeded, and the server returned the requested resource.
* **Explanation:** Standard HTTP success status code indicating the resource was transferred successfully.

### Q6. Which panel helps analyze memory leaks in Web Applications?
* **Answer:** Memory panel (Profiler).
* **Explanation:** The Memory panel allows you to take heap snapshots, record allocation timelines, and locate objects that are not garbage collected.
