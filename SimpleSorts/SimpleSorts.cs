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

        /// <summary>
        /// The Insertion sort algorithm views the data in two halves. 
        /// The left half of sorted elements and the right half of elements to be sorted. 
        /// In each iteration, one element from the right half is taken and added to the left half so that the left half is still sorted. 
        /// Insertion sort is of order O(n2).
        /// Insertion sort takes an element from the list and places it in the correct location in the list.
        /// This process is repeated until there are no more unsorted items in the list.
        /// </summary>
        /// <typeparam name="T">IComparable type of value</typeparam>
        /// <param name="numbersToSort">Collection of numbers to sort</param>
        /// <returns>Sorted collection</returns>
        public static IEnumerable<T> InsertionSort<T>(IEnumerable<T> numbersToSort) where T : IComparable
        {
            IList<T> numbers = numbersToSort.ToList();
            int ins, size = numbersToSort.Count();
            T value;

            for (int i = 0; i < size; i++)
            {
                value = numbers[i];
                ins = 0;
                for (int j = i - 1; j >= 0 && ins != 1;)
                {
                    if (value.CompareTo(numbers[j]) < 0)
                    {
                        numbers[j + 1] = numbers[j];
                        j--;
                        numbers[j + 1] = value;
                    }
                    else
                    {
                        ins = 1;
                    }
                }
            }

            return numbers;
        }
    }
}
