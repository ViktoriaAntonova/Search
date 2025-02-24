using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    internal class Program
    {
        public static (int count, List<int> positions) LinearSearch(int[] arr, int target)
        {
            int count = 0;
            List<int> positions = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    count++;
                    positions.Add(i);
                }
            }

            return (count, positions);
        }
        static void Main()
        {
            Random rand = new Random();
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, arr.Length * 2);
            }

            Console.WriteLine("Генерирани числа:");
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            int target = int.Parse(Console.ReadLine());
            var result = LinearSearch(arr, target);

            Console.WriteLine($"Намерени са {result.Item1} елемента със стойност {target}.");
            Console.WriteLine("Позиции на тези елементи:");

            foreach (var position in result.Item2)
            {
                Console.WriteLine(position);
            }
        }

    }
}
