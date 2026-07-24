# Module-06 – ASP.NET Core 8.0 Web API

## Overview

This repository contains the practical exercises and learning materials for **Module 06 – ASP.NET Core 8.0 Web API**. The module introduces the fundamentals of developing modern Web APIs using **ASP.NET Core 8**, covering RESTful API development, advanced API features, SOAP services, API security, exception handling, documentation, and testing.

Each topic contains:

* **README.md** – Concept explanation and implementation guide
* **Notes.md** – Quick reference notes
* **Code** – Complete ASP.NET Core 8 project
* **Output.png** – Screenshot of successful execution
* **Output.txt** – Sample API response/output

---

# Module Structure

```text
Module-06-ASP.NET-Core-8.0-Web-API
│── README.md
│
├── 01-Introduction-to-Web-APIs-and-ASP.NET-Core
│   ├── README.md
│   ├── Notes.md
│   └── Code
│       └── WebApiDemo
│
├── 02-Building-RESTful-APIs-with-ASP.NET-Core
│   ├── README.md
│   ├── Notes.md
│   └── Code
│       └── ProductAPI
│
├── 03-Advanced-API-Features
│   ├── README.md
│   ├── Notes.md
│   └── Code
│       └── AdvancedApiDemo
│
├── 04-Consuming-and-Creating-SOAP-Services
│   ├── README.md
│   ├── Notes.md
│   └── Code
│       └── SoapServiceDemo
│
├── 05-API-Security-and-Exception-Handling
│   ├── README.md
│   ├── Notes.md
│   └── Code
│       └── SecureApiDemo
│
└── 06-API-Documentation-and-Testing
    ├── README.md
    ├── Notes.md
    └── Code
        └── SwaggerDemo
```

---

# Topics Covered

## 1. Introduction to Web APIs and ASP.NET Core

**Project:** WebApiDemo

Topics:

* Introduction to Web APIs
* ASP.NET Core Architecture
* Controllers
* Routing
* HTTP Request and Response
* JSON Serialization
* Swagger Introduction

---

## 2. Building RESTful APIs with ASP.NET Core

**Project:** ProductAPI

Topics:

* REST Architecture
* CRUD Operations
* GET, POST, PUT, DELETE
* Models
* Controllers
* Services
* Dependency Injection
* JSON Responses

---

## 3. Advanced API Features

**Project:** AdvancedApiDemo

Topics:

* Pagination
* Filtering
* Custom Middleware
* Action Filters
* Request Logging
* API Best Practices

---

## 4. Consuming and Creating SOAP Services

**Project:** SoapServiceDemo

Topics:

* SOAP Architecture
* WSDL
* Service Contracts
* SOAP Services
* SOAP Client
* XML Messages

---

## 5. API Security and Exception Handling

**Project:** SecureApiDemo

Topics:

* Authentication
* Authorization
* JWT Basics
* Secure Endpoints
* Global Exception Handling
* Custom Middleware
* Error Responses

---

## 6. API Documentation and Testing

**Project:** SwaggerDemo

Topics:

* Swagger/OpenAPI
* API Documentation
* Swagger UI
* API Testing
* HTTP Response Validation
* Postman Testing

---

# Technologies Used

* ASP.NET Core 8.0
* C#
* .NET 8 SDK
* RESTful APIs
* SOAP Services
* Swagger (OpenAPI)
* Dependency Injection
* Middleware
* JSON
* Visual Studio 2022 / Visual Studio Code

---

# Software Requirements

* Windows 10/11
* Visual Studio 2022 or Visual Studio Code
* .NET 8 SDK
* Postman (Optional)
* Git (Optional)

---

# How to Run

1. Open any project inside the **Code** folder.
2. Restore NuGet packages.
3. Build the project.

```bash
dotnet build
```

4. Run the project.

```bash
dotnet run
```

5. Open Swagger UI.

```text
https://localhost:<port>/swagger
```

6. Test the available API endpoints.

---

# Learning Outcomes

After completing this module, you will be able to:

* Develop Web APIs using ASP.NET Core 8.
* Design RESTful services following industry standards.
* Implement CRUD operations.
* Build reusable Controllers, Models, and Services.
* Create custom Middleware and Action Filters.
* Develop and consume SOAP services.
* Secure APIs using authentication and authorization.
* Handle exceptions using global middleware.
* Document APIs with Swagger/OpenAPI.
* Test APIs using Swagger UI and Postman.

---

# Repository Contents

| Folder                                       | Description                                    |
| -------------------------------------------- | ---------------------------------------------- |
| 01-Introduction-to-Web-APIs-and-ASP.NET-Core | Introduction to ASP.NET Core Web APIs          |
| 02-Building-RESTful-APIs-with-ASP.NET-Core   | REST API implementation with CRUD              |
| 03-Advanced-API-Features                     | Middleware, Filters, and advanced API concepts |
| 04-Consuming-and-Creating-SOAP-Services      | SOAP service implementation                    |
| 05-API-Security-and-Exception-Handling       | API security and exception handling            |
| 06-API-Documentation-and-Testing             | Swagger documentation and API testing          |

---

# Conclusion

This module provides a comprehensive foundation in **ASP.NET Core 8 Web API** development. Through practical projects and structured exercises, learners gain hands-on experience in designing, developing, securing, documenting, and testing enterprise-grade Web APIs using modern .NET technologies.
