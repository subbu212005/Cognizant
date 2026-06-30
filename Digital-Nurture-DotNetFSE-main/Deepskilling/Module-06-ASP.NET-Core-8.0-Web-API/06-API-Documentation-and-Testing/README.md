# API Documentation and Testing

## Introduction

API documentation helps developers understand and use Web APIs efficiently. Swagger/OpenAPI automatically generates interactive API documentation, while Postman and REST Client help test API endpoints.

---

## Swagger/OpenAPI

Swagger generates interactive API documentation.

Enable Swagger

```csharp
builder.Services.AddSwaggerGen();

app.UseSwagger();

app.UseSwaggerUI();
```

Access

```
https://localhost:5001/swagger
```

---

## Benefits of Swagger

- Interactive UI
- Automatic documentation
- Test APIs directly
- Improves developer productivity

---

## Postman

Postman is used for testing REST APIs.

Common Operations

- GET
- POST
- PUT
- DELETE

Example

```
GET https://localhost:5001/api/students
```

---

## REST Client

REST Client is a Visual Studio Code extension for testing APIs directly from `.http` files.

Example

```http
GET https://localhost:5001/api/students
```

---

## Advantages

- Easy API testing
- Automatic documentation
- Faster debugging
- Better collaboration

---

## Learning Outcome

After completing this topic, I learned how to integrate Swagger/OpenAPI, test APIs using Postman and REST Client, and document ASP.NET Core Web APIs.

---

## Conclusion

Swagger and Postman simplify API development by providing interactive documentation, testing tools, and faster debugging, making Web API development more efficient.
