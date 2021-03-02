using System;
using System.Collections.Generic;
using System.Text;

namespace UnserstandingSolidPrincipleProject
{
    class FaceIdLogin :Login
    {
        public override  bool EmployeeLogin(Employee employee)
        {
            Console.WriteLine("Child wth face id");
            return false;
        }
    }
}
