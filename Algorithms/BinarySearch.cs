using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class BinarySearch
    {
        public static int? Search(int[] array, int value)
        {
            var min = 0;
            var max = array.Length-1;

            

            while(min<=max)
            {
                var mid = (min + max) / 2;

                if (mid == value)
                    return mid;
                else if(mid > value)
                    max = mid-1;
                else if(mid < value)
                    min = mid+1;
            }

            return null;
        }
    }
}
