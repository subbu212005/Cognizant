using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/secure")]
public class SecureController:ControllerBase{
 [HttpGet]
 public IActionResult Get()=>Ok(new{message="Secure endpoint"});
}