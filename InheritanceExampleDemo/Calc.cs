using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExampleDemo
{
    public static class Calcc
    {
        // extension method syntax
        // first parameter should be the name of class, for which we want to add method
        public static int Muliply(this Calculation c1, int a, int b)
        {
            return a * b;
        }

    }

}
