namespace Employees.Api.Controllers
{
    using Employees.Business.Interfaces;
    using Employees.Util.Dto;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;

    /// <summary>
    /// 
    /// </summary>
    public class EmployeesController : ApiController
    {
        private readonly IEmployeesService _employeesService;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeesService"></param>
        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EmployeeDto>> GetAsync()
        {
            return await _employeesService.GetEmployeesAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<EmployeeDto>> GetAsync(int id)
        {
            return await _employeesService.GetEmployeeByIdAsync(id);
        }
    }
}
