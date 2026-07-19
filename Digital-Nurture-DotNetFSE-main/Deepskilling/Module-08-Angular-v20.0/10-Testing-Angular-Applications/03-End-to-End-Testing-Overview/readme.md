# End-to-End (E2E) Testing Overview

## Overview

End-to-End (E2E) Testing verifies the complete workflow of an application from the user's perspective. Unlike Unit Testing, which tests individual components or services, E2E Testing checks whether the entire application works correctly by simulating real user interactions.

Modern Angular applications commonly use tools such as **Playwright** and **Cypress** for E2E testing.

This exercise introduces the concepts of E2E testing and demonstrates a simple Playwright test for an Angular application.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand End-to-End (E2E) Testing.
- Differentiate Unit Testing and E2E Testing.
- Understand browser automation.
- Learn the basics of Playwright.
- Write a simple E2E test.

---

## Prerequisites

Before starting this exercise, ensure you have:

- Angular CLI installed
- Angular application running
- Basic knowledge of Angular
- Basic knowledge of testing concepts

---

## What is End-to-End Testing?

End-to-End Testing validates the complete functionality of an application by simulating real user behavior.

Examples:

- Opening a web page
- Clicking buttons
- Filling forms
- Logging in
- Submitting data
- Verifying displayed information

---

## Unit Testing vs E2E Testing

| Unit Testing | End-to-End Testing |
|--------------|-------------------|
| Tests a single component or service | Tests the entire application |
| Faster | Slower |
| Uses Jasmine and Karma | Uses Playwright or Cypress |
| Focuses on code correctness | Focuses on user workflows |

---

## Playwright

Playwright is Microsoft's browser automation framework.

Install Playwright:

```bash
npm init playwright@latest
```

---

## Sample Playwright Test

```typescript
import { test, expect } from '@playwright/test';

test('Home Page Test', async ({ page }) => {

  await page.goto('http://localhost:4200');

  await expect(page.locator('h1'))
    .toHaveText('Component and Service Testing');

});
```

---

## Running Playwright Tests

```bash
npx playwright test
```

---

## Expected Output

```
Running 1 test

✓ Home Page Test

1 passed
```

---

## Advantages

- Tests complete application workflow.
- Simulates real user behavior.
- Detects integration issues.
- Improves software quality.
- Supports Continuous Integration.

---

## Real-World Applications

- Banking Applications
- Online Shopping
- Railway Reservation
- Hospital Management
- Student Portals
- Enterprise Applications

---

## Interview Questions

1. What is E2E Testing?
2. Why is E2E Testing important?
3. What is Playwright?
4. What is Cypress?
5. Difference between Unit Testing and E2E Testing?
6. When should E2E tests be executed?

---

## Summary

End-to-End Testing ensures that the complete Angular application works as expected from the user's perspective. Tools like Playwright automate browser interactions and help identify issues across the entire application workflow.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Understand E2E Testing.
- Use Playwright for browser automation.
- Write a simple E2E test.
- Validate complete Angular application workflows.
