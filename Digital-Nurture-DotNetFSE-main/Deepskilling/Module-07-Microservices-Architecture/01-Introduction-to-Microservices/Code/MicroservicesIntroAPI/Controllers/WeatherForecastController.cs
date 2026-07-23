using Microsoft.AspNetCore.Mvc;

namespace MicroservicesIntroAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new[] {
            new { Day="Monday", Temperature=30, Summary="Sunny" }
        });
    }
}
