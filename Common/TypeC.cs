using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeC : TypeB
    {
        public TypeC()
        {
            B = 1; // Internal
            C = 2; // Public
            X = 3; // private protected
            Y = 4; // protected
            Z = 5; // protected internal
        }
    }
}
