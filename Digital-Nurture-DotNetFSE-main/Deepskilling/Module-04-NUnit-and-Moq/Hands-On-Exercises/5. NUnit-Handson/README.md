# 5. NUnit-Handson

# Collection Testing using NUnit

## Objective

This hands-on demonstrates how to test collections using the NUnit framework. It focuses on validating employee collections, checking uniqueness, verifying object existence, and comparing collections using CollectionAssert and Assert.That().

---

# Learning Objectives

After completing this hands-on, you will be able to:

- Understand NUnit collection assertions.
- Use CollectionAssert.
- Use Assert.That() with Constraint Model.
- Validate collections.
- Verify unique objects.
- Compare collections.
- Override Equals() and GetHashCode() methods.

---

# Software Requirements

- Visual Studio 2022
- .NET 8 SDK
- NUnit
- NUnit3TestAdapter

---

# CollectionAssert Methods

## CollectionAssert.AllItemsAreNotNull()

Checks whether every item in the collection is not null.

---

## CollectionAssert.Contains()

Checks whether an object exists inside a collection.

---

## CollectionAssert.AllItemsAreUnique()

Checks whether every object in the collection is unique.

---

## CollectionAssert.AreEqual()

Checks whether two collections contain the same elements.

---

# Test Scenarios

### Scenario 1

Verify that employee collection does not contain null values.

### Scenario 2

Verify employee with ID = 100 exists.

### Scenario 3

Verify employee collection contains only unique employees.

### Scenario 4

Compare two employee collections.

---

# Conclusion

Successfully verified collection operations using NUnit CollectionAssert and Assert.That().