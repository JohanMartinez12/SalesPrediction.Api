using Microsoft.AspNetCore.Mvc;
using SalesPrediction.Api.Services;

namespace SalesPrediction.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippersController : ControllerBase
    {
        private readonly IShipperService _service;
        public ShippersController(IShipperService shipperService)
        {
            _service = shipperService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllShippers()
        {
            try
            {
                var result = await _service.GetAllShippersAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }
    }
    
}
