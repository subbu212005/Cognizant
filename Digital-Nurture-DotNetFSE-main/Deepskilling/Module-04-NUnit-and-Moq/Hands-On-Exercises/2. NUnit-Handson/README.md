# 2. NUnit-Handson

# Parameterized Test Cases using NUnit

## Objective

This hands-on demonstrates parameterized testing, assertion methods, exception handling, and testing void methods using the NUnit framework.

---

## Learning Objectives

- Understand parameterized test cases using TestCase.
- Test methods that return values.
- Use Assert.AreEqual().
- Use Assert.Fail().
- Handle exceptions using try-catch.
- Test void methods.
- Understand why private methods are generally not unit tested.
- Learn the basics of the Moq framework.

---

## Software Requirements

- Visual Studio 2022
- .NET 8 SDK
- NUnit
- NUnit3TestAdapter

---

## Concepts Covered

### Parameterized Tests

Parameterized tests allow one test method to run with multiple input values.

Example

```csharp
[TestCase(10,5,5)]
[TestCase(20,8,12)]
```

### Assert.AreEqual()

Compares expected and actual values.

### Assert.Fail()

Marks the test as failed when an expected exception is not thrown.

### Exception Testing

Use try-catch to verify exception type and message.

### Void Method Testing

The AllClear() method resets the calculator result to zero. Verify using the GetResult property.

### Why Not Test Private Methods?

Private methods are implementation details. Unit tests should validate public behavior.

### Mocking Framework

Mocking is used to isolate dependencies such as databases, files, and external services. Moq is a popular .NET mocking framework.

---

## Conclusion

Successfully implemented parameterized test cases, exception handling, assertions, and void method testing using NUnit.