using NUnit.Framework;
using SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Tests
{
    [TestFixture]
    public class SimpleSortsTests
    {
        [Test]
        public void SelectionSort_SortIntNumbers_SortedIntNumbers()
        {
            Tuple<List<int>, List<int>> tmp = GeneratePairToSortInt();
            IEnumerable<int> sorted =  SimpleSorts.SelectionSort(tmp.Item2);

            Assert.AreEqual(tmp.Item1, sorted);
        }

        [Test]
        public void SelectionSort_SortEmptyList_ReturnEmptyList()
        {
            IEnumerable<int> sorted = SimpleSorts.SelectionSort(new List<int>());

            Assert.AreEqual(new List<int>(), sorted);
        }

        private Tuple<List<int>, List<int>> GeneratePairToSortInt()
        {
            List<int> sorted = new List<int>() { 1, 2, 3 };
            List<int> unsorted = new List<int>() { 2, 1, 3 };
            return new Tuple<List<int>, List<int>>(sorted, unsorted);
        }
    }
}
