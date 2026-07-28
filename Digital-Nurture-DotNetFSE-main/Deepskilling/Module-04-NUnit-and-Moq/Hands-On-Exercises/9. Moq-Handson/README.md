# 9. Moq-Handson

# Mocking External Dependencies using Moq

## Objective

This hands-on demonstrates how to use the Moq framework to isolate external dependencies while writing unit tests. The application tests the `USDToEuro()` method of the `Converter` class by mocking the external exchange rate service.

---

# Learning Objectives

After completing this hands-on, you will be able to:

- Understand Mocking.
- Understand Dependency Injection.
- Use the Moq Framework.
- Create mock objects.
- Write isolated unit tests.
- Use Assert.That().
- Follow the Single Assertion Rule.

---

# Software Requirements

- Visual Studio 2022
- .NET 8 SDK
- NUnit
- NUnit3TestAdapter
- Moq

---

# Why Mocking?

Unit tests should not depend on:

- Database
- File System
- Network
- External APIs
- Third-party Services

Instead, these dependencies are replaced with Mock Objects.

---

# Business Scenario

The Converter class converts USD to Euro.

Instead of calling the real exchange rate service, a mocked service returns a predefined exchange rate.

---

# Dependency

```csharp
IDollarToEuroExchangeRateFeed
```

---

# Benefits of Moq

- Faster Tests
- Reliable Tests
- Independent Tests
- No Internet Required
- Easy to Maintain

---

# Test Scenario

Input

```
100 USD
```

Mock Exchange Rate

```
0.92
```

Expected Output

```
92 Euro
```

---

# Conclusion

Successfully isolated external dependencies using the Moq framework and verified currency conversion using NUnit.