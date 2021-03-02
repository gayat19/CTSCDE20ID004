using System;
using System.Collections.Generic;
using System.Text;

namespace UnserstandingSolidPrincipleProject
{
    class Company
    {
        List<Employee> employees = new List<Employee>();
        public Company()
        {
            employees.Add(new Employee());
           
        }
        public void StartDailyWork(ICheckEmployee emp)
        {
            Operation operation = new Operation(emp);
            operation.DoWork();

        }
        public void EmployeeLogin()
        {
           Login login = new FaceIdLogin();
            login.EmployeeLogin(employees[0]);
        }
    }
}
