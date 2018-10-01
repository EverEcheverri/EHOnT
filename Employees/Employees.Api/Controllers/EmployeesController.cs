namespace Employees.Api.Controllers
{
    using Employees.Business.Interfaces;
    using Employees.Util.Dto;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System.Web.Http.Cors;

    /// <summary>
    /// 
    /// </summary>
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
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
