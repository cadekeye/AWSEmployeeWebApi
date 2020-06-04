using Amazon.Runtime;
using DataAccessLayer;
using EmployeeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ISqlDataAccess _sqlDataAccess;

        public EmployeeService(ISqlDataAccess sqlDataAccess)
        {
            _sqlDataAccess = sqlDataAccess;
        }

        public Task<List<EmployeeModel>> GetEmployees()
        {
            string sql = $"select * from dbo.Employee";

            return _sqlDataAccess.LoadData<EmployeeModel, dynamic>(sql, new { });
        }

        public Task InsertEmployee(EmployeeModel employee)
        {
            string sql = $"insert into dbo.Employee (EmployeeId,FirstName,LastName,Address1,Address2,Town,PostCode,DepartmentId,EmailAddress)" +
                "values(@EmployeeId,@FirstName,@LastName,@Address1,@Address2,@Town,@PostCode,@DepartmentId,@EmailAddress)";

            return _sqlDataAccess.ProcessData(sql, employee);
        }

        public Task DeleteEmployee(EmployeeModel employee)
        {
            string sql = $"delete from dbo.Employee where Id = @Id";

            return _sqlDataAccess.ProcessData(sql, employee.Id);
        }
    }
}