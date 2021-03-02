using EFCodeFirstMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstMVCProject.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyContext _context;
        ILogger _logger;

        public EmployeeController(CompanyContext context,ILogger<Startup> logger)
        {
            _context = context;
           // _logger = logger;
        }
        public async Task<IActionResult> IndexAsync()
        {
           // throw new Exception("Check this exception");
           // _logger.LogInformation("In the Employee Index action and the number of employees are "+ await _context.Employees.CountAsync());
            int count = await _context.Employees.CountAsync();
            if(count >0)
            {
                //_logger.LogInformation(MyCustomLogData.AllGood, "The code is working well");
                return View(await _context.Employees.ToListAsync());
            }
            else
            {
               // _logger.LogError(MyCustomLogData.ItemCountZero, "NO records found");
                return View(await _context.Employees.ToListAsync());
            }
        }
       public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
        public bool CheckTheCheck()
        {
            if (_context.Check == "Hello")
                return true;
            else
                return false;
        }
    }
}
