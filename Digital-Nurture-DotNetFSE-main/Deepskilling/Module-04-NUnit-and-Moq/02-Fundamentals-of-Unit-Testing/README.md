# UnitTestingFundamentals

## Overview

**UnitTestingFundamentals** is a simple .NET 8 console application that demonstrates the core concepts of **Unit Testing** using the **NUnit** framework. It covers writing effective unit tests, organizing test cases, parameterized testing, setup and teardown methods, and ignoring tests.

This project helps developers understand how to verify application logic through automated testing and serves as a foundation for Test-Driven Development (TDD).

---

## Objectives

- Understand the fundamentals of unit testing.
- Learn the characteristics of good unit tests.
- Write test cases using the NUnit framework.
- Use parameterized tests to reduce duplicate code.
- Perform setup and cleanup using NUnit attributes.
- Skip tests using the Ignore attribute.
- Follow best practices for organizing unit tests.

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
UnitTestingFundamentals
│
├── Services
│   └── CalculatorService.cs
│
├── Tests
│   ├── CalculatorServiceTests.cs
│   ├── ParameterizedTests.cs
│   ├── SetupTeardownTests.cs
│   └── IgnoreTests.cs
│
├── Program.cs
└── UnitTestingFundamentals.csproj
```

---

## Features

- Calculator service implementation.
- NUnit test fixture examples.
- Parameterized unit tests.
- Setup and TearDown methods.
- Ignore test demonstration.
- Simple console application for verification.

---

## Example Service

```csharp
public class CalculatorService
{
    public int Add(int a, int b) => a + b;

    public int Multiply(int a, int b) => a * b;
}
```

---

## Example Test

```csharp
[Test]
public void Add_ReturnsSum()
{
    var service = new CalculatorService();

    Assert.That(service.Add(2, 3), Is.EqualTo(5));
}
```

---

## Parameterized Test Example

```csharp
[TestCase(2, 3, 5)]
[TestCase(4, 5, 9)]
public void Add_TestCases(int a, int b, int expected)
{
    var service = new CalculatorService();

    Assert.That(service.Add(a, b), Is.EqualTo(expected));
}
```

---

## Setup and TearDown Example

```csharp
[SetUp]
public void Setup()
{
    // Executed before each test
}

[TearDown]
public void TearDown()
{
    // Executed after each test
}
```

---

## Ignore Test Example

```csharp
[Test]
[Ignore("Demo ignored test")]
public void IgnoredTest()
{
}
```

---

## Sample Output

```text
4 * 5 = 20
```

---

## How to Run

### Restore Packages

```bash
dotnet restore
```

### Build the Project

```bash
dotnet build
```

### Run the Application

```bash
dotnet run
```

### Execute Unit Tests

```bash
dotnet test
```

---

## Expected Result

Application Output

```text
4 * 5 = 20
```

NUnit Output

```text
Passed! All tests passed.
```

---

## Best Practices

- Keep tests independent.
- Write meaningful test names.
- Follow the Arrange-Act-Assert pattern.
- Use parameterized tests whenever possible.
- Keep each test focused on a single behavior.
- Avoid testing external dependencies in unit tests.

---

## Learning Outcome

After completing this project, you will be able to:

- Create unit tests using NUnit.
- Organize test projects effectively.
- Write reusable parameterized tests.
- Use Setup and TearDown methods.
- Skip tests using the Ignore attribute.
- Build reliable and maintainable .NET applications.

---

## References

- https://docs.nunit.org/
- https://learn.microsoft.com/dotnet/core/testing/
- https://www.tutorialspoint.com/unit-testing-tutorial-for-beginners-concepts-types-tools
- https://www.geeksforgeeks.org/software-engineering-black-box-testing/

---

**Author:** Cognizant Digital Nurture 4.0 – .NET FSE Learning Program
