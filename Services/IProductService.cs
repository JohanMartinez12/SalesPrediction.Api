using SalesPrediction.Api.Models;

namespace SalesPrediction.Api.Services
{
    public interface IProductService
    {
        Task<List<ProductDTO>> GetAllProductsAsync();
    }
}
