# API Documentation and Testing (Swagger/OpenAPI Demo)

This project demonstrates how to configure and use Swagger/OpenAPI for API documentation and interactive testing in an ASP.NET Core Web API application.

---

## Project Structure

* **`Code/SwaggerDemo/`**: The root folder of the ASP.NET Core application.
  * **`Program.cs`**: Application startup, middleware pipeline configuration, and dependency injection setup.
  * **`SwaggerDemo.csproj`**: The project configuration file containing target framework and NuGet package references (e.g., `Swashbuckle.AspNetCore`).
  * **`Controllers/WeatherController.cs`**: A sample API controller exposing the weather endpoint.
  * **`appsettings.json`**: Application settings and configuration.

---

## Prerequisites

To run this project, make sure you have the [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed on your system.

---

## Getting Started

### 1. Build the Project
Open your terminal, navigate to the `Code/SwaggerDemo` directory, and run the following command to restore packages and build the project:

```powershell
cd Code/SwaggerDemo
dotnet build
```

### 2. Run the Project
Start the local development server:

```powershell
dotnet run
```

By default, the server will start and listen on:
* **HTTP**: `http://localhost:5000`

---

## API Endpoints

Once the application is running, you can access the following endpoints:

| Endpoint | Method | Description |
| :--- | :---: | :--- |
| `/` | `GET` | **Root URL**: Automatically redirects you to the Swagger UI page. |
| `/swagger` | `GET` | **Swagger UI**: Interactive page to view documentation and test endpoints. |
| `/swagger/v1/swagger.json` | `GET` | **OpenAPI Spec**: Returns the raw OpenAPI 3.0 specification in JSON format. |
| `/api/weather` | `GET` | **Weather Endpoint**: Returns a JSON array of days and temperatures. |

---

## Verification & Testing

### Using the Browser
1. Open your browser and navigate to `http://localhost:5000`.
2. You will be redirected to the Swagger UI playground (`http://localhost:5000/swagger`).
3. Click on the `GET /api/Weather` endpoint, click **"Try it out"**, and then **"Execute"** to see the response.

### Using PowerShell
You can also verify the endpoint responses from your command line:

```powershell
# Query weather data
Invoke-RestMethod -Uri "http://localhost:5000/api/weather"

# Query the Swagger OpenAPI Specification
Invoke-RestMethod -Uri "http://localhost:5000/swagger/v1/swagger.json"
```
