using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    class MyCompany
    {
        public string Building { get; set; }
        public string Resource { get; set; }
        public string Clients { get; set; }
        public override string ToString()
        {
            return Building+" "+Resource+" "+Clients;
        }
    }
}
