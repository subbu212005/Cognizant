# 8. NUnit-Handson

# Exception Testing using NUnit

## Objective

This hands-on demonstrates how to test methods that throw exceptions using the NUnit framework. The application validates the PAN card number while creating a user account.

---

# Learning Objectives

After completing this exercise, you will be able to:

- Understand exception testing in NUnit.
- Test methods that throw exceptions.
- Use Assert.That() with Throws.
- Handle NullReferenceException.
- Handle FormatException.
- Test successful execution (Happy Path).
- Follow the Single Assertion Rule.

---

# Software Requirements

- Visual Studio 2022
- .NET 8 SDK
- NUnit
- NUnit3TestAdapter

---

# Business Rules

A user can be created only if the PAN card number is valid.

PAN Card Rules

- PAN Card is mandatory.
- PAN Card length must be exactly 10 characters.

---

# Exceptions

| Exception | Condition |
|------------|-----------|
| NullReferenceException | PAN Card is null or empty |
| FormatException | PAN Card length is not equal to 10 |

---

# Test Scenarios

### Happy Path

Create user with a valid PAN Card.

### Scenario 1

PAN Card is null.

### Scenario 2

PAN Card is empty.

### Scenario 3

PAN Card length is less than 10.

### Scenario 4

PAN Card length is greater than 10.

---

# NUnit Assertions

```csharp
Assert.That(...)

Throws.TypeOf<Exception>()
```

---

# Conclusion

Successfully tested all exception scenarios and verified successful user creation using NUnit.