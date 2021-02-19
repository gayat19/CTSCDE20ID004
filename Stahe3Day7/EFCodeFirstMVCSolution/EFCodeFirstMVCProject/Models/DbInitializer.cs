using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstMVCProject.Models
{
    public class DbInitializer
    {
        public static void Initialize(CompanyContext context)
        {
            context.Database.EnsureCreated();
            if (context.Employees.Any())
                return;
            var departments = new Department[]
            {
                new Department{Name="Admin"},
                 new Department{Name="IT"}
            };
            foreach (var dept in departments)
            {
                context.Departments.Add(dept);
            }
            context.SaveChanges();
            var employees = new Employee[]
            {
                new Employee{Name="Ramu",Age=21,DepartmentId=1},
                new Employee{Name="Somu",Age=21,DepartmentId=1}
            };
            foreach (var emp in employees)
            {
                context.Employees.Add(emp);
            }
            context.SaveChanges();
        }
    }
}
