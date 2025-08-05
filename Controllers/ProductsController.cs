using Microsoft.AspNetCore.Mvc;
using SalesPrediction.Api.Services;

namespace SalesPrediction.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductsController(IProductService productService)
        {
            _service = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var products = await _service.GetAllProductsAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");

            }
        }
    }
        
}
