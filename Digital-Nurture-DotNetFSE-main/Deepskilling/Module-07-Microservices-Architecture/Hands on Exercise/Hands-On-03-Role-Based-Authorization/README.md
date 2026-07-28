# Role-Based Authorization with JWT in ASP.NET Core

This repository demonstrates how to add Role-Based Authorization using JSON Web Tokens (JWT) in a C# Web API project.

Only users containing the `"Admin"` role in their JWT claims are permitted to access the protected admin dashboard endpoint.

---

## Project Structure

```text
Hands-On-03-Role-Based-Authorization
├── RoleBasedAuthAPI
│   ├── Controllers
│   │   ├── AdminController.cs      # Protected admin dashboard controller
│   │   └── AuthController.cs       # Token generation controller
│   ├── Program.cs                  # Services configuration and middleware pipeline
│   ├── appsettings.json            # JWT settings (key, issuer, audience)
│   └── RoleBasedAuthAPI.csproj
├── Output.txt                      # Detailed verification test logs
├── Output.png                      # API dashboard testing visualization mockup
└── README.md                       # Documentation
```

---

## Key Implementation Details

### 1. Token Generation with Roles
In `AuthController.cs`, we append the user's role to the JWT claims:

```csharp
var claims = new[]
{
    new Claim(ClaimTypes.Name, request.Username),
    new Claim(ClaimTypes.Role, role)
};
```

### 2. Protecting the Endpoint
In `AdminController.cs`, we restrict access using the `[Authorize]` attribute with a specific role check:

```csharp
[HttpGet("dashboard")]
[Authorize(Roles = "Admin")]
public IActionResult GetAdminDashboard()
{
    return Ok("Welcome to the admin dashboard.");
}
```

### 3. Middleware Configuration
In `Program.cs`, we register the JWT Bearer authentication scheme and ensure the authentication middleware runs before authorization:

```csharp
app.UseAuthentication(); // Run Authentication before Authorization
app.UseAuthorization();
```

---

## How to Run the Application

### 1. Run the API
Navigate to the API folder and run:
```powershell
cd RoleBasedAuthAPI
dotnet run --launch-profile http
```
By default, the application runs on `http://localhost:5256`.

### 2. Test Endpoints

#### Scenario A: Access without a JWT Token (Unauthenticated)
```powershell
curl.exe -i http://localhost:5256/api/admin/dashboard
```
**Expected Response:** `401 Unauthorized`

#### Scenario B: Access as a Normal User (role: "User")
1. **Login to obtain user token:**
```powershell
$body = @{ Username = 'Alice'; Role = 'User' } | ConvertTo-Json
$token = (Invoke-RestMethod -Uri 'http://localhost:5256/api/auth/login' -Method Post -Body $body -ContentType 'application/json').token
```
2. **Access the dashboard:**
```powershell
curl.exe -i -H "Authorization: Bearer $token" http://localhost:5256/api/admin/dashboard
```
**Expected Response:** `403 Forbidden`

#### Scenario C: Access as an Admin (role: "Admin")
1. **Login to obtain admin token:**
```powershell
$body = @{ Username = 'Bob'; Role = 'Admin' } | ConvertTo-Json
$token = (Invoke-RestMethod -Uri 'http://localhost:5256/api/auth/login' -Method Post -Body $body -ContentType 'application/json').token
```
2. **Access the dashboard:**
```powershell
curl.exe -i -H "Authorization: Bearer $token" http://localhost:5256/api/admin/dashboard
```
**Expected Response:** `200 OK` (Body: "Welcome to the admin dashboard.")
