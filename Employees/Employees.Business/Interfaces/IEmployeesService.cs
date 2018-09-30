namespace Employees.Business.Interfaces
{
    using Employees.Util.Dto;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmployeesService
    {
        Task<IEnumerable<EmployeeDto>> GetEmployeesAsync();
        Task<IEnumerable<EmployeeDto>> GetEmployeeByIdAsync(int id);
    }
}
