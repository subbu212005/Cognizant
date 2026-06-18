# Liskov Substitution Principle (LSP)

## Definition
Objects of a derived class should be able to replace objects of a base class without affecting the correctness of the program.

In simple terms, a child class should behave like its parent class and should not break the expected functionality.

## Why LSP?

- Promotes proper inheritance.
- Improves code reusability.
- Makes applications easier to maintain.
- Prevents unexpected behavior.

## Example Problem

Suppose we have a Bird class and a Sparrow class that inherits from Bird.

A Sparrow can perform all actions of a Bird, so it can safely replace a Bird object.

This follows the Liskov Substitution Principle.

## Solution

- Bird → Base Class
- Sparrow → Derived Class

The Sparrow class can be used wherever a Bird object is expected.

## Benefits

- Better maintainability
- Proper inheritance usage
- Improved code flexibility
- Easier testing

## Real World Example

Consider a vehicle rental system:

- Vehicle → Base Class
- Car → Derived Class
- Bike → Derived Class

Any Car or Bike object can be used wherever a Vehicle object is expected.

This follows the Liskov Substitution Principle.

## Program Output

```text
Sparrow flies
```

## Conclusion

The Liskov Substitution Principle ensures that derived classes can replace their base classes without affecting program behavior.
