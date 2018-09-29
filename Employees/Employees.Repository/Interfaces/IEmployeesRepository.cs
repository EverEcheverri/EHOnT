using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Repository.Interfaces
{
    public interface IEmployeesRepository
    {
        Task<object> GetEmployeesAsync();
    }
}
