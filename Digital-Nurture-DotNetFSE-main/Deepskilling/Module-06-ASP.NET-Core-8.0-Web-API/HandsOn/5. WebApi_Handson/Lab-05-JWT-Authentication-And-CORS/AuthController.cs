using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Login()
        {
            return Ok(GenerateJSONWebToken(1, "Admin"));
        }

        private string GenerateJSONWebToken(int userId, string role)
        {
            var securityKey =
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes("mysuperdupersecret"));

            var credentials =
                new SigningCredentials(
                    securityKey,
                    SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>()
            {
                new Claim("UserId",userId.ToString()),
                new Claim(ClaimTypes.Role,role)
            };

            var token =
                new JwtSecurityToken(
                    issuer:"mySystem",
                    audience:"myUsers",
                    claims:claims,
                    expires:DateTime.Now.AddMinutes(2),
                    signingCredentials:credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }