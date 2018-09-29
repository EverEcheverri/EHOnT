using Employees.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Repository.ResourceAccess
{
    public class EmployeesResource : IEmployeesRepository
    {
        private readonly string EmployeesApiUrl = ConfigurationManager.AppSettings.Get("employeesApiUrl");
        
        public async Task<object> GetEmployeesAsync()
        {
            var client = HttpClientSingleton.Instance;
            HttpResponseMessage response = await client.GetAsync(EmployeesApiUrl);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<object>();
            }

            return null;
        }
    }
}
