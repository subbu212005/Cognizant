using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
namespace OrderService.Controllers;
[ApiController]
[Route("[controller]")]
public class OrdersController:ControllerBase
{
 [HttpGet]
 public IActionResult Get()=>Ok(new[]{new Order{Id=1,Name="Sample Order"}});
}
