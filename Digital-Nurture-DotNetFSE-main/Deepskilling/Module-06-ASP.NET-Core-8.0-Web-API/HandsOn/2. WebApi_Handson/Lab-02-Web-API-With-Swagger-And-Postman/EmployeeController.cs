using Microsoft.AspNetCore.Mvc;

namespace SwaggerDemo.Controllers
{
    [ApiController]
    [Route("api/Emp")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [ActionName("GetEmployees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var employees = new[]
            {
                new
                {
                    Id = 1,
                    Name = "Pramod",
                    Department = "IT"
                },
                new
                {
                    Id = 2,
                    Name = "Rahul",
                    Department = "HR"
                }
            };

            return Ok(employees);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Post()
        {
            return Created("", "Employee Added Successfully");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok($"Employee {id} Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Employee {id} Deleted Successfully");
        }
    }
}