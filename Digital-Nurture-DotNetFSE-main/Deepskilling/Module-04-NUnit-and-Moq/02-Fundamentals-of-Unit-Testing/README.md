# Fundamentals of Unit Testing

## Introduction

Unit Testing is a software testing technique in which individual units or components of an application are tested independently to verify that they work correctly.

Unit tests help developers detect defects early, improve code quality, and simplify maintenance.

---

## Characteristics of Good Unit Tests

A good unit test should be:

### Fast

Tests should execute quickly.

### Independent

Tests should not depend on other tests.

### Repeatable

Tests should produce the same result every time.

### Self-Validating

Tests should automatically determine pass or fail status.

### Maintainable

Tests should be easy to understand and update.

---

## What to Test and What Not to Test

### What to Test

* Business Logic
* Calculations
* Validation Rules
* Public Methods
* Edge Cases

### What Not to Test

* Third-Party Libraries
* Framework Code
* Simple Getters and Setters
* Database Connectivity (Unit Tests)

---

## Naming and Organizing Tests

Test names should clearly describe the behavior being tested.

### Recommended Format

```text id="6qzkn6"
MethodName_Scenario_ExpectedResult
```

### Example

```text id="e8x0ol"
Add_ValidNumbers_ReturnsSum
```

Organize tests into separate test classes based on application modules.

---

## Black-Box Testing

Black-Box Testing focuses on testing functionality without knowing the internal implementation details.

### Example

Input:

```text id="z4o1t9"
2 + 3
```

Expected Output:

```text id="udyy54"
5
```

The internal code structure is not considered.

---

## Set Up and Tear Down

### SetUp

Executed before each test method.

```csharp id="w17wsr"
[SetUp]
public void Setup()
{
    // Initialization code
}
```

### TearDown

Executed after each test method.

```csharp id="4cbv3y"
[TearDown]
public void Cleanup()
{
    // Cleanup code
}
```

---

## Parameterized Tests

Parameterized tests allow the same test logic to run with multiple inputs.

### Example

```csharp id="nltw14"
[TestCase(2, 3, 5)]
[TestCase(5, 5, 10)]
[TestCase(10, 20, 30)]
public void Add_ReturnsCorrectResult(
    int a,
    int b,
    int expected)
{
    Assert.AreEqual(expected, a + b);
}
```

### Benefits

* Less code duplication
* Better test coverage
* Easier maintenance

---

## Ignoring Tests

Tests can be temporarily skipped using the Ignore attribute.

### Example

```csharp id="yrm5u5"
[Test]
[Ignore("Feature under development")]
public void FutureFeatureTest()
{
}
```

---

## Writing Trustworthy Tests

A trustworthy test should:

* Test one behavior at a time
* Avoid dependencies on external systems
* Use meaningful assertions
* Produce consistent results
* Be easy to understand

### Example

```csharp id="x7wfjw"
Assert.AreEqual(5, calculator.Add(2, 3));
```

---

## Best Practices

* Keep tests simple
* Use descriptive names
* Follow Arrange-Act-Assert pattern
* Test edge cases
* Avoid duplicate test logic

### Arrange-Act-Assert Example

```csharp id="vk0dwp"
var calculator = new Calculator();

var result = calculator.Add(2, 3);

Assert.AreEqual(5, result);
```

---

## Learning Outcome

After completing this topic, I understood the principles of effective unit testing, test organization, parameterized testing, setup and teardown methods, and best practices for creating reliable and maintainable unit tests.

---

## Conclusion

Unit testing is a fundamental software quality practice that helps developers verify functionality, detect defects early, and build reliable applications.

