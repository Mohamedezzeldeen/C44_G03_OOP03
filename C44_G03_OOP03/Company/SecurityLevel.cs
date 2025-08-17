using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP03.Company
{
    [Flags]
    public enum SecurityLevel:Byte
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8
    }
}
