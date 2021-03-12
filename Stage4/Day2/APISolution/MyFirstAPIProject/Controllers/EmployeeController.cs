using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstAPIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAPIProject.Controllers
{
   [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>() { 
            new Employee(){Id=101,Name="Ramu",Age=21},
            new Employee(){Id=102,Name="Somu",Age=31},
            new Employee(){Id=103,Name="Bimu",Age=29}
        };
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<Employee> ABC()
        {
            return employees;
        }
        //very bad practice
        //[HttpGet]
        //[Route("GetAnother")]
        //public IEnumerable<string> Check()
        //{
        //    return new List<string>() { "Abc","Xyz"};
        //}
        [HttpGet]
        [Route("GetEmployee/{id}")]
        public Employee XYZ( int id)
        {
            var emp = employees.Find(e => e.Id == id);
            return emp;
            //return new Employee() { Id = 101, Name = "Ramu", Age = 21 };
        }
        [HttpPut]
        [Route("{id}")]
        public Employee Put(int id,Employee employee)
        {
            var emp = employees.FindIndex(e => e.Id == id);
            employees[emp] = employee;
            return employees[emp];
            //return new Employee() { Id = 101, Name = "Ramu", Age = 21 };
        }
        [HttpPost]
        public void  Post(Employee employee)
        {
            employees.Add(employee);
        }
    }
}
