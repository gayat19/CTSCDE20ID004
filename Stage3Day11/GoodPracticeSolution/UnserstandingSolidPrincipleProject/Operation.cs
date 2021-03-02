using System;
using System.Collections.Generic;
using System.Text;

namespace UnserstandingSolidPrincipleProject
{
    class Operation
    {
        ICheckEmployee _check;
        public Operation(ICheckEmployee check)
        {
            _check = check;
        }
        public void DoWork()
        {
            _check.CheckReports();
        }
    }
}
