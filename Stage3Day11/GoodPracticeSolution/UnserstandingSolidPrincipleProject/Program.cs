using System;

namespace UnserstandingSolidPrincipleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Company cts = new Company();
            cts.EmployeeLogin();
            cts.StartDailyWork(new Consultants());
            Console.ReadKey();
        }
    }
}
