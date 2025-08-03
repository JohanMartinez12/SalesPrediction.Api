using Microsoft.EntityFrameworkCore;
using SalesPrediction.Api.Data;
using SalesPrediction.Api.Models;

namespace SalesPrediction.Api.Services
{
    public class ShipperService : IShipperService
    {
        private readonly AppDbContext _context;
        public ShipperService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ShipperDTO>> GetAllShippersAsync()
        {
            var sql = @"
                        SELECT
                            s.shipperid,
                            s.companyname
                        FROM
                            Sales.Shippers AS s;
                        ";
            return await _context.ShipperDtos
                .FromSqlRaw(sql)
                .ToListAsync();
        }
    }
}
