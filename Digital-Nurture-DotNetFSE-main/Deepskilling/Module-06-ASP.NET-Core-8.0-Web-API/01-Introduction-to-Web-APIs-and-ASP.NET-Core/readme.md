# Introduction to Web API

## What is a Web API?

A Web API (Application Programming Interface) is an interface that allows communication between different software applications over the HTTP protocol.

A Web API exposes data and functionality through URLs (Endpoints). Clients such as web applications, mobile apps, or desktop applications can consume these APIs.

Example:

Client
   |
HTTP Request
   |
Web API
   |
Database

The API processes the request and returns the response in JSON format.

## Features

- Platform Independent
- Language Independent
- Uses HTTP Protocol
- Lightweight
- Returns JSON or XML
- Supports CRUD Operations

## Advantages

- Easy communication between applications
- Secure
- Scalable
- Faster development
- Easy integration with mobile and web applications

## Common HTTP Methods

GET
Retrieve Data

POST
Create Data

PUT
Update Data

DELETE
Delete Data

PATCH
Partial Update

## Example API

GET /api/products

Response

[
  {
    "id":1,
    "name":"Laptop",
    "price":60000
  }
]
