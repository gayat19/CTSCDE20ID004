using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    class CompanyBuilder : IBuildCompany
    {
        private MyCompany company = new MyCompany();
        public void BuildBuilding()
        {
            company.Building = "Building done";
        }

        public void BuildCustomerBase()
        {
            company.Clients = "Many clients";
        }

        public void BuildResource()
        {
            company.Resource = "Limited skilled resource";
        }
        public MyCompany GetCompany()
        {
            return company;
        }
    }
}
