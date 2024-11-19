using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExampleDemo
{
    public struct CoordinatesDemo
    {
            private int x;
            private int y;

            public CoordinatesDemo(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void Print()
            {
                Console.WriteLine(x + "  " + y);
            }
        }

    }

