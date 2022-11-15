using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class FastExponentiation
    {
        public static long PowerRecursion(long x, uint n)
        {
            if (n == 0)
            {
                return 1;
            }

            if ((n & 1) == 0)
            {
                var p = Power(x, n >> 1);
                return p * p;
            }
            else
            {
                return x * Power(x, n - 1);
            }
        }

        public static long Power(long x, uint n)
        {
            var result = 1L;
            while(n > 0)
            {
                if( (n & 1) == 0)
                {
                    x *= x;
                    n >>= 1;
                }
                else
                {
                    result *= x;
                    n--;
                }
            }
            return result;
        }
    }
}
