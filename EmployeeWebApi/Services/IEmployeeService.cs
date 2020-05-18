using EmployeeWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeWebApi.Services
{
    public interface IEmployeeService
    {
        Task DeleteEmployee(EmployeeModel employee);
        Task<List<EmployeeModel>> GetEmployees();
        Task InsertEmployee(EmployeeModel employee);
    }
}