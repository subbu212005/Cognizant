# API Security and Exception Handling

## Introduction

API security protects applications from unauthorized access, while exception handling ensures consistent error responses and improves application reliability.

---

## Global Exception Handling

Middleware can handle application-wide exceptions.

Example

```csharp
app.UseExceptionHandler("/error");
```

---

## Logging with Serilog

Serilog records application logs for debugging and monitoring.

Example

```csharp
Log.Information("Application Started");
```

---

## API Keys

API Keys restrict access to authorized users.

Example

```
X-API-KEY: abc123
```

---

## OAuth

OAuth enables secure delegated authorization.

Workflow

- User Login
- Authorization Server
- Access Token
- Protected API

---

## CORS

Cross-Origin Resource Sharing allows APIs to be accessed from different domains.

Example

```csharp
builder.Services.AddCors();
```

---

## Advantages

- Secure APIs
- Better monitoring
- Centralized exception handling
- Controlled API access

---

## Learning Outcome

After completing this topic, I learned global exception handling, Serilog logging, API key authentication, OAuth, and CORS configuration.

---

## Conclusion

Security and exception handling are essential for building reliable and secure ASP.NET Core Web APIs.

