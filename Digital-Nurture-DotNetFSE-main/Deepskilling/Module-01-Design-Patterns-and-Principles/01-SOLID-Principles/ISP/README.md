# Interface Segregation Principle (ISP)

## Definition
Clients should not be forced to depend on interfaces they do not use.

Instead of creating one large interface, it is better to create multiple smaller and specific interfaces.

## Why ISP?

- Reduces unnecessary dependencies.
- Makes code easier to maintain.
- Improves flexibility and scalability.
- Prevents classes from implementing unused methods.

## Example Problem

Suppose we have a Printer interface containing:

- Print()
- Scan()
- Fax()

A simple printer may only need the Print() method, but it would still be forced to implement Scan() and Fax().

This violates the Interface Segregation Principle.

## Solution

Split the large interface into smaller interfaces:

- IPrint
- IScan
- IFax

Each class implements only the interfaces it requires.

## Benefits

- Better maintainability
- Reduced coupling
- Improved flexibility
- Easier testing

## Real World Example

Consider a university management system:

- IStudent → Student-related operations
- ITeacher → Teacher-related operations
- IAdmin → Administrative operations

Each user implements only the functionality relevant to their role.

This follows the Interface Segregation Principle.

## Program Output

```text
Printing Document...
```

## Conclusion

The Interface Segregation Principle helps create focused and efficient interfaces, ensuring that classes only implement methods they actually need.

