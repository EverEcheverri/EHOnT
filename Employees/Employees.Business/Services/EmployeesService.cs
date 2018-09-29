using Employees.Business.Interfaces;
using Employees.Repository.Interfaces;
using Employees.Repository.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Business.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IEmployeesRepository _employeesRepository;

        public EmployeesService(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository ?? throw new ArgumentNullException(nameof(employeesRepository));
        }

        public async Task<object> GetEmployeesAsync()
        {
            return await _employeesRepository.GetEmployeesAsync();
        }
    }
}
