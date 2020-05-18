using EmployeeWebApi.Models;
using System.Collections.Generic;

namespace EmployeeWebApi.Services
{
    public interface IEmployeeListService
    {
        EmployeeModel DeleteEmployee(EmployeeModel employee);
        List<EmployeeModel> GetEmployees();
        EmployeeModel InsertEmployee(EmployeeModel employee);
    }
}