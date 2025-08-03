using Microsoft.AspNetCore.Mvc;
using SalesPrediction.Api.Services;

namespace SalesPrediction.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _service;
        public OrdersController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet("client/{clientId}")]
        public async Task<IActionResult> GetOrdersByClient(int clientId)
        {
            try
            {
                var result = await _service.GetOrdersByClientIdAsync(clientId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }
    }
}
