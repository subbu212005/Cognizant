# Single Responsibility Principle (SRP)

## Definition
A class should have only one reason to change.

In simple terms, a class should focus on a single responsibility instead of handling multiple unrelated tasks.

## Why SRP?
When a class performs many responsibilities:

- Code becomes difficult to maintain.
- Small changes may affect unrelated functionality.
- Testing becomes harder.
- Reusability decreases.

## Example Problem
Consider a Student class that:

- Stores student details.
- Calculates grades.
- Saves data to a database.

If database requirements change, the Student class changes.

If grading logic changes, the same class changes again.

This violates SRP because the class has multiple responsibilities.

## Solution
Separate responsibilities into different classes:

- Student → Stores student information.
- GradeCalculator → Calculates grades.
- StudentRepository → Handles database operations.

## Explanation
In this example, the Book class is responsible only for storing book information. The BookPrinter class is responsible for printing book details. Since each class has a single responsibility, the code follows the Single Responsibility Principle.

## Benefits
- Better maintainability
- Easier testing
- Reduced coupling
- Improved readability

## Real World Example

In a college management system:

- Student class → Stores student information.
- GradeCalculator class → Calculates student grades.
- StudentRepository class → Saves and retrieves student data from the database.

Each class has a single responsibility. If the grading logic changes, only the GradeCalculator class needs to be modified. If the database changes, only the StudentRepository class needs to be updated.

This follows the Single Responsibility Principle (SRP).

## Conclusion
The Single Responsibility Principle helps developers create clean, maintainable, and scalable applications by ensuring that each class focuses on only one responsibility.
