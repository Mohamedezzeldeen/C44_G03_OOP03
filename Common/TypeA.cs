using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeA
    {
        private int A;
        internal int B;
        public int C;

        private protected int X;
        protected int Y;
        protected internal int Z;

        public TypeA()
        {
            A = 1;
            B = 2;
            C = 3;
            X = 4;
            Y = 5;
            Z = 6;
        }
    }
}
