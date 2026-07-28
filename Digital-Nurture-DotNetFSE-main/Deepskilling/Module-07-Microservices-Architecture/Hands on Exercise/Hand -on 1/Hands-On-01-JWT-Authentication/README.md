# Hands-On 1 – Implement JWT Authentication

## Objective
Implement JSON Web Token (JWT) based authentication in an ASP.NET Core Web API project to secure API endpoints.

## Project Structure
- **JwtAuthenticationAPI**: The ASP.NET Core 10.0 Web API project.
  - **Models/LoginModel.cs**: DTO containing user credentials payload.
  - **Controllers/AuthController.cs**: Handles login requests and issues JWT tokens.
  - **Controllers/SecureController.cs**: A sample controller protected using the `[Authorize]` attribute.
  - **Program.cs**: Configures dependency injection for JWT Authentication and inserts the required authentication middleware.
  - **appsettings.json**: Configures the key, issuer, audience, and expiration period of the JWT tokens.

## Steps Completed

1. **Created ASP.NET Core Web API project**:
   Initialized using `dotnet new webapi -n JwtAuthenticationAPI -o Hands-On-01-JWT-Authentication/JwtAuthenticationAPI --use-controllers`.
   
2. **Installed JWT Bearer package**:
   Added `Microsoft.AspNetCore.Authentication.JwtBearer` package to the project.

3. **Configured JWT settings in `appsettings.json`**:
   Configured keys, issuer, audience, and lifetime parameters under the `"Jwt"` config block.

4. **Configured Authentication in `Program.cs`**:
   Registered authentication services via `builder.Services.AddAuthentication(...)` and enabled authentication using `app.UseAuthentication()` before `app.UseAuthorization()`.

5. **Created Models and AuthController**:
   Defined `LoginModel` and structured `AuthController` with `Login` and `GenerateJwtToken` methods.

6. **Secured Endpoint**:
   Added `[Authorize]` attribute on `SecureController` to ensure authorization checks.

7. **Verified execution and functionality**:
   Built and ran the application, validating API routes via scripts.

## Expected Output
- **Valid Login**: Returning a `200 OK` along with a JWT token.
- **Invalid Login**: Returning `401 Unauthorized`.
- **Protected Endpoint (Without Token)**: Returning `401 Unauthorized`.
- **Protected Endpoint (With Valid Token)**: Returning `200 OK` with secure resource data.

## Verification Commands
Run the Web API:
```bash
dotnet run --project JwtAuthenticationAPI
```

Test endpoints using PowerShell:
```powershell
# Login (Valid)
Invoke-RestMethod -Uri "http://localhost:5272/api/auth/login" -Method Post -ContentType "application/json" -Body '{"username":"admin","password":"password123"}'

# Access Protected Endpoint with Token
$token = "<insert_token_here>"
Invoke-RestMethod -Uri "http://localhost:5272/api/secure" -Method Get -Headers @{ "Authorization" = "Bearer $token" }
```
