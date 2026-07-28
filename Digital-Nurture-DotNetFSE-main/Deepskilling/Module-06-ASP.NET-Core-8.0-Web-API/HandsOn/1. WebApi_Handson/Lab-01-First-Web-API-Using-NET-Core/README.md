# Lab 1: First Web API using .NET Core

## Objective

This hands-on demonstrates how to create a simple ASP.NET Core Web API application using the .NET 8 Web API template. The application exposes RESTful endpoints using HTTP action verbs such as GET, POST, PUT, and DELETE.

---

# Learning Objectives

After completing this lab, you will be able to:

- Understand RESTful Web Services
- Understand Web APIs
- Understand Microservices
- Explain HTTP Request and HTTP Response
- Use HTTP Action Verbs
- Return HTTP Status Codes
- Create a simple ASP.NET Core Web API
- Understand ASP.NET Core configuration files

---

# RESTful Web Service

REST (Representational State Transfer) is an architectural style for designing lightweight web services that communicate over HTTP.

### Features

- Stateless
- Client-Server Architecture
- Cacheable
- Uniform Interface
- Platform Independent
- Supports JSON and XML

---

# Web API

A Web API is an interface that allows applications to communicate over HTTP.

Example

```
Client
   │
HTTP Request
   │
ASP.NET Core Web API
   │
HTTP Response (JSON)
```

---

# Microservices

A Microservice is a small independently deployable service responsible for a single business function.

Advantages

- Independent Deployment
- Easy Maintenance
- High Scalability
- Better Fault Isolation

---

# HTTP Request

A request sent by the client to the server.

Example

```
GET /api/values
```

---

# HTTP Response

The server sends data back to the client.

Example

```
HTTP/1.1 200 OK

[
    "Value1",
    "Value2"
]
```

---

# HTTP Action Verbs

| Verb | Description |
|------|-------------|
| GET | Retrieve Data |
| POST | Insert Data |
| PUT | Update Data |
| DELETE | Delete Data |

---

# HTTP Status Codes

| Status Code | Meaning |
|------------|---------|
|200 OK|Request Successful|
|400 Bad Request|Invalid Request|
|401 Unauthorized|Authentication Required|
|500 Internal Server Error|Server Error|

---

# Configuration Files

### Program.cs

Configures services and middleware.

### appsettings.json

Stores application settings and connection strings.

### launchSettings.json

Stores launch configuration.

---

# Procedure

## Step 1

Create a new Web API project.

```bash
dotnet new webapi -n FirstWebApi
```

## Step 2

Open the project in Visual Studio.

## Step 3

Create a controller with Read and Write actions.

## Step 4

Run the application.

```bash
dotnet run
```

## Step 5

Open Swagger UI.

```
https://localhost:5001/swagger
```

## Step 6

Execute the GET endpoint.

---

# Expected Output

```
GET /api/values

Response

[
    "Value1",
    "Value2"
]
```

---

# Conclusion

Successfully created and executed a simple ASP.NET Core Web API application demonstrating REST principles, HTTP verbs, controllers, and HTTP status codes.