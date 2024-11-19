using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExampleDemo
{
        public partial class Calc
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            // in one file we have declared a method, & in another file we have provided the implementation
            // if we have declared partial method & not provided the implementation
            // then compiler will ignore the method
            // it must be private & void return type for method
            partial void Divide(int a, int b);
        }

    }

