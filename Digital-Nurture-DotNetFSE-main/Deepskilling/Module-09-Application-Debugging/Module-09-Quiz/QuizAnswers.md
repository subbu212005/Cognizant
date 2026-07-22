# Module 9 Quiz - Application Debugging

This document contains the questions, correct options, and detailed explanations for the quizzes recommended in **Module 9: Application Debugging**.

---

## 1. GeeksforGeeks: Error Handling and Debugging Quiz

# Error Handling and Debugging Quiz – Questions & Answers

## 1. What is the purpose of the `try...catch` block in JavaScript?

- A. To handle asynchronous code
- ✅ B. To handle errors during code execution
- C. To stop the execution of a program
- D. To skip specific lines of code

**Answer:** B. To handle errors during code execution

**Explanation:** The `try...catch` block catches runtime exceptions and allows the program to handle errors gracefully without terminating execution.

---

## 2. Which statement is used to manually throw an error in JavaScript?

- ✅ A. throw
- B. raise
- C. error
- D. reject

**Answer:** A. throw

**Explanation:** The `throw` statement is used to generate custom exceptions or errors.

---

## 3. What is the Error object used for?

- A. To create custom error messages
- B. To debug code by printing logs
- ✅ C. To represent runtime errors in JavaScript
- D. To pause code execution

**Answer:** C. To represent runtime errors in JavaScript

**Explanation:** The `Error` object stores information about runtime errors, including the error name and message.

---

## 4. What is the output of the following code?

```javascript
try {
    console.log(a);
} catch (e) {
    console.log(e.message);
}
```

- A. a is not defined
- ✅ B. ReferenceError: a is not defined
- C. Undefined
- D. Throws no error

**Answer:** B. ReferenceError: a is not defined

**Explanation:** Since variable `a` is not declared, JavaScript throws a `ReferenceError`, which is caught by the `catch` block.

---

## 5. Which console method is used to display a table of data?

- A. console.log()
- B. console.error()
- C. console.data()
- ✅ D. console.table()

**Answer:** D. console.table()

**Explanation:** `console.table()` displays arrays or objects in a tabular format within the browser console.

---

## 6. What happens if there is no catch block for a thrown error?

- A. The program continues execution
- B. The error is ignored
- ✅ C. The program crashes or stops execution
- D. A warning is displayed in the console

**Answer:** C. The program crashes or stops execution

**Explanation:** If an exception is not caught, JavaScript stops execution and reports an uncaught error.

---

## 7. Which of the following methods halts the browser's execution to inspect the code?

- ✅ A. debugger
- B. console.stop()
- C. break()
- D. console.inspect()

**Answer:** A. debugger

**Explanation:** The `debugger` statement pauses execution when DevTools is open, allowing inspection of variables and program flow.

---

## 8. What is the purpose of the `finally` block in error handling?

- A. Executes only if an error occurs
- B. Executes only if no error occurs
- ✅ C. Executes after the try and catch blocks, regardless of errors
- D. Stops the error from propagating further

**Answer:** C. Executes after the try and catch blocks, regardless of errors

**Explanation:** The `finally` block always executes, making it ideal for cleanup tasks such as closing files or releasing resources.

---

## 9. Which of the following is NOT a console method?

- A. console.time()
- B. console.warn()
- C. console.info()
- ✅ D. console.alert()

**Answer:** D. console.alert()

**Explanation:** There is no `console.alert()` method. `alert()` is a global browser function, not part of the `console` object.

---

## 10. What is the primary advantage of using a linter like ESLint in debugging?

- A. Automatically fixes all errors in code
- ✅ B. Highlights potential errors and enforces coding standards
- C. Pauses execution of the code
- D. Provides runtime debugging tools

**Answer:** B. Highlights potential errors and enforces coding standards

**Explanation:** ESLint performs static analysis to identify syntax errors, bad coding practices, and potential bugs before the code runs.

## 2. Wayground: Mastering Chrome DevTools Quiz

# Mastering Chrome DevTools Quiz – Questions & Answers

## 1. What is the shortcut to open Chrome DevTools?

- ✅ A. **Ctrl + Shift + I** (Windows/Linux) or **Command + Option + I** (macOS) / **F12**
- B. Ctrl + Shift + C
- C. Ctrl + Alt + I
- D. Alt + Shift + I

**Answer:** A. Ctrl + Shift + I (Windows/Linux) or Command + Option + I (macOS) / F12

**Explanation:** These shortcuts open Chrome Developer Tools.

---

## 2. Which panel in DevTools allows you to inspect HTML elements?

- ✅ A. Elements panel
- B. Console panel
- C. Sources panel
- D. Network panel

**Answer:** A. Elements panel

**Explanation:** The **Elements** panel lets you inspect and edit the HTML DOM and CSS.

---

## 3. What feature in DevTools helps you analyze network requests?

- A. Console panel
- ✅ B. Network panel
- C. Sources panel
- D. Performance panel

**Answer:** B. Network panel

**Explanation:** The **Network** panel displays HTTP requests, responses, headers, timing, and API calls.

---

## 4. How can you view and edit CSS styles in DevTools?

- A. Open the Console tab
- B. Use the Network panel
- ✅ C. Right-click an element, choose **Inspect**, then edit styles in the **Styles** pane
- D. Open the Performance panel

**Answer:** C. Right-click an element, choose **Inspect**, then edit styles in the **Styles** pane

**Explanation:** The **Styles** pane allows live editing of CSS properties.

---

## 5. Which tab would you use to debug JavaScript code?

- A. Elements
- B. Console
- ✅ C. Sources
- D. Network

**Answer:** C. Sources

**Explanation:** The **Sources** panel provides breakpoints, stepping controls, and variable inspection.

---

## 6. What does the 'Console' tab in DevTools primarily do?

- A. Displays HTML elements
- B. Monitors network requests
- ✅ C. Allows debugging and executing JavaScript code, viewing logs, and examining errors
- D. Edits CSS styles

**Answer:** C. Allows debugging and executing JavaScript code, viewing logs, and examining errors

**Explanation:** The Console is used for JavaScript execution, logs, warnings, and runtime errors.

---

## 7. How can you simulate different device screens in DevTools?

- A. Open the Network panel
- B. Enable Performance mode
- ✅ C. Use the **Toggle Device Toolbar** (Device Mode)
- D. Open the Sources panel

**Answer:** C. Use the Toggle Device Toolbar (Device Mode)

**Explanation:** Device Mode lets you emulate mobile phones, tablets, and responsive layouts.

---

## 8. What is the purpose of the 'Sources' panel in DevTools?

- A. Analyze network traffic
- B. Inspect HTML elements
- ✅ C. View and manage source files for debugging and inspection
- D. Edit cookies and storage

**Answer:** C. View and manage source files for debugging and inspection

**Explanation:** The Sources panel is used for debugging JavaScript, setting breakpoints, and viewing source files.

---

## 9. Which tool in DevTools can help you optimize website performance?

- A. Console
- B. Network
- ✅ C. Performance panel
- D. Elements

**Answer:** C. Performance panel

**Explanation:** The **Performance** panel records page activity and helps identify CPU, rendering, and loading bottlenecks.

---

## 10. How can you view application storage like cookies and local storage?

- A. Open the Console panel
- B. Open the Network panel
- C. Open the Elements panel
- ✅ D. Go to the **Application** tab and check under **Storage** (Cookies and Local Storage)

**Answer:** D. Go to the Application tab and check under Storage (Cookies and Local Storage)

**Explanation:** The **Application** panel provides access to Cookies, Local Storage, Session Storage, IndexedDB, Cache Storage, and other browser storage.

## 3. ToolsRail: Web Browsers & Developer Tools Quiz

# Chrome DevTools Quiz – Questions & Answers

## 1. What keyboard shortcut opens Chrome Developer Tools on Windows?
- Ctrl + Shift + D
- Ctrl + Shift + C
- ✅ Ctrl + Shift + I
- Alt + F12

**Answer:** Ctrl + Shift + I

**Explanation:** Press **Ctrl + Shift + I** (or **F12**) to open Chrome Developer Tools on Windows.

---

## 2. Which feature in Chrome DevTools helps audit a webpage for performance, accessibility, and SEO?
- Performance panel
- ✅ Lighthouse
- Security tab
- Coverage tool

**Answer:** Lighthouse

**Explanation:** **Lighthouse** generates reports for Performance, Accessibility, Best Practices, SEO, and Progressive Web Apps.

---

## 3. What does the 'Preserve log' checkbox in the Network tab do?
- Prevents console errors
- ✅ Keeps logs even after page reload
- Refreshes headers
- Enables cache

**Answer:** Keeps logs even after page reload

**Explanation:** It prevents network logs from being cleared when the page reloads or navigates.

---

## 4. What is the keyboard shortcut to search across all files in the Sources panel?
- Ctrl + F
- ✅ Ctrl + Shift + F
- Ctrl + P
- Ctrl + Shift + P

**Answer:** Ctrl + Shift + F

**Explanation:** Searches across all source files in the Sources panel.

---

## 5. Which panel in DevTools is used to debug JavaScript line-by-line?
- Elements
- Console
- ✅ Sources
- Network

**Answer:** Sources

**Explanation:** The **Sources** panel allows you to set breakpoints, inspect variables, and step through JavaScript execution.

---

## 6. Which keyboard shortcut activates the element selection mode in Chrome DevTools?
- Ctrl + E
- Ctrl + Shift + E
- ✅ Ctrl + Shift + C
- Ctrl + Alt + S

**Answer:** Ctrl + Shift + C

**Explanation:** Activates **Inspect Element** mode to select and inspect elements on a webpage.

---

## 7. What does the 'Disable cache' option in the Network tab do when DevTools is open?
- ✅ Prevents the browser from using cached resources
- Clears all existing cache
- Speeds up page loading
- Disables service workers

**Answer:** Prevents the browser from using cached resources

**Explanation:** Forces the browser to download fresh resources instead of using cached versions while DevTools is open.

---

## 8. What is the purpose of the 'Console' panel in DevTools?
- To view and edit HTML elements
- ✅ To display logs, run JavaScript, and debug errors
- To analyze network requests
- To inspect CSS styles

**Answer:** To display logs, run JavaScript, and debug errors

**Explanation:** The Console is used for logging, executing JavaScript commands, and viewing runtime errors.

---

## 9. What does the 'Network Throttling' feature in DevTools simulate?
- Slow CPU performance
- ✅ Limited network conditions (like 3G)
- High memory usage
- Multiple browser tabs open

**Answer:** Limited network conditions (like 3G)

**Explanation:** Simulates slower internet connections such as Fast 3G or Slow 3G for testing website performance.

---

## 10. Which DevTools feature helps test your site on mobile devices?
- Network tab
- Lighthouse
- ✅ Device Toolbar
- Console

**Answer:** Device Toolbar

**Explanation:** The Device Toolbar emulates mobile devices, screen sizes, and touch interactions for responsive testing.
* **Answer:** Memory panel (Profiler).
* **Explanation:** The Memory panel allows you to take heap snapshots, record allocation timelines, and locate objects that are not garbage collected.
