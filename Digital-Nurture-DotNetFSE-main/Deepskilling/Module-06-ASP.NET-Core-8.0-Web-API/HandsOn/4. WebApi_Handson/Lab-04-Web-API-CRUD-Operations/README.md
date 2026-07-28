# Lab 4: Web API CRUD Operations

## Objective

This hands-on demonstrates how to perform CRUD (Create, Read, Update, and Delete) operations using ASP.NET Core Web API. The application updates employee information using HTTP PUT requests and validates employee IDs before processing the request.

---

# Learning Objectives

After completing this lab, you will be able to:

- Perform CRUD operations using ASP.NET Core Web API.
- Use the FromBody attribute.
- Update employee data.
- Validate employee IDs.
- Return appropriate ActionResult responses.
- Test APIs using Swagger and Postman.

---

# Software Requirements

- Visual Studio 2022
- .NET 8 SDK
- ASP.NET Core Web API
- Swagger
- Postman

---

# CRUD Operations

## Create

HTTP POST

Adds a new employee.

---

## Read

HTTP GET

Returns employee information.

---

## Update

HTTP PUT

Updates an existing employee.

---

## Delete

HTTP DELETE

Deletes an employee.

---

# FromBody Attribute

The FromBody attribute binds JSON data from the request body to an Employee object.

Example

```csharp
public IActionResult Put(int id, [FromBody] Employee employee)
```

---

# Validation Rules

If

```
id <= 0
```

Return

```
400 Bad Request

Invalid employee id
```

If employee ID is not available

```
400 Bad Request

Invalid employee id
```

---

# Testing

Swagger

- GET
- PUT
- POST
- DELETE

Postman

- GET
- PUT
- POST
- DELETE

---

# Expected Response

Success

```
200 OK
```

Failure

```
400 Bad Request
```

---

# Conclusion

Successfully implemented CRUD operations, request validation, and tested APIs using Swagger and Postman.