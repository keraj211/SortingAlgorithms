using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    public static class SimpleSorts
    {
        /// <summary>
        /// Selection sort is an algorithm of sorting an array where it loop from the start of the loop, and check through other elements to find the minimum value. 
        /// After the end of the first iteration, the minimum value is swapped with the current element. The iteration then continues from the 2nd element and so on.
        /// </summary>
        /// <typeparam name="T">IComparable type of value</typeparam>
        /// <param name="numbersToSort">Collection of numbers to sort</param>
        /// <returns>Sorted collection</returns>
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
