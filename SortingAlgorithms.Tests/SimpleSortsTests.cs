using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SortingAlgorithms.Tests
{
    [TestFixture]
    public class SimpleSortsTests
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
        public void SelectionSort_SortIntNumbers_SortedIntNumbers()
        {
            Tuple<List<int>, List<int>> tmp = _common.GeneratePairToSortInt();
            IEnumerable<int> sorted =  SimpleSorts.SelectionSort(tmp.Item2);

            Assert.AreEqual(tmp.Item1, sorted);
        }

        [Test]
        public void SelectionSort_SortEmptyList_ReturnEmptyList()
        {
            IEnumerable<int> sorted = SimpleSorts.SelectionSort(new List<int>());

            Assert.AreEqual(new List<int>(), sorted);
        }

        [Test]
        public void InsertionSort_SortIntNumbers_SortedIntNumbers()
        {
            Tuple<List<int>, List<int>> tmp = _common.GeneratePairToSortInt();
            IEnumerable<int> sorted = SimpleSorts.SelectionSort(tmp.Item2);

            Assert.AreEqual(tmp.Item1, sorted);
        }

        [Test]
        public void InsertionSort_SortEmptyList_ReturnEmptyList()
        {
            IEnumerable<int> sorted = SimpleSorts.SelectionSort(new List<int>());

            Assert.AreEqual(new List<int>(), sorted);
        }
    }
}
