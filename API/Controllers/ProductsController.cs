using API.Entity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("/api/products")]
public class ProductsController : ControllerBase 
{
    [HttpGet] //api/products
    public IActionResult GetProducts()
    {
        return Ok(new List<Product>(){
            
        });
    }

    [HttpGet("{id}")] //api/products/1
    public IActionResult GetProduct(int id)
    {
        return Ok();
    }
}