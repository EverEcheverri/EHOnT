namespace Employees.Api.Controllers
{
    using Employees.Business.Interfaces;
    using System.Threading.Tasks;
    using System.Web.Http;

    public class EmployeesController : ApiController
    {
        private readonly IEmployeesService _employeesService;
        
        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        // GET api/values
        public async Task<object> GetAsync()
        {
            return await _employeesService.GetEmployeesAsync();
        }
    }
}
