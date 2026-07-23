# Notes – Microservice Communication and Data Management

## Communication Methods

* REST API (HTTP)
* gRPC
* Message Queues
* Event-Driven Communication

---

## REST API

* Uses HTTP protocol
* JSON data format
* Platform independent
* Easy to develop

---

## gRPC

* High performance
* Binary communication
* Uses Protocol Buffers
* Low latency

---

## Messaging

Examples

* RabbitMQ
* Kafka
* Azure Service Bus

Benefits

* Asynchronous communication
* Reliable delivery
* Loose coupling

---

## Service Discovery

Purpose

* Locate services dynamically.
* Avoid hardcoded URLs.
* Improve scalability.

Examples

* Consul
* Eureka
* Kubernetes

---

## Database Patterns

### Database per Service

* Independent database
* Better scalability
* Loose coupling

### Shared Database

* One database
* Simple architecture
* Tight coupling

---

## Entity Framework Core

Features

* ORM
* LINQ
* Migrations
* Code First
* Database First

---

## Data Consistency

Common Techniques

* Saga Pattern
* Eventual Consistency
* Outbox Pattern
* Distributed Events

---

## Advantages

* Independent deployment
* High scalability
* Better fault isolation
* Flexible technology stack

---

## Challenges

* Network latency
* Distributed transactions
* Service communication failures
* Monitoring complexity

---

## Best Practices

* Prefer REST or gRPC.
* Use Database per Service.
* Implement retries.
* Secure APIs with JWT.
* Enable centralized logging.
* Monitor service health.

---

## Summary

Microservices communicate using REST APIs, gRPC, or messaging systems while maintaining independent databases. ASP.NET Core Web API and Entity Framework Core provide an effective platform for building scalable, secure, and maintainable distributed applications.
