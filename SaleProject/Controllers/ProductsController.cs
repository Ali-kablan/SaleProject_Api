using Microsoft.AspNetCore.Mvc;
using SaleProject.DTOs.ProductDtos;
using SaleProject.Services.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaleProject.Controllers
{
    [Route("Products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        // Inject the service
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProductById(string id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound(); // Returns a 404 Not Found
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto>> CreateProduct(CreateProductDto createProductDto)
        {
            var newProduct = await _productService.CreateProductAsync(createProductDto);
            // Returns a 201 Created status with a link to the new resource
            return CreatedAtAction(nameof(GetProductById), new { id = newProduct.Id }, newProduct);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(string id, CreateProductDto createProductDto)
        {
            var result = await _productService.UpdateProductAsync(id, createProductDto);
            if (!result)
            {
                return NotFound();
            }
            return NoContent(); // Returns a 204 No Content
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            var result = await _productService.DeleteProductAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent(); // Returns a 204 No Content
        }
    }
}
