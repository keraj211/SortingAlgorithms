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
            int minIndex, size = numbersToSort.Count();
            T value;

            for (int i = 0; i < size - 1; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < size; j++)
                {
                    if (numbers[j].CompareTo(numbers[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                value = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = value;
            }

            return numbers;
        }
    }
}
