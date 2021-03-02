using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstMVCProject.Models
{
    public class Example
    {
        Provider _provider;
        public Example(Provider provider)
        {
            _provider = provider;
        }
        public int Add(bool val)
        {
                return _provider.GetValue(val) + 500;
                
        }
    }
}
