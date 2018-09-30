namespace Employees.Repository.ResourceAccess
{
    using Employees.Repository.Interfaces;
    using Employees.Util.Dto;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Net.Http;

    using System.Threading.Tasks;

    public class EmployeesResource : IEmployeesRepository
    {
        private readonly string EmployeesApiUrl = ConfigurationManager.AppSettings.Get("employeesApiUrl");
        
        public async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
        {
            var client = HttpClientSingleton.Instance;
            HttpResponseMessage response = await client.GetAsync(EmployeesApiUrl);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<IEnumerable<EmployeeDto>>();
            }

            return null;
        }
    }
}
