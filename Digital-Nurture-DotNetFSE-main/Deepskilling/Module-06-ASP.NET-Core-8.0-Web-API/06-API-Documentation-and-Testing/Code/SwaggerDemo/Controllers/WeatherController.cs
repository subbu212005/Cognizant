using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/[controller]")]
public class WeatherController:ControllerBase{
[HttpGet]
public IActionResult Get()=>Ok(new[]{new{Day="Monday",Temperature=30}});
}