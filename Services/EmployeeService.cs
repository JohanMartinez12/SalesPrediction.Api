using Microsoft.EntityFrameworkCore;
using SalesPrediction.Api.Data;
using SalesPrediction.Api.Models;

namespace SalesPrediction.Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;
        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<EmployeeDTO>> GetAllEmployeesAsync()
        {
            var sql = @"
                        SELECT
                            e.empid,
                            CONCAT(e.firstname, ' ', e.lastname) AS FullName
                        FROM
                            HR.Employees AS e;
                        ";
            return await _context.EmployeeDtos.FromSqlRaw<EmployeeDTO>(sql).ToListAsync();

        }
    }
}
