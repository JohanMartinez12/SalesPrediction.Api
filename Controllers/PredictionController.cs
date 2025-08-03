using Microsoft.AspNetCore.Mvc;
using SalesPrediction.Api.Services;

namespace SalesPrediction.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PredictionController : ControllerBase
    {
        private readonly IPredictionService _service;

        public PredictionController(IPredictionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetPredictions()
        {
            try
            {
                var data = await _service.GetPredictionsAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }
    }

}
