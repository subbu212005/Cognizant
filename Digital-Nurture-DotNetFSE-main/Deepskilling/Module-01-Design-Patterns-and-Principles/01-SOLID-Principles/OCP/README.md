# Open Closed Principle (OCP)

## Definition
Software entities such as classes, modules, and functions should be open for extension but closed for modification.

This means we should be able to add new functionality without changing existing code.

## Why OCP?

- Reduces the risk of introducing bugs.
- Improves code maintainability.
- Makes applications easier to extend.
- Encourages reusable and scalable designs.

## Example Problem

Suppose we have a Shape class that calculates the area of different shapes.

If we add a new shape, we would need to modify the existing class repeatedly.

This violates the Open Closed Principle.

## Solution

Instead of modifying existing code, create new classes that extend the behavior.

For example:

- Shape → Base class
- Circle → Derived class
- Rectangle → Derived class

Each new shape can implement its own area calculation without changing existing code.

## Benefits

- Easy to extend
- Better maintainability
- Reduced risk of errors
- Improved scalability

## Real World Example

Consider a payment system:

- Credit Card Payment
- UPI Payment
- Net Banking Payment

When a new payment method is introduced, a new class can be added without modifying existing payment classes.

This follows the Open Closed Principle.

## Program Output

```text
Area of Circle: 78.5
```

## Conclusion

The Open Closed Principle helps developers create flexible and extensible applications by allowing behavior to be extended without modifying existing code.
