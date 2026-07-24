# API Security and Exception Handling

This project is an ASP.NET Core Web API built with **.NET 8.0 / 10.0** demonstrating custom global exception handling middleware and a foundation for API security.

---

## Getting Started

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or higher

### Installation & Run

1. Clone or download this project.
2. Navigate to the project directory:
   ```bash
   cd Code/SecureApiDemo
   ```
3. Run the application:
   ```bash
   dotnet run
   ```
4. The server will start and listen on:
   - **Local Web Server**: [http://localhost:5000](http://localhost:5000)

---

## API Endpoints

Once the application is running, you can access:

| Endpoint | Method | Description | Response Example |
| :--- | :--- | :--- | :--- |
| `/swagger` | GET | Swagger UI documentation | Interactive API Console |
| `/api/secure` | GET | Secure response demonstration | `{"message": "Secure endpoint"}` |

---

## Project Architecture & Structure

```text
SecureApiDemo/
│
├── Controllers/
│   └── SecureController.cs      # API Controller defining endpoints
│
├── Middleware/
│   └── ExceptionMiddleware.cs   # Global try-catch exception handling middleware
│
├── Models/
│   └── User.cs                  # User model schema
│
├── appsettings.json             # JWT configuration & Logging settings
├── Program.cs                   # Application entry point & service registrations
└── SecureApiDemo.csproj         # MSBuild project file (with Swashbuckle.AspNetCore)
```

### Key Components

#### 1. Global Exception Handling Middleware
The [ExceptionMiddleware.cs](file:///C:/Users/subbu/Downloads/05-API-Security-and-Exception-Handling/05-API-Security-and-Exception-Handling/Code/SecureApiDemo/Middleware/ExceptionMiddleware.cs) catches any unhandled exceptions during the HTTP request pipeline, returns a standard `500 Internal Server Error` status code, and sends a safe error message to the client.

#### 2. Configuration Settings
[appsettings.json](file:///C:/Users/subbu/Downloads/05-API-Security-and-Exception-Handling/05-API-Security-and-Exception-Handling/Code/SecureApiDemo/appsettings.json) includes the JWT configuration properties required to build out token authentication:
```json
"Jwt": {
  "Issuer": "Demo",
  "Audience": "Demo",
  "Key": "VerySecretKey123456"
}
```
