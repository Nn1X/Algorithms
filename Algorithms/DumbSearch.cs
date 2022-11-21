using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class DumbSearch
    {
        public static int? Search(int[] array, int value)
        {
            foreach (var item in array)
            {
                if(item == value)
                    return item;
            }
            return null;
        }
    }
}
