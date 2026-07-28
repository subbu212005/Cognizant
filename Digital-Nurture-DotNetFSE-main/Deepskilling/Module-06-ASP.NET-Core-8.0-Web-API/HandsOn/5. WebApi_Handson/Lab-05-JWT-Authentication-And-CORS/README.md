# Lab 5: JWT Authentication and CORS in ASP.NET Core Web API

## Objective

This hands-on demonstrates how to secure ASP.NET Core Web APIs using JSON Web Tokens (JWT), enable CORS for cross-origin requests, implement role-based authorization, and test APIs using Postman.

---

# Learning Objectives

- Understand JWT Authentication.
- Generate JWT Tokens.
- Enable Authentication Middleware.
- Implement Role-Based Authorization.
- Configure CORS.
- Test secured APIs using Postman.
- Verify token expiration.
- Validate Authorization headers.

---

# Software Requirements

- Visual Studio 2022
- .NET 8 SDK
- ASP.NET Core Web API
- Postman
- Microsoft.AspNetCore.Authentication.JwtBearer

---

# What is JWT?

JWT (JSON Web Token) is a secure token-based authentication mechanism.

Structure

Header

↓

Payload

↓

Signature

---

# Authentication Flow

Client Login

↓

JWT Generated

↓

Client Stores Token

↓

Authorization Header

↓

Web API Validation

↓

Authorized Response

---

# Configure JWT

Program.cs

```csharp
builder.Services.AddAuthentication();

app.UseAuthentication();

app.UseAuthorization();
```

---

# Generate JWT Token

Claims

- UserId
- Role

Issuer

```
mySystem
```

Audience

```
myUsers
```

Secret Key

```
mysuperdupersecret
```

---

# CORS

Enable CORS

```csharp
builder.Services.AddCors();
```

```csharp
app.UseCors();
```

---

# Role-Based Authorization

```csharp
[Authorize(Roles="Admin")]
```

```csharp
[Authorize(Roles="Admin,POC")]
```

---

# Testing

Swagger

- Generate Token
- Copy Token

Postman

Authorization

```
Bearer <JWT_TOKEN>
```

Verify

- 200 OK
- 401 Unauthorized

---

# JWT Expiration

Set

```csharp
expires: DateTime.Now.AddMinutes(2)
```

After 2 minutes

```
401 Unauthorized
```

---

# Expected Results

Without Token

```
401 Unauthorized
```

Invalid Token

```
401 Unauthorized
```

Expired Token

```
401 Unauthorized
```

Valid Token

```
200 OK
```

---

# Conclusion

Successfully secured Web APIs using JWT authentication, role-based authorization, CORS configuration, and Postman testing.