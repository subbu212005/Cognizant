# 4. NUnit-Handson

# User Login Validation using NUnit

## Objective

This hands-on demonstrates how to write automated unit tests using the NUnit framework for validating employee login functionality.

---

# Learning Objectives

After completing this exercise, you will be able to:

- Understand NUnit Framework.
- Use NUnit custom attributes.
- Test login functionality.
- Validate expected outputs.
- Test exception handling.
- Use Assert.That().
- Follow the Single Assertion Rule.

---

# Software Requirements

- Visual Studio 2022
- .NET 8 SDK
- NUnit
- NUnit3TestAdapter

---

# Login Module

The AccountsManagerLib allows employees to log into the EMS portal.

Valid Credentials

| User Id | Password |
|----------|----------|
| user_11 | secret@user11 |
| user_22 | secret@user22 |

---

# Expected Results

### Valid Credentials

```
Welcome user_11!!!
```

---

### Invalid Credentials

```
Invalid user id/password
```

---

### Empty UserId or Password

Throws

```
ArgumentException
```

---

# NUnit Attributes

## TestFixture

Marks a test class.

## SetUp

Runs before every test.

## Test

Marks a method as a test case.

---

# Test Scenarios

- Valid Login
- Invalid Login
- Empty UserId
- Empty Password

---

# Conclusion

Successfully verified employee login functionality using NUnit assertions and exception handling.