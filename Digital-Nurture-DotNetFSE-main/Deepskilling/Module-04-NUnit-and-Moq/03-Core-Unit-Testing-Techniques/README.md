# Core Unit Testing Techniques

## Introduction

Core Unit Testing Techniques help developers verify different types of methods and application behaviors. NUnit provides various assertions and testing approaches to validate strings, collections, return values, exceptions, and method behavior.

These techniques improve software reliability and code quality.

---

## Testing Strings

String testing verifies text values returned by methods.

### Example

```csharp
[Test]
public void FullName_ReturnsCorrectValue()
{
    string fullName = "Subrahmanyeswara";

    Assert.AreEqual(
        "Subrahmanyeswara",
        fullName);
}
```

### Common Assertions

* Assert.AreEqual()
* Assert.AreNotEqual()
* Assert.IsTrue()
* Assert.IsFalse()

---

## Testing Arrays and Collections

Collections can be tested to verify contents, count, and order.

### Example

```csharp
[Test]
public void List_ShouldContainThreeElements()
{
    var numbers = new List<int>
    {
        10, 20, 30
    };

    Assert.AreEqual(3, numbers.Count);
}
```

### Collection Assertions

```csharp
CollectionAssert.Contains(numbers, 20);
CollectionAssert.AllItemsAreUnique(numbers);
```

---

## Testing Return Type of Methods

Verify whether a method returns the correct value.

### Example

```csharp
[Test]
public void Add_ReturnsCorrectResult()
{
    int result = 10 + 20;

    Assert.AreEqual(30, result);
}
```

### Return Type Check

```csharp
Assert.IsInstanceOf<int>(result);
```

---

## Testing Void Methods

Void methods do not return values.

Testing focuses on verifying behavior or state changes.

### Example

```csharp
[Test]
public void SaveStudent_ShouldExecuteWithoutException()
{
    Assert.DoesNotThrow(() =>
    {
        Console.WriteLine("Student Saved");
    });
}
```

---

## Testing Methods that Throw Exceptions

NUnit provides assertions for exception testing.

### Example

```csharp
[Test]
public void DivideByZero_ShouldThrowException()
{
    Assert.Throws<DivideByZeroException>(() =>
    {
        int result = 10 / int.Parse("0");
    });
}
```

### Benefits

* Verifies error handling
* Improves application reliability

---

## Testing Private Methods

Private methods are generally tested indirectly through public methods.

### Example

```csharp
public int Square(int number)
{
    return CalculateSquare(number);
}

private int CalculateSquare(int number)
{
    return number * number;
}
```

### Test

```csharp
[Test]
public void Square_ReturnsCorrectValue()
{
    Assert.AreEqual(25, Square(5));
}
```

---

## Code Coverage

Code Coverage measures how much application code is executed during testing.

### Benefits

* Identifies untested code
* Improves test quality
* Reduces production defects

### Coverage Types

#### Statement Coverage

Measures executed statements.

#### Branch Coverage

Measures executed decision paths.

#### Function Coverage

Measures executed methods.

---

## Best Practices

* Test one behavior at a time
* Use meaningful assertions
* Cover edge cases
* Keep tests independent
* Aim for high code coverage

---

## Learning Outcome

After completing this topic, I understood how to test strings, collections, return values, void methods, exception handling, and measure code coverage using NUnit.

---

## Conclusion

Core unit testing techniques help ensure application correctness, improve maintainability, and increase confidence in software quality.

