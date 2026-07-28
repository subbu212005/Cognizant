using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles="Admin,POC")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(new[]
            {
                new
                {
                    Id=1,
                    Name="Pramod",
                    Department="IT"
                },
                new
                {
                    Id=2,
                    Name="Rahul",
                    Department="HR"
                }
            });
        }
    }
}