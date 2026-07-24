# Building RESTful APIs with ASP.NET Core

## Overview

This module introduces the development of RESTful Web APIs using **ASP.NET Core 8.0**. It demonstrates how to create APIs that follow REST principles, process HTTP requests, and exchange data using JSON. The project implements a simple Product Management API with CRUD operations.

---

## Objectives

* Understand REST architecture and HTTP methods.
* Create Web APIs using ASP.NET Core 8.
* Implement CRUD (Create, Read, Update, Delete) operations.
* Use Controllers, Models, and Services.
* Test APIs using Swagger UI.
* Return appropriate HTTP status codes.

---

## Prerequisites

* Visual Studio 2022 or Visual Studio Code
* .NET 8 SDK
* Basic knowledge of C#
* ASP.NET Core Web API template

---

## Folder Structure

```text
02-Building-RESTful-APIs-with-ASP.NET-Core
│── README.md
│── Notes.md
└── Code
    └── ProductAPI
        ├── Controllers
        ├── Models
        ├── Services
        ├── Program.cs
        ├── appsettings.json
        ├── ProductAPI.csproj
        ├── Output.txt
        └── Output.png
```

---

## Project Description

The ProductAPI project provides REST endpoints to manage products. The API uses an in-memory collection to store product data and demonstrates clean separation of concerns using Controllers, Models, and Services.

---

## API Endpoints

| HTTP Method | Endpoint             | Description                |
| ----------- | -------------------- | -------------------------- |
| GET         | `/api/products`      | Retrieve all products      |
| GET         | `/api/products/{id}` | Retrieve a product by ID   |
| POST        | `/api/products`      | Create a new product       |
| PUT         | `/api/products/{id}` | Update an existing product |
| DELETE      | `/api/products/{id}` | Delete a product           |

---

## Technologies Used

* ASP.NET Core 8.0
* C#
* REST API
* Swagger (OpenAPI)
* Dependency Injection

---

## How to Run

1. Open the **ProductAPI** project.
2. Restore NuGet packages.
3. Build the solution.
4. Run the project using:

```bash
dotnet run
```

5. Open Swagger:

```
https://localhost:<port>/swagger
```

6. Test all available endpoints.

---

## Expected Output

* Swagger UI opens successfully.
* Product endpoints return JSON responses.
* CRUD operations execute successfully.
* Appropriate HTTP status codes are returned.

---

## Learning Outcomes

After completing this exercise, you will be able to:

* Design RESTful APIs.
* Build ASP.NET Core Web APIs.
* Implement CRUD operations.
* Organize projects using Controllers, Models, and Services.
* Test APIs with Swagger.
* Understand dependency injection in ASP.NET Core.

---

## Conclusion

This exercise provides hands-on experience in developing RESTful APIs with ASP.NET Core 8. It establishes a strong foundation for building scalable, maintainable, and secure backend services using modern .NET development practices.
