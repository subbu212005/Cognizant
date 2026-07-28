# Hands-On 4 – JWT Expiry Validation

## Objective
Handle expired JWT tokens gracefully by capturing the authentication failure event and returning a custom response header `Token-Expired: true` alongside a `401 Unauthorized` status.

## Project Structure
- **JwtExpiryDemo**: The ASP.NET Core Web API project.
  - `Program.cs`: Sets up JWT Authentication with `ClockSkew = TimeSpan.Zero` and configures `JwtBearerEvents.OnAuthenticationFailed` to set the `Token-Expired: true` header when a token has expired.
  - `Controllers/AuthController.cs`: Generates valid and expired JWT tokens for testing.
  - `Controllers/ProtectedController.cs`: A secure API controller that requires authentication.

## Implementation Details

### Configuring `JwtBearerEvents` in `Program.cs`
The `AddJwtBearer` extension method is configured with events to check for `SecurityTokenExpiredException`:

```csharp
options.Events = new JwtBearerEvents
{
    OnAuthenticationFailed = context =>
    {
        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
        {
            context.Response.Headers.Append("Token-Expired", "true");
        }
        return Task.CompletedTask;
    }
};
```

To guarantee that expired tokens are caught immediately without the default 5-minute grace period, `ClockSkew` is set to zero in `TokenValidationParameters`:
```csharp
ClockSkew = TimeSpan.Zero
```

## How to Run & Verify

1. Build and run the project:
   ```bash
   dotnet run --project JwtExpiryDemo
   ```

2. Request a valid token:
   - **Endpoint**: `POST http://localhost:5035/api/auth/login`
   - **Body**: `{"Username": "JohnDoe"}`
   - **Response**: Returns a token valid for 1 hour.

3. Call the protected endpoint using the valid token:
   - **Endpoint**: `GET http://localhost:5035/api/protected/data`
   - **Headers**: `Authorization: Bearer <valid_token>`
   - **Expected Status**: `200 OK`

4. Request an expired token:
   - **Endpoint**: `POST http://localhost:5035/api/auth/login?expired=true`
   - **Body**: `{"Username": "JohnDoe"}`
   - **Response**: Returns a token that expired 5 minutes ago.

5. Call the protected endpoint using the expired token:
   - **Endpoint**: `GET http://localhost:5035/api/protected/data`
   - **Headers**: `Authorization: Bearer <expired_token>`
   - **Expected Status**: `401 Unauthorized`
   - **Expected Headers**: Includes `Token-Expired: true` response header.
