# Understanding Dependency Injection in Angular

## Overview

Dependency Injection (DI) is one of Angular's core features. It is a design pattern that allows a class to receive its required dependencies from an external source rather than creating them itself.

Angular's built-in Dependency Injection framework simplifies component communication, improves code reusability, and makes applications easier to test and maintain.

---

# Learning Objectives

After completing this exercise, you will be able to:

- Understand Dependency Injection (DI).
- Learn how Angular injects dependencies.
- Create a simple service.
- Inject a service into a component.
- Display data from a service.

---

# What is Dependency Injection?

Dependency Injection is a technique in which one object supplies the dependencies of another object.

Instead of creating objects using the `new` keyword, Angular automatically creates and injects them where needed.

### Without Dependency Injection

```typescript
studentService = new StudentService();
