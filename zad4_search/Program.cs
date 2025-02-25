using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            bool sorted = false;
            int[] array = ArrayCreator.CreateArray(size, sorted);
            Console.WriteLine("Array:");
            PrintArray(array);
            int target = int.Parse(Console.ReadLine());
            int foundIndex = SearchLinear.LinearSearch(array, target);
            if (foundIndex != -1)
            {
                Console.WriteLine($"Element {target} found at index {foundIndex}");
            }
            else
            {
                Console.WriteLine($"Element {target} not found in the array.");
            }
            PrintArray(array);
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
