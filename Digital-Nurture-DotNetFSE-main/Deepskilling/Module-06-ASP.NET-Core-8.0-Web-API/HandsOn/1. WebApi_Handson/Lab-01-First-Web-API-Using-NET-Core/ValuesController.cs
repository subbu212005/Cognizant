using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[]
            {
                "Value1",
                "Value2"
            });
        }

        [HttpPost]
        public IActionResult Post(string value)
        {
            return Ok($"Added : {value}");
        }

        [HttpPut]
        public IActionResult Put(int id, string value)
        {
            return Ok($"Updated {id} : {value}");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleted : {id}");
        }
    }
}