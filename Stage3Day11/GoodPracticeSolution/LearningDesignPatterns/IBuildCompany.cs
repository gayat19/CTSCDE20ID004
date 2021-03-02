using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    interface IBuildCompany
    {
        void BuildBuilding();
        void BuildCustomerBase();
        void BuildResource();
        MyCompany GetCompany();
    }
}
