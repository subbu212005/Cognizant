# Factory Method Pattern

## Definition
The Factory Method Pattern provides an interface for creating objects without specifying their exact class.

It allows object creation to be delegated to subclasses or factory classes.

## Why Factory Method?

- Reduces tight coupling.
- Improves code flexibility.
- Makes code easier to maintain.
- Supports scalability.

## Example Problem

Suppose an application needs different types of vehicles such as Cars and Bikes.

Creating objects directly using the new keyword throughout the application makes the code difficult to maintain.

## Solution

A factory class is used to create the required object based on user requirements.

## Benefits

- Loose coupling
- Better maintainability
- Improved scalability
- Centralized object creation

## Real World Example

A vehicle manufacturing company produces different types of vehicles.

Instead of creating vehicle objects directly, a factory creates the required vehicle.

This follows the Factory Method Pattern.

## Program Output

```text
Car Created
Bike Created
```

## Conclusion

The Factory Method Pattern centralizes object creation and improves flexibility by allowing the system to create objects without exposing the creation logic.
