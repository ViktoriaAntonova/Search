using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 11);
            }
            Array.Sort(arr);
            int target = int.Parse(Console.ReadLine());
            var result = BinarySearch(arr, target);
            Console.WriteLine($"Намерени са {result.Count} елемента със стойност {target}.");
            Console.WriteLine("Позиции на тези елементи:");

            foreach (var position in result.Positions)
            {
                Console.WriteLine(position);
            }
        }
        static SearchRESULT BinarySearch(int[] arr, int target)
        {
            List<int> positions = new List<int>();
            int low = 0;
            int high = arr.Length - 1;
            int count = 0;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                {
                    positions.Add(mid);
                    count++;

                    int left = mid - 1;
                    while (left >= 0 && arr[left] == target)
                    {
                        positions.Add(left);
                        count++;
                        left--;
                    }

                    int right = mid + 1;
                    while (right < arr.Length && arr[right] == target)
                    {
                        positions.Add(right);
                        count++;
                        right++;
                    }

                    break;
                }
                else if (arr[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return new SearchRESULT(count, positions);
        }
    }
}
