using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/products")]
public class ProductsController:ControllerBase{
[HttpGet]
public IActionResult Get(int page=1,int pageSize=5)=>Ok(new{page,pageSize,data=new[]{"Item1","Item2"}});
}