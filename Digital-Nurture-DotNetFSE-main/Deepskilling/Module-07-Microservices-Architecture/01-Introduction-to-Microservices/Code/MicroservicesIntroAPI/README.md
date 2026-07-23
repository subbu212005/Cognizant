# MicroservicesIntroAPI

## Overview

**MicroservicesIntroAPI** is a simple ASP.NET Core Web API project created to understand the fundamentals of Microservices Architecture. It demonstrates how to build a lightweight RESTful API using ASP.NET Core and serves as the foundation for learning service-based application development.

---

## Objective

* Learn the basics of Microservices Architecture.
* Create a simple ASP.NET Core Web API.
* Understand the project structure of an ASP.NET Core application.
* Test REST API endpoints using Swagger or the `.http` file.

---

## Technologies Used

* ASP.NET Core 8.0 Web API
* C#
* .NET 8 SDK
* Swagger (OpenAPI)

---

## Project Structure

```text
MicroservicesIntroAPI
│
├── Controllers
│   └── WeatherForecastController.cs
│
├── Models
│   └── WeatherForecast.cs
│
├── Properties
│   └── launchSettings.json
│
├── appsettings.json
├── appsettings.Development.json
├── MicroservicesIntroAPI.csproj
├── MicroservicesIntroAPI.http
├── Program.cs
├── Output.txt
└── README.md
```

---

## How to Run the Project

### Clone the Repository

```bash
git clone <repository-url>
```

### Navigate to the Project

```bash
cd MicroservicesIntroAPI
```

### Restore Packages

```bash
dotnet restore
```

### Run the Application

```bash
dotnet run
```

---

## Testing the API

Open the Swagger UI in your browser after running the project.

Example:

```
https://localhost:5001/swagger
```

Or use the provided **MicroservicesIntroAPI.http** file to send HTTP requests.

---

## Sample Response

```json
[
  {
    "day": "Monday",
    "temperature": 30,
    "summary": "Sunny"
  }
]
```

---

## Files Description

| File                         | Description                                       |
| ---------------------------- | ------------------------------------------------- |
| Program.cs                   | Application entry point and service configuration |
| WeatherForecastController.cs | API controller exposing REST endpoints            |
| WeatherForecast.cs           | Model representing weather data                   |
| appsettings.json             | Application configuration                         |
| launchSettings.json          | Local development settings                        |
| MicroservicesIntroAPI.http   | HTTP requests for API testing                     |
| Output.txt                   | Sample output of the application                  |

---

## Learning Outcome

After completing this project, you will be able to:

* Understand the basics of Microservices Architecture.
* Create and run an ASP.NET Core Web API.
* Build RESTful API endpoints.
* Test APIs using Swagger and HTTP request files.
* Understand the folder structure of an ASP.NET Core Web API project.

---

## Conclusion

This project serves as a beginner-friendly introduction to Microservices using ASP.NET Core Web API. It provides the foundation required to build more advanced microservices involving service communication, authentication, Docker, Kubernetes, and cloud deployment.
