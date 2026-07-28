# Sample Prompts for GitHub Copilot Chat

This document lists copy-pasteable prompts to use in Copilot Chat (inline or side panel) to solve everyday programming challenges.

---

## 1. Code Explanation & Learning

Use these prompts to understand complex logic, legacy codebases, or new libraries.

### High-Level Summary
```text
/explain What does the selected code do at a high level? Summarize its main responsibilities and inputs/outputs.
```

### Detailed Line-by-Line Walkthrough
```text
/explain Explain the logic in this block step-by-step. Focus on how memory is handled and what variables represent.
```

### Understanding Algorithms
```text
What algorithm is being used in the selected code? Explain its time and space complexity in Big O notation.
```

---

## 2. Debugging & Trouble-shooting

Use these prompts when your code is crashing or returning unexpected results.

### Debugging with Error Messages
```text
/fix The selected code is throwing the following error at runtime: [Paste Error Here]. Propose a fix and explain why this error occurred.
```

### Identifying Logic Errors
```text
The selected code is supposed to sort the incoming JSON payload by timestamp, but the output order remains unsorted. Spot the logic bug and provide the fix.
```

---

## 3. Refactoring & Code Quality

Use these prompts to clean up, optimize, or modernize your codebase.

### Performance Optimization
```text
/refactor Optimize the time complexity of the selected code. Avoid redundant iterations and lookups.
```

### Code Modernization
```text
Rewrite this function to use modern ES6+ features, specifically async/await, arrow functions, and object destructuring.
```

### Modularization
```text
Break down the selected long function into smaller, single-responsibility helper functions.
```

---

## 4. Documentation & Tests

Use these prompts to build tests and documentation quickly.

### Writing Docstrings
```text
/doc Generate a Google-style docstring for the selected function. Specify parameter types and return values.
```

### Writing Test Suites
```text
/tests Generate a comprehensive test suite using Python's unittest library. Mock any external network requests or database connections using unittest.mock.
```
