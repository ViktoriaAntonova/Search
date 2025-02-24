using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class SearchRESULT
    {
        public int Count { get; set; }
        public List<int> Positions { get; set; }

        public SearchRESULT(int count, List<int> positions)
        {
            Count = count;
            Positions = positions;
        }
    }
}
