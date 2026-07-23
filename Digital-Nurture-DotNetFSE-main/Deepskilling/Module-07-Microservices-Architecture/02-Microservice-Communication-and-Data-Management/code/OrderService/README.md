# Order Service

## Overview

The **Order Service** is a RESTful microservice developed using **ASP.NET Core 8 Web API**. It is responsible for managing customer orders in the Microservices Architecture module. The service provides APIs to create, retrieve, update, and delete orders while communicating with the **Product Service** to validate product information before processing an order.

This project demonstrates **Microservice Communication and Data Management** using HTTP-based inter-service communication.

---

## Objectives

- Understand the role of an independent Order Microservice.
- Build REST APIs using ASP.NET Core 8.
- Implement CRUD operations for orders.
- Consume Product Service APIs using `HttpClient`.
- Learn synchronous communication between microservices.
- Test APIs using Swagger and Postman.

---

## Technologies Used

- ASP.NET Core 8 Web API
- C#
- Entity Framework Core In-Memory Database
- HttpClient
- REST API
- Swagger UI
- Visual Studio 2022 / VS Code

---

## Project Structure

```
OrderService
│
├── Controllers
│   └── OrdersController.cs
│
├── Data
│   └── OrderDbContext.cs
│
├── Models
│   └── Order.cs
│
├── Properties
│
├── Program.cs
├── OrderService.csproj
├── OrderService.http
├── appsettings.json
├── appsettings.Development.json
├── Output.txt
└── README.md
```

---

## Order Model

The Order entity contains the following properties:

| Property | Description |
|----------|-------------|
| Id | Unique Order ID |
| ProductId | ID of the ordered product |
| Quantity | Number of items ordered |
| CustomerName | Name of the customer |

---

## API Endpoints

### Get All Orders

```
GET /api/orders
```

Returns all available orders.

---

### Get Order by ID

```
GET /api/orders/{id}
```

Returns a specific order using its ID.

---

### Create Order

```
POST /api/orders
```

Creates a new order after validating the Product ID using the Product Service.

Example Request Body

```json
{
  "productId": 1,
  "quantity": 2,
  "customerName": "John"
}
```

---

### Update Order

```
PUT /api/orders/{id}
```

Updates an existing order.

---

### Delete Order

```
DELETE /api/orders/{id}
```

Deletes an order from the database.

---

## Microservice Communication

The Order Service communicates with the **Product Service** using **HttpClient**.

Workflow:

1. Client sends an order request.
2. Order Service receives the request.
3. Order Service calls Product Service.
4. Product Service validates the product.
5. If product exists, order is created.
6. Response is returned to the client.

```
Client
   │
   ▼
Order Service
   │
HttpClient
   │
   ▼
Product Service
   │
Product Validation
   │
   ▼
Order Created
```

---

## Running the Application

### Step 1

Navigate to the project directory.

```bash
cd OrderService
```

### Step 2

Restore packages.

```bash
dotnet restore
```

### Step 3

Build the project.

```bash
dotnet build
```

### Step 4

Run the application.

```bash
dotnet run
```

---

## Swagger

After running the application, open:

```
https://localhost:<port>/swagger
```

Swagger displays all available REST endpoints for testing.

---

## Sample Output

```
Order Service Started...

GET /api/orders

[
  {
    "id":1,
    "productId":1,
    "quantity":2,
    "customerName":"John"
  }
]
```

---

## Learning Outcomes

After completing this exercise, you will be able to:

- Develop an independent Order Microservice.
- Implement RESTful CRUD APIs.
- Use Entity Framework Core In-Memory Database.
- Perform synchronous microservice communication using HttpClient.
- Validate requests through another microservice.
- Test APIs using Swagger and Postman.
- Understand service-to-service communication in Microservices Architecture.

---

## Conclusion

The **Order Service** demonstrates how a microservice can independently manage order-related operations while communicating with another microservice (Product Service) to validate business data. This exercise provides practical experience with REST APIs, ASP.NET Core 8, Entity Framework Core, and microservice communication patterns.
