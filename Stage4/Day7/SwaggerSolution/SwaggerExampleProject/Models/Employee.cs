using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerExampleProject.Models
{

    public class Employee
    {
        private IConfiguration _config;

        public Employee(IConfiguration configration)
        {
            _config = configration;
        }
    }
}
