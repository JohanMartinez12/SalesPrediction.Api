using Microsoft.EntityFrameworkCore;
using SalesPrediction.Api.Data;
using SalesPrediction.Api.Models;

namespace SalesPrediction.Api.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _context;

        public OrderService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ClientOrderDTO>> GetOrdersByClientIdAsync(int clientId)
        {
            var sql = @"
                        SELECT
                            o.orderid,
                            o.requireddate,
                            o.shippeddate,
                            o.shipname,
                            o.shipaddress,
                            o.shipcity
                        FROM
                            Sales.Orders AS o
                        WHERE
                            o.custid = {0}
                        ";

            return await _context.ClientOrderDtos.FromSqlRaw(sql, clientId).ToListAsync();
        }

    }
            
}
