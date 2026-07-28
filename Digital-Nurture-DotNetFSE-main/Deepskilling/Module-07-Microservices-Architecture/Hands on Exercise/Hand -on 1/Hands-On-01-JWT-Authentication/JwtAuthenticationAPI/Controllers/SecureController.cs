using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthenticationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class SecureController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSecureData()
        {
            var username = User.Identity?.Name ?? "Unknown User";
            return Ok(new
            {
                Message = "This is a secure endpoint. Access granted!",
                AuthorizedUser = username,
                Timestamp = DateTime.UtcNow
            });
        }
    }
}
