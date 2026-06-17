# Single Responsibility Principle (SRP)

## Definition

A class should have only one reason to change.

In simple terms, a class should focus on a single responsibility instead of handling multiple unrelated tasks.

## Why SRP?

When a class performs many responsibilities:

* Code becomes difficult to maintain.
* Small changes may affect unrelated functionality.
* Testing becomes harder.
* Reusability decreases.

## Example Problem

Consider a Student class that:

* Stores student details.
* Calculates grades.
* Saves data to a database.

If database requirements change, the Student class changes.

If grading logic changes, the same class changes again.

This violates SRP because the class has multiple responsibilities.

## Solution

Separate responsibilities into different classes:

* Student → Stores student information.
* GradeCalculator → Calculates grades.
* StudentRepository → Handles database operations.

## Code Example

```csharp
using System;

class Book
{
    public string Title { get; set; }
}

class BookPrinter
{
    public void Print(Book book)
    {
        Console.WriteLine(book.Title);
    }
}

class Program
{
    static void Main()
    {
        Book b = new Book();
        b.Title = "C# Programming";

        BookPrinter printer = new BookPrinter();
        printer.Print(b);
    }
}
```

### Explanation

In this example, the `Book` class is responsible only for storing book information. The `BookPrinter` class is responsible for printing book details. Since each class has a single responsibility, the code follows the Single Responsibility Principle.

## Benefits

* Better maintainability
* Easier testing
* Reduced coupling
* Improved readability

## Real World Example

A restaurant waiter takes orders.

The waiter should not cook food and manage accounting at the same time.

Each role has a single responsibility.

## Conclusion

The Single Responsibility Principle helps developers create clean, maintainable, and scalable applications by ensuring that each class focuses on only one responsibility.
