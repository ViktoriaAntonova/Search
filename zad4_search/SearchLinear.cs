using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4_search
{
    internal class SearchLinear
    {
        public static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                { 
                    if (i != 0)
                    {
                        int temp = array[i];
                        array[i] = array[0];
                        array[0] = temp;
                    }
                    return i; 
                }
            }
            return -1;
        }
    }
}
