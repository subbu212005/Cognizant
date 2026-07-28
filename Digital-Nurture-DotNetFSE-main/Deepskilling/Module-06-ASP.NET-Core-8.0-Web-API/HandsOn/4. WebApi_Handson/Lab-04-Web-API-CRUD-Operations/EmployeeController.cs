using Microsoft.AspNetCore.Mvc;

namespace CrudApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee{Id=1,Name="Pramod",Salary=50000},
            new Employee{Id=2,Name="Rahul",Salary=45000},
            new Employee{Id=3,Name="Kiran",Salary=40000}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok(employees);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var existing = employees.FirstOrDefault(e => e.Id == id);

            if (existing == null)
                return BadRequest("Invalid employee id");

            existing.Name = employee.Name;
            existing.Salary = employee.Salary;

            return Ok(existing);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);

            return Created("", employee);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return BadRequest("Invalid employee id");

            employees.Remove(employee);

            return Ok("Employee Deleted Successfully");
        }
    }

    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }
    }
}