using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(GetStandardEmployeeList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            return Ok(employee);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Employee employee)
        {
            return Ok("Employee Updated Successfully");
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Pramod",
                    Salary = 50000,
                    Permanent = true,
                    DateOfBirth = new DateTime(2003,5,16)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Rahul",
                    Salary = 45000,
                    Permanent = false,
                    DateOfBirth = new DateTime(2002,9,10)
                }
            };
        }
    }

    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }

        public bool Permanent { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}