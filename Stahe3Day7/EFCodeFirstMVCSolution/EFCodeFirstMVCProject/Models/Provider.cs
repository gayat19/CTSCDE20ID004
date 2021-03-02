using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstMVCProject.Models
{
    public class Provider
    {
        bool data;
        public Provider()
        {
            //data = _data;
        }
        public int GetValue(bool data)
        {
            if (data)
            {
                return 100;
            }
            else
                return 200;
        }
    }
}
