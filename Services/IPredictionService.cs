using SalesPrediction.Api.Models;

namespace SalesPrediction.Api.Services
{
    public interface IPredictionService
    {
        Task<List<PredictionDTO>> GetPredictionsAsync();
    }
}
