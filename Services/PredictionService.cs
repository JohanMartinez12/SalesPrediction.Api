using Microsoft.EntityFrameworkCore;
using SalesPrediction.Api.Data;
using SalesPrediction.Api.Models;

namespace SalesPrediction.Api.Services
{
    public class PredictionService : IPredictionService
    {
        private readonly AppDbContext _context;
        public PredictionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<PredictionDTO>> GetPredictionsAsync()
        {
            var sql = @"
            SELECT 
                c.CompanyName AS CustomerName,
                MAX(o.OrderDate) AS LastOrderDate,
                DATEADD(DAY, AVG(DATEDIFF(DAY, o2.OrderDate, o.OrderDate)), MAX(o.OrderDate)) AS NextPredictedOrder
            FROM Sales.Orders o
            INNER JOIN Sales.Customers c ON o.custid = c.custid
            INNER JOIN Sales.Orders o2 ON o2.custid = o.custid AND o2.OrderDate < o.OrderDate
            GROUP BY c.CompanyName
        ";

            return await _context.PredictionDtos.FromSqlRaw(sql).ToListAsync();
        }
    }
}
