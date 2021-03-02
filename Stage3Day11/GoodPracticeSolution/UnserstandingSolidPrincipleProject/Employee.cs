using System;
using System.Collections.Generic;
using System.Text;

namespace UnserstandingSolidPrincipleProject
{
    class Employee : ICheckEmployee
    {
        private int id, age;
        private string name;
        private string username, password;
        private string faceId;
        public Employee()
        {

        }
        public void TakeEmployeeDetails()
        {

        }

        public void CheckReports()
        {
            Console.WriteLine("Employee will check his daily reports");
        }

        

        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FaceId { get => faceId; set => faceId = value; }
    }
}
