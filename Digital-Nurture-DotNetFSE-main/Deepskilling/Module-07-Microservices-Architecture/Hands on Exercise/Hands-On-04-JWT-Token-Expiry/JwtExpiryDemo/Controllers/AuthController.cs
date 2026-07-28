using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JwtExpiryDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public AuthController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request, [FromQuery] bool expired = false)
    {
        if (string.IsNullOrEmpty(request.Username))
        {
            return BadRequest("Username is required.");
        }

        var claims = new[]
        {
            new Claim(ClaimTypes.Name, request.Username)
        };

        var jwtSettings = _configuration.GetSection("JwtSettings");
        var secretKey = jwtSettings["SecretKey"] ?? "SuperSecretKeyThatIsAtLeast32CharactersLong!!!";
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        // Set token expiration based on the 'expired' query parameter
        var expiration = expired ? DateTime.UtcNow.AddMinutes(-5) : DateTime.UtcNow.AddHours(1);

        var token = new JwtSecurityToken(
            issuer: jwtSettings["Issuer"] ?? "JwtExpiryDemo",
            audience: jwtSettings["Audience"] ?? "JwtExpiryDemo",
            claims: claims,
            expires: expiration,
            signingCredentials: creds
        );

        var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

        return Ok(new { Token = tokenString });
    }
}

public class LoginRequest
{
    public string Username { get; set; } = string.Empty;
}
