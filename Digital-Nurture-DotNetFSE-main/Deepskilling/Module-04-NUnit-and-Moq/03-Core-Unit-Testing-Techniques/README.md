# Core Unit Testing Techniques

## Introduction

Core Unit Testing Techniques help developers verify different types of methods and application behaviors. NUnit provides various assertions and testing approaches to validate strings, collections, return values, exceptions, and method behavior.

These techniques improve software reliability and code quality.


## Overview

**CoreTestingTechniques** is a .NET 8 console application that demonstrates essential **NUnit unit testing techniques**. The project includes examples of testing strings, collections, return types, void methods, exception handling, private methods, and code coverage concepts.

It is designed to help developers understand how to write reliable and maintainable unit tests using the NUnit framework.

---

## Objectives

After completing this project, you will be able to:

- Test string values.
- Test arrays and collections.
- Verify method return types.
- Test void methods.
- Test methods that throw exceptions.
- Understand testing private methods.
- Learn the basics of code coverage.

---

## Technologies Used

- .NET 8
- C#
- NUnit
- NUnit3TestAdapter
- Microsoft.NET.Test.Sdk
- Visual Studio 2022 / Visual Studio Code

---

## Project Structure

```text
CoreTestingTechniques
│
├── Models
│   └── Student.cs
│
├── Services
│   └── StudentService.cs
│
├── Tests
│   ├── StringTests.cs
│   ├── CollectionTests.cs
│   ├── ReturnTypeTests.cs
│   ├── VoidMethodTests.cs
│   ├── ExceptionTests.cs
│   ├── PrivateMethodTests.cs
│   └── CodeCoverageDemo.cs
│
├── Program.cs
└── CoreTestingTechniques.csproj
```

---

## Features

- String comparison testing
- Collection testing
- Return type verification
- Void method testing
- Exception handling tests
- Private method testing concepts
- Code coverage demonstration
- Student management example

---

## Student Model

```csharp
public class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = "";
}
```

---

## Student Service

The service provides methods to:

- Add students
- Retrieve students
- Search students by Id
- Validate student information
- Generate greeting messages

---

## Test Files

### StringTests.cs

Tests string return values.

Example:

```csharp
Assert.That(service.GetGreeting("John"),
            Is.EqualTo("Hello John"));
```

---

### CollectionTests.cs

Tests collection operations.

Example:

```csharp
service.AddStudent(student);

Assert.That(service.GetStudents().Count,
            Is.EqualTo(1));
```

---

### ReturnTypeTests.cs

Verifies the return type of methods.

Example:

```csharp
Assert.That(service.FindById(1),
            Is.TypeOf<Student>());
```

---

### VoidMethodTests.cs

Tests methods that do not return values.

Example:

```csharp
service.AddStudent(student);

Assert.Pass();
```

---

### ExceptionTests.cs

Verifies that exceptions are thrown correctly.

Example:

```csharp
Assert.Throws<ArgumentException>(
    () => service.Validate(new Student()));
```

---

### PrivateMethodTests.cs

Private methods are generally **not tested directly**.

Instead, they are tested indirectly through the public methods that use them.

---

### CodeCoverageDemo.cs

Demonstrates the concept of code coverage.

Tools commonly used include:

- Visual Studio Code Coverage
- Coverlet
- ReportGenerator

---

## Program Output

Running the application:

```bash
dotnet run
```

Console Output:

```text
Students Count: 1
```

---

## Running Unit Tests

Restore packages:

```bash
dotnet restore
```

Build the project:

```bash
dotnet build
```

Run all NUnit tests:

```bash
dotnet test
```

---

## Expected Test Result

```text
Passed! All tests passed.
```

---

## Best Practices

- Test one behavior per test method.
- Use meaningful test names.
- Keep tests independent.
- Follow the Arrange-Act-Assert (AAA) pattern.
- Avoid testing implementation details.
- Test public behavior rather than private methods.
- Write fast and reliable tests.

---

## Learning Outcomes

After completing this project, you will be able to:

- Write NUnit tests for different scenarios.
- Test strings and collections.
- Verify return types.
- Validate exceptions.
- Test void methods.
- Understand indirect testing of private methods.
- Measure code coverage for .NET applications.

---

## Sample Console Output

```text
Students Count: 1
```

---

## References

- https://docs.nunit.org/
- https://learn.microsoft.com/dotnet/core/testing/
- https://www.c-sharpcorner.com/article/introduction-to-nunit-testing-framework/
- https://dotnetpattern.com/nunit-introduction

---

**Author:** Cognizant Digital Nurture 4.0 – .NET Full Stack Engineer Learning Program

