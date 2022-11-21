using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class QuickSort
    {
        public static List<int> Sort(List<int> array)
        {
            if (array.Count == 1 || array == null || array.Count == 0)
                return array;
            else
            {
                var strongholdElem = array[0];

                List<int> first, second;
                first = array.Where(x => x < strongholdElem).ToList();
                second = array.Where(x => x > strongholdElem).ToList();

                first = Sort(first);
                second = Sort(second);

                first.Add(strongholdElem);

                List<int> result = first.Concat(second).ToList();

                return result;
            }
        }


        //метод для обмена элементов массива
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //метод возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        static int[] QuickSort1(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort1(array, minIndex, pivotIndex - 1);
            QuickSort1(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public static int[] QuickSort1(int[] array)
        {
            return QuickSort1(array, 0, array.Length - 1);
        }
    }
}
