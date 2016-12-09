using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms.EfficientSorts
{
    public static class EfficientSorts
    {
        public static IEnumerable<T> QuickSort<T>(IEnumerable<T> numbersToSort, int left, int  right) where T : IComparable
        {
            IList<T> numbers = numbersToSort.ToList();
            int size = numbersToSort.Count();

            // For Recusrion
            if (left < right)
            {
                int pivot = Partition(numbers, left, right);

                if (pivot > 1)
                    QuickSort(numbers, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort(numbers, pivot + 1, right);
            }

            return numbers;
        }

        private static int Partition<T>(IList<T> numbers, int left, int right) where T : IComparable
        {
            T pivot = numbers[left];
            while (true)
            {
                while (numbers[left].CompareTo(pivot) < 0)
                    left++;

                while (numbers[right].CompareTo(pivot) > 0)
                    right--;

                if (left < right)
                {
                    T temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
