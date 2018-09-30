namespace Employees.Repository.Interfaces
{
    using Employees.Util.Dto;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmployeesRepository
    {
        Task<IEnumerable<EmployeeDto>> GetEmployeesAsync();
    }
}
