using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    public static class SimpleSorts
    {
        public static IEnumerable<T> SelectionSort<T>(IEnumerable<T> numbersToSort) where T : IComparable
        {
            IList<T> numbers = numbersToSort.ToList();
            int minKey, size = numbersToSort.Count();
            T tmp;

            for (int i = 0; i < size - 1; i++)
            {
                minKey = i;

                for (int j = i + 1; j < size; j++)
                {
                    if (numbers[minKey].CompareTo(numbers[j]) < 0)
                    {
                        minKey = j;
                    }
                }

                tmp = numbers[minKey];
                numbers[minKey] = numbers[i];
                numbers[i] = tmp;
            }

            return numbers;
        }
    }
}
