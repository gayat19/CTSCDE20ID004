using EFCodeFirstMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstMVCProject.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyContext _context;
        public EmployeeController(CompanyContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {

            return View(await _context.Employees.ToListAsync());
        }
    }
}
