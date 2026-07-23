# ProductService

## Overview
**ProductService** is a .NET 8 Web API microservice developed as part of the **Cognizant Digital Nurture 5.0 – Module 07: Microservices Architecture**.

This service manages product-related operations in an e-commerce system. It exposes REST APIs for creating, retrieving, updating, and deleting product information. The service uses **Entity Framework Core** with an **In-Memory Database**, making it lightweight and suitable for learning microservices architecture.

---

## Objectives

- Understand Microservices Architecture.
- Build an independent Product Service.
- Implement RESTful APIs using ASP.NET Core Web API.
- Use Entity Framework Core In-Memory Database.
- Test APIs using Swagger UI.

---

## Technologies Used

- ASP.NET Core 8.0 Web API
- C#
- Entity Framework Core
- EF Core In-Memory Database
- Swagger (OpenAPI)

---

## Project Structure

```
ProductService/
│── Controllers/
│     └── ProductsController.cs
│
│── Data/
│     └── ProductDbContext.cs
│
│── Models/
│     └── Product.cs
│
│── Properties/
│
│── Program.cs
│── ProductService.csproj
│── ProductService.http
│── appsettings.json
│── appsettings.Development.json
│── README.md
│── products.png
│── productsswagger.png
```

---

## Product Model

The Product entity contains the following fields:

| Property | Type |
|----------|------|
| Id | int |
| Name | string |
| Price | decimal |
| Category | string |

---

## API Endpoints

### Get All Products

```
GET /api/products
```

Returns all available products.

---

### Get Product by ID

```
GET /api/products/{id}
```

Returns a specific product.

---

### Add Product

```
POST /api/products
```

Creates a new product.

Example JSON

```json
{
  "name": "Laptop",
  "price": 65000,
  "category": "Electronics"
}
```

---

### Update Product

```
PUT /api/products/{id}
```

Updates an existing product.

---

### Delete Product

```
DELETE /api/products/{id}
```

Deletes a product.

---

## Running the Project

### Clone Repository

```bash
git clone <repository-url>
```

---

### Navigate to Project

```bash
cd ProductService
```

---

### Restore Packages

```bash
dotnet restore
```

---

### Run Application

```bash
dotnet run
```

---

### Swagger URL

```
https://localhost:<port>/swagger
```

or

```
http://localhost:<port>/swagger
```

---

## Sample Output

### Product API

Include the screenshot below:

**products.png**

Shows the successful execution of Product API requests.

---

### Swagger UI

Include the screenshot below:

**productsswagger.png**

Displays all ProductService REST endpoints available for testing.

---

## Learning Outcomes

After completing this project, you will be able to:

- Understand the role of ProductService in Microservices Architecture.
- Develop RESTful APIs using ASP.NET Core.
- Perform CRUD operations using Entity Framework Core.
- Use In-Memory Database for development.
- Test APIs using Swagger UI.
- Build independently deployable microservices.

---

## Conclusion

ProductService demonstrates how a microservice independently manages product data while exposing REST APIs for client applications or other services. This implementation provides a foundation for building scalable distributed applications using ASP.NET Core Microservices.
