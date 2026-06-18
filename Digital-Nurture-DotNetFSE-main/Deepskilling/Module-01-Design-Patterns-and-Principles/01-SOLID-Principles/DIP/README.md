# Dependency Inversion Principle (DIP)

## Definition
High-level modules should not depend on low-level modules. Both should depend on abstractions.

In simple terms, classes should depend on interfaces or abstractions rather than concrete implementations.

## Why DIP?

- Reduces coupling between classes.
- Makes code more flexible and maintainable.
- Improves testability.
- Makes it easier to replace implementations.

## Example Problem

Suppose a Computer class directly creates a Keyboard object.

If we want to use a different keyboard implementation, we must modify the Computer class.

This violates the Dependency Inversion Principle.

## Solution

Create an abstraction (interface) between the Computer and Keyboard classes.

- IKeyboard → Interface
- Keyboard → Implementation
- Computer → Depends on IKeyboard

Now any keyboard implementation can be used without changing the Computer class.

## Benefits

- Better maintainability
- Loose coupling
- Improved flexibility
- Easier unit testing

## Real World Example

Consider a notification system:

- INotification → Interface
- EmailNotification → Implementation
- SMSNotification → Implementation

The application depends on the INotification interface rather than a specific notification type.

This follows the Dependency Inversion Principle.

## Program Output

```text
Computer Created Successfully
```

## Conclusion

The Dependency Inversion Principle promotes loose coupling by making classes depend on abstractions instead of concrete implementations, resulting in flexible and scalable software.
