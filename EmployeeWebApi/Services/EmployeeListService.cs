using EmployeeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Services
{
    public class EmployeeListService : IEmployeeListService
    {
        private readonly List<EmployeeModel> _employeeLists = new List<EmployeeModel>();

        public EmployeeListService()
        {
            _employeeLists.Add(new EmployeeModel
            {
                Id = 1,
                FirstName = "Caleb",
                LastName = "Adekeye",
                Address1 = "123 God's Lane",
                Address2 = "Greenwich",
                Town = "London",
                PostCode = "E1 5RT",
                DepartmentId = 2
            });

            _employeeLists.Add(new EmployeeModel
            {
                Id = 2,
                FirstName = "Folasade",
                LastName = "Adekeye",
                Address1 = "123 God's Lane",
                Address2 = "Greenwich",
                Town = "London",
                PostCode = "E1 5RT",
                DepartmentId = 1
            });
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _employeeLists;
        }

        public EmployeeModel InsertEmployee(EmployeeModel employee)
        {
            _employeeLists.Add(employee);
            return employee;
        }

        public EmployeeModel DeleteEmployee(EmployeeModel employee)
        {
            _employeeLists.Remove(employee);
            return employee;
        }
    }
}