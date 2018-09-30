namespace Employees.Test
{
    using Employees.Business.Interfaces;
    using Employees.Business.Services;
    using Employees.Repository.Interfaces;
    using Employees.Util.Dto;
    using Employees.Util.Enums;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    [TestClass]
    public class UnitTestEmployees
    {
        private readonly Mock<IEmployeesRepository> _mockEmployeesRepository = new Mock<IEmployeesRepository>();
        private readonly IEmployeesService _employeesService;

        public UnitTestEmployees()
        {
            _mockEmployeesRepository
            .Setup(repo => repo.GetEmployeesAsync())
            .ReturnsAsync((new List<EmployeeDto>() {
                new EmployeeDto
                {
                    Id = 1,
                    Name = "Mary",
                    ContractTypeName = ContractTypeName.HourlySalaryEmployee,
                    RoleId = 1,
                    RoleName = "Administrator",
                    RoleDescription = null,
                    HourlySalary = 60000,
                    MonthlySalary = 80000
                },
                new EmployeeDto
                {
                    Id = 2,
                    Name = "Sam",
                    ContractTypeName = ContractTypeName.HourlySalaryEmployee,
                    RoleId = 1,
                    RoleName = "Administrator",
                    RoleDescription = null,
                    HourlySalary = 60000,
                    MonthlySalary = 80000
                },
                new EmployeeDto
                {
                    Id = 3,
                    Name = "Erik",
                    ContractTypeName = ContractTypeName.MonthlySalaryEmployee,
                    RoleId = 2,
                    RoleName = "Contractor",
                    RoleDescription = null,
                    HourlySalary = 60000,
                    MonthlySalary = 80000
                },
                new EmployeeDto
                {
                    Id = 4,
                    Name = "Jessica",
                    ContractTypeName = ContractTypeName.MonthlySalaryEmployee,
                    RoleId = 2,
                    RoleName = "Contractor",
                    RoleDescription = null,
                    HourlySalary = 60000,
                    MonthlySalary = 80000
                },
            }));

            _employeesService = new EmployeesService(_mockEmployeesRepository.Object);
        }

        [TestMethod]
        public async Task GetAllAsync()
        {
            var result = await _employeesService.GetEmployeesAsync();
            Assert.IsTrue(result != null && result.Any());
        }

        [TestMethod]
        public async Task GetByIdAsync()
        {
            var result = await _employeesService.GetEmployeeByIdAsync(1);
            Assert.IsTrue(result != null && result.Any() && result.FirstOrDefault().Id == 1);
        }
    }
}
