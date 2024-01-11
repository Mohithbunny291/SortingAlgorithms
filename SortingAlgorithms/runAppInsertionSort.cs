using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class runAppInsertionSort
    {
        public runAppInsertionSort()
        {
            int[] arrayToSort = { 12, 11, 13, 5, 6 };
            InsertionSort insertionSort = new InsertionSort();
            Console.WriteLine("Array before sorting:");
            insertionSort.PrintArray(arrayToSort);

            // Perform Insertion Sort
            insertionSort.Insertion(arrayToSort);

            Console.WriteLine("\nArray after sorting:");
            insertionSort.PrintArray(arrayToSort);
        }
    }
}
