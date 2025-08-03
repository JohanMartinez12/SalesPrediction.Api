using SalesPrediction.Api.Models;

namespace SalesPrediction.Api.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDTO>> GetAllEmployeesAsync();
    }
}
