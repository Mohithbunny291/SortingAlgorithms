using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class SelectionSort
    {
        public SelectionSort() 
        {
            Console.WriteLine("Enter the length of an Array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} elements", n);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0;i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }if(i != min)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
