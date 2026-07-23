using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
namespace ProductService.Controllers;
[ApiController]
[Route("[controller]")]
public class ProductsController:ControllerBase
{
 [HttpGet]
 public IActionResult Get()=>Ok(new[]{new Product{Id=1,Name="Sample Product"}});
}
