using System;
using System.Collections.Generic;

namespace SortingAlgorithms.Tests
{
    public class Common
    {
        internal Tuple<List<int>, List<int>> GeneratePairToSortInt()
        {
            List<int> sorted = new List<int>() { 1, 2, 3 };
            List<int> unsorted = new List<int>() { 2, 1, 3 };
            return new Tuple<List<int>, List<int>>(sorted, unsorted);
        }
    }
}
