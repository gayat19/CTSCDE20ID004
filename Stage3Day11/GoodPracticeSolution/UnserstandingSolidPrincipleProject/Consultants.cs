using System;
using System.Collections.Generic;
using System.Text;

namespace UnserstandingSolidPrincipleProject
{
    class Consultants : ICheckEmployee
    {
        public void CheckReports()
        {
            Console.WriteLine("Consultant checks reports");
        }
    }
}
