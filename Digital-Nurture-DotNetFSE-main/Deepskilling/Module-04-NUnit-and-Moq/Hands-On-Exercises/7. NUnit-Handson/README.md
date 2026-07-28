# 7. NUnit-Handson

# Leap Year Calculator Testing using NUnit

## Objective

This hands-on demonstrates how to write parameterized unit test cases using the NUnit framework. The application determines whether a given year is a leap year and validates the input range.

---

# Learning Objectives

After completing this exercise, you will be able to:

- Understand parameterized testing.
- Use NUnit TestCase attribute.
- Use Assert.That().
- Validate multiple inputs using a single test method.
- Follow the Single Assertion Rule.

---

# Software Requirements

- Visual Studio 2022
- .NET 8 SDK
- NUnit
- NUnit3TestAdapter

---

# Business Rules

The LeapYearCalculatorLib returns:

| Input | Output |
|--------|--------|
| Leap Year | 1 |
| Non-Leap Year | 0 |
| Invalid Year | -1 |

Valid Year Range

```
1753 - 9999
```

---

# Parameterized Tests

The TestCase attribute allows multiple inputs to be tested using one method.

Example

```csharp
[TestCase(2024,1)]
[TestCase(2023,0)]
[TestCase(1200,-1)]
```

Advantages

- Less Code
- Better Readability
- Easy Maintenance

---

# Test Scenarios

- Leap Year
- Non-Leap Year
- Invalid Year (<1753)
- Invalid Year (>9999)

---

# Conclusion

Successfully implemented parameterized unit tests using NUnit TestCase and Assert.That().