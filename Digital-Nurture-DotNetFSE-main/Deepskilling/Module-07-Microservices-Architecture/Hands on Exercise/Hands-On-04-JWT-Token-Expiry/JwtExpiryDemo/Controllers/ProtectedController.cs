using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtExpiryDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProtectedController : ControllerBase
{
    [HttpGet("data")]
    [Authorize]
    public IActionResult GetProtectedData()
    {
        return Ok(new { Message = "This is secure data. Access granted!" });
    }
}
