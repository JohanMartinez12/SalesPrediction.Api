using SalesPrediction.Api.Models;

namespace SalesPrediction.Api.Services
{
    public interface IShipperService
    {
        Task<IEnumerable<ShipperDTO>> GetAllShippersAsync();
        
    }
}
