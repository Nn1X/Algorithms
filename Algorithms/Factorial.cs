using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Factorial
    {
        public static ulong Calculate(ulong x)
        {
            if (x == 1uL)
                return 1uL;
            else
                return Calculate(x - 1uL) * x;
        }
    }
}
