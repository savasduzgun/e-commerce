using System.Threading.Tasks;
using API.Data;
using API.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("/api/products")]
public class ProductsController : ControllerBase 
{
    private readonly DataContext _context;
    public ProductsController(DataContext context)
    {
        _context = context;
    }
    [HttpGet] //api/products
    public async Task<IActionResult> GetProducts()
    {
        var products = await _context.Products.ToListAsync();
        return Ok(products);
    }

    [HttpGet("{id}")] //api/products/1
    public async Task<IActionResult> GetProduct(int? id)
    {
        if(id==null)
        {
            return NotFound();
        }
        // var product = await _context.Products.FirstOrDefaultAsync(i => i.Id == id);
        var product = await _context.Products.FindAsync(id);

        if(product is null)
        {
            return NotFound();
        }
        return Ok(product);
    }
}