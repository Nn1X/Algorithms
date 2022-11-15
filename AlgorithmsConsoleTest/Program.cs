
using Algorithms;


Console.Write("Введите элементы массива: ");
var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
var array = new int[parts.Length];
for (int i = 0; i < parts.Length; i++)
{
    array[i] = Convert.ToInt32(parts[i]);
}

Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", ShakerSort.Sort(array)));

Console.ReadLine();
