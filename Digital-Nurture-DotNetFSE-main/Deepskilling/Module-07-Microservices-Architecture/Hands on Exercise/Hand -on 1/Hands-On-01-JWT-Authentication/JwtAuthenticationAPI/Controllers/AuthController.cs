using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtAuthenticationAPI.Models;

namespace JwtAuthenticationAPI.Controllers
{
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
        public IActionResult Login([FromBody] LoginModel model)
        {
            if (IsValidUser(model))
            {
                var token = GenerateJwtToken(model.Username);
                return Ok(new { Token = token });
            }
            return Unauthorized();
        }

        private bool IsValidUser(LoginModel model)
        {
            // Simple validation for demonstration purposes
            return model.Username == "admin" && model.Password == "password123";
        }

        private string GenerateJwtToken(string username)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username)
            };

            var jwtKey = _configuration["Jwt:Key"] ?? "ThisIsASecretKeyForJwtTokenSuperSecret";
            
            // Ensure the key is at least 32 bytes (256 bits) for HMAC-SHA256
            if (Encoding.UTF8.GetByteCount(jwtKey) < 32)
            {
                jwtKey = jwtKey.PadRight(32, '0');
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var issuer = _configuration["Jwt:Issuer"] ?? "MyAuthServer";
            var audience = _configuration["Jwt:Audience"] ?? "MyApiUsers";
            var durationMinutes = double.TryParse(_configuration["Jwt:DurationInMinutes"], out var minutes) ? minutes : 60;

            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(durationMinutes),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
