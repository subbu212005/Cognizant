# 3. NUnit-Handson

# URL Host Name Parser Testing using NUnit

## Objective

This hands-on demonstrates how to write automated unit tests using the NUnit framework. The application tests the `ParseHostName()` method of the `UrlHostNameParser` class under different scenarios.

---

# Learning Objectives

After completing this hands-on, you will be able to:

- Understand NUnit Framework
- Use NUnit custom attributes
- Write automated unit tests
- Test methods with different execution paths
- Use Assert.That()
- Follow the Single Assertion Rule

---

# Software Requirements

- Visual Studio 2022
- .NET 8 SDK
- NUnit
- NUnit3TestAdapter

---

# NUnit Attributes Used

## TestFixture

Marks the class as a test class.

```csharp
[TestFixture]
```

---

## Test

Marks a method as a unit test.

```csharp
[Test]
```

---

## SetUp

Runs before every test.

```csharp
[SetUp]
```

---

# ParseHostName()

The ParseHostName() method extracts the hostname from a given URL.

Example

Input

```
https://www.google.com/search
```

Output

```
www.google.com
```

---

# Test Scenarios

### Scenario 1

Valid URL returns the correct hostname.

### Scenario 2

Invalid URL returns null.

---

# Steps Performed

1. Created NUnit Test Project.
2. Added UtilLib reference.
3. Installed NUnit packages.
4. Wrote test methods.
5. Executed tests.
6. Verified output.

---

# Conclusion

Successfully tested the ParseHostName() method using NUnit framework.