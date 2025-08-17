using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB : TypeA
    {
        public TypeB()
        {
            //TypeA typeA = new TypeA();

            //typeA.A = 1; // Not valid because it is private
            //typeA.B = 1; // valid because it is internal in the same name projected
            //typeA.C = 1; // public can be shown every where
            //typeA.X = 1; // private protected without inheritence means private
            //typeA.Y = 1; // protected without inheritance means private
            //typeA.Z = 1; // protected internal without inheritence means internal can be showsn in the same project

            //A = 1; // Not Inheritance because it is private
            B = 2; // vvalid and can be inheritened 
            C = 3; // public can be inheritened and showsn every where
            X = 4; // in inheritence it will be private but can be shown here
            Y = 5; // protected with inherietence will be as private
            Z = 6; // protected internal with inheritence become as internal 
        }
    }
}
