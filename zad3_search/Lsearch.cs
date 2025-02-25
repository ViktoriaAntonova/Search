using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_search
{
    internal class Lsearch
    {
        public static int LinearSearch(ref int[] arr, int key)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == key)
                {
                    if (i > 0)
                    {
                        int temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                    }
                    return i;
                }
            }
            return -1;
        }
    }
}
