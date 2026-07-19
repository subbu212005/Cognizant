# Component and Service Testing

## Overview

Angular applications are built using Components and Services. Components manage the user interface, while Services contain reusable business logic. Testing both ensures that the application behaves correctly and remains reliable.

Angular provides **TestBed**, **ComponentFixture**, and **Dependency Injection** to simplify testing.

In this exercise, you will learn how to test an Angular Component and an Angular Service using Jasmine and Karma.

---

## Learning Objectives

After completing this exercise, you will be able to:

- Understand Component Testing.
- Understand Service Testing.
- Configure TestBed.
- Write Jasmine test cases.
- Test component properties and methods.
- Test Angular services.

---

## Prerequisites

Before starting this exercise, ensure you have:

- Angular CLI installed
- Basic knowledge of Angular Components
- Basic knowledge of Angular Services
- Jasmine and Karma configured

---

## What is Component Testing?

Component Testing verifies that a component:

- Is created successfully.
- Displays the correct data.
- Executes methods correctly.
- Updates the UI as expected.

---

## What is Service Testing?

Service Testing verifies that:

- Service methods return correct values.
- Business logic works correctly.
- Dependency Injection functions properly.

---

## TestBed

TestBed creates a testing module similar to Angular's runtime environment.

Example:

```typescript
await TestBed.configureTestingModule({
  imports: [App]
}).compileComponents();
```

---

## ComponentFixture

ComponentFixture provides access to:

- Component instance
- HTML template
- Change detection

---

## Expected Output

```
Chrome Headless

Executed 5 of 5 SUCCESS

TOTAL: 5 SUCCESS
```

---

## Advantages

- Improves code quality.
- Detects bugs early.
- Ensures component stability.
- Verifies business logic.
- Supports Continuous Integration.

---

## Real-World Applications

- Banking Systems
- E-Commerce Websites
- Healthcare Portals
- Enterprise Dashboards
- Educational Platforms

---

## Interview Questions

1. What is TestBed?
2. What is ComponentFixture?
3. What is Service Testing?
4. How do you test an Angular Component?
5. How do you test an Angular Service?
6. Why is Dependency Injection important in testing?

---

## Summary

Component and Service Testing help verify that Angular applications work correctly. Angular's TestBed and Jasmine framework make writing and executing automated tests straightforward.

---

## Learning Outcome

After completing this exercise, you will be able to:

- Test Angular Components.
- Test Angular Services.
- Configure TestBed.
- Verify component and service behavior.
