# 6. NUnit-Handson

# Four Seasons Testing using NUnit TestCaseSource

## Objective

This hands-on demonstrates how to use the **TestCaseSource** attribute in NUnit to reduce duplicate test code. The application tests the `GetSeason()` method, which determines the season based on the given month.

---

# Learning Objectives

After completing this exercise, you will be able to:

- Understand the TestCaseSource attribute.
- Write parameterized unit tests.
- Minimize duplicate code.
- Use Assert.That().
- Follow the Single Assertion Rule.
- Test multiple execution paths using one test method.

---

# Software Requirements

- Visual Studio 2022
- .NET 8 SDK
- NUnit
- NUnit3TestAdapter
- Moq

---

# Seasons Mapping

| Season | Months | Climate |
|---------|--------|---------|
| Spring | February - March | Sunny and Pleasant |
| Summer | April - June | Hot |
| Monsoon | July - September | Wet, Hot and Humid |
| Autumn | September - November | Pleasant |
| Winter | December - January | Very Cool |

---

# NUnit Attribute

## TestCaseSource

Supplies multiple input values from a single data source.

Example

```csharp
[TestCaseSource(nameof(SeasonTestCases))]
```

Advantages

- Eliminates duplicate test methods.
- Improves readability.
- Easier maintenance.

---

# Test Scenarios

- Spring
- Summer
- Monsoon
- Autumn
- Winter

---

# Conclusion

Successfully tested the Four Seasons application using NUnit TestCaseSource with a single parameterized test method.