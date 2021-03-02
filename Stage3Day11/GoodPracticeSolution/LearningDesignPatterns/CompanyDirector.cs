using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    class CompanyDirector
    {
        public void Construct(IBuildCompany build)
        {
            build.BuildBuilding();
            build.BuildCustomerBase();
            build.BuildResource();
            
        }
    }
}
