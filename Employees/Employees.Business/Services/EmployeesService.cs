namespace Employees.Business.Services
{
    using Employees.Business.Interfaces;
    using Employees.Repository.Interfaces;
    using Employees.Util.Dto;
    using Employees.Util.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class EmployeesService : IEmployeesService
    {
        private readonly IEmployeesRepository _employeesRepository;

        public EmployeesService(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository ?? throw new ArgumentNullException(nameof(employeesRepository));
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
        {
            var result = await _employeesRepository.GetEmployeesAsync();
            return CalculateSalary(result);
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployeeByIdAsync(int id)
        {
            var result = await _employeesRepository.GetEmployeesAsync();
            var employee = result.ToList().Where(x => x.Id == id);
            return CalculateSalary(employee);
        }

        private IEnumerable<EmployeeDto> CalculateSalary(IEnumerable<EmployeeDto> objEmployeeDto)
        {
            var employees = objEmployeeDto.ToList();
            employees.ForEach(x =>
            {
                if (x.ContractTypeName.ToString().Equals(ContractTypeName.HourlySalaryEmployee.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    x.MonthlySalary = 0;
                    x.Salary = 120 * x.HourlySalary * 12;
                }
                else
                {
                    x.HourlySalary = 0;
                    x.Salary = x.MonthlySalary * 12;
                }
                x.ContractTypeDescription = x.ContractTypeName.GetDescription();
            });

            return employees;
        }
    }
}
