# Unit Testing with Jasmine and Karma

## Overview

Unit Testing is the process of testing individual units or components of an application to ensure they work correctly. Angular provides built-in support for unit testing using **Jasmine** (testing framework) and **Karma** (test runner).

- **Jasmine** is used to write test cases.
- **Karma** executes those test cases in a browser and displays the results.

This exercise demonstrates how to write simple unit tests for an Angular component.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand Unit Testing.
- Understand Jasmine.
- Understand Karma.
- Write test cases using Jasmine.
- Execute tests using Karma.
- Verify expected application behavior.

---

## Prerequisites

Before starting this exercise, ensure you have:

- Angular CLI installed
- Basic knowledge of Angular Components
- Basic knowledge of TypeScript

---

## What is Unit Testing?

Unit Testing verifies that an individual piece of code (component, service, function, or class) behaves as expected.

Example:

- Test a button click.
- Test a calculation method.
- Test a component property.

---

## Jasmine

Jasmine is a Behavior-Driven Development (BDD) testing framework.

Common Jasmine functions:

- describe()
- it()
- expect()
- beforeEach()

---

## Karma

Karma is a test runner that:

- Launches a browser
- Executes Jasmine test cases
- Displays pass/fail results
- Generates coverage reports

---

## Creating a Test

Angular automatically creates a `.spec.ts` file for every component.

Example:

```
app.spec.ts
```

---

## Running Tests

Execute:

```bash
ng test
```

Karma opens a browser and executes all test cases.

---

## Expected Output

```
Chrome Headless

Executed 3 of 3 SUCCESS

TOTAL: 3 SUCCESS
```

---

## Advantages

- Detects bugs early.
- Improves application reliability.
- Supports Continuous Integration (CI).
- Simplifies maintenance.
- Encourages better code quality.

---

## Real-World Applications

- Banking Systems
- E-Commerce Applications
- Healthcare Systems
- Enterprise Software
- Government Portals

---

## Interview Questions

1. What is Unit Testing?
2. What is Jasmine?
3. What is Karma?
4. What is describe()?
5. What is it()?
6. What is expect()?
7. Why is Unit Testing important?

---

## Summary

Unit Testing ensures that each part of an Angular application functions correctly. Jasmine provides an easy way to write tests, while Karma automates test execution in the browser.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Write Jasmine test cases.
- Execute tests using Karma.
- Verify Angular component behavior.
- Build more reliable Angular applications.
