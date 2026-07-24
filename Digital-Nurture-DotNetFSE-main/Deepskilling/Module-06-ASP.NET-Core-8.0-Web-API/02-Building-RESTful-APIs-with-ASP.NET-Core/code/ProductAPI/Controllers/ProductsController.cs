using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/[controller]")]
public class ProductsController:ControllerBase{
private readonly ProductService service;
public ProductsController(ProductService s){service=s;}
[HttpGet]
public IActionResult Get()=>Ok(service.GetAll());
}