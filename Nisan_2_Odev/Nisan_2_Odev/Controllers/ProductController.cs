using Microsoft.AspNetCore.Mvc;
using Nisan_2_Odev.Data;
using Nisan_2_Odev.Models;

namespace Nisan_2_Odev.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ProductRepository _repository;

    public ProductController(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        _repository = new ProductRepository(connectionString);
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var products = _repository.GetAllProducts();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult GetProductById(int id)
    {
        var product = _repository.GetProductById(id);
        if (product == null)
            return NotFound();
        return Ok(product);
    }

    [HttpPost]
    public IActionResult AddProduct([FromBody] Product product)
    {
        _repository.AddProduct(product);
        return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, [FromBody] Product product)
    {
        var existingProduct = _repository.GetProductById(id);
        if (existingProduct == null)
            return NotFound();

        _repository.UpdateProduct(id, product);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var existingProduct = _repository.GetProductById(id);
        if (existingProduct == null)
            return NotFound();

        _repository.DeleteProduct(id);
        return NoContent();
    }
}