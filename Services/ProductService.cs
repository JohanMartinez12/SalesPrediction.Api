using SalesPrediction.Api.Data;
using Microsoft.EntityFrameworkCore;
using SalesPrediction.Api.Models;

namespace SalesPrediction.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProductDTO>> GetAllProductsAsync()
        {
            var sql = @"
                SELECT 
                    p.ProductID AS ProductId,
                    p.ProductName AS ProductName
                FROM Production.Products p";

            return await _context.ProductDtos.FromSqlRaw(sql).ToListAsync();
        }
    }
}
