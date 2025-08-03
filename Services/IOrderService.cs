using SalesPrediction.Api.Models;

namespace SalesPrediction.Api.Services
{
    public interface IOrderService
    {
        Task<List<ClientOrderDTO>> GetOrdersByClientIdAsync(int clientId);
    }
}
