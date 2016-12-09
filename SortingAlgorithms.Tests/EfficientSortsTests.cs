using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    [TestFixture]
    public class EfficientSortsTests
    {
        private Common _common;

        [TestFixtureSetUp]
        public void RunOnceBeforeAll()
        {
            _common = new Common();
        }

        [TestFixtureTearDown]
        public void RunOnceAfterAll()
        {
            if (_common != null)
            {
                _common = null;
            }
        }

        [Test]
        public void QuickSort_SortIntNumbers_SortedIntNumbers()
        {
            Tuple<List<int>, List<int>> tmp = _common.GeneratePairToSortInt();
            IEnumerable<int> sorted = EfficientSorts.QuickSort(tmp.Item2, 0, tmp.Item2.Count - 1);

            Assert.AreEqual(tmp.Item1, sorted);
        }

        [Test]
        public void QuickSort_SortEmptyList_ReturnEmptyList()
        {
            IEnumerable<int> sorted = EfficientSorts.QuickSort(new List<int>(), 0, 0);

            Assert.AreEqual(new List<int>(), sorted);
        }
    }
}
