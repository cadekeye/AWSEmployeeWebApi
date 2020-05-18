using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeWebApi.Models;
using EmployeeWebApi.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApi.Controllers
{
    [Route("Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController(IEmployeeService employeeService,
            IEmployeeListService employeeList)
        {
            _employeeService = employeeService;
            _employeeList = employeeList;
        }

        public IEmployeeService _employeeService { get; }
        public IEmployeeListService _employeeList { get; }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var results = await _employeeService.GetEmployees();
            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmployeeModel employee)
        {
            await _employeeService.InsertEmployee(employee);
            return Ok();
        }

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var results = _employeeList.GetEmployees();
        //    return Ok(results);
        //}

        //[HttpPost]
        //public IActionResult Post([FromBody] EmployeeModel employee)
        //{
        //    _employeeList.InsertEmployee(employee);
        //    return Ok();
        //}
    }
}