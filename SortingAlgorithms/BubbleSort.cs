using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class BubbleSort
    {
        public BubbleSort() 
        {
            Console.WriteLine("Enter the length of an Array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} elements", n);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Console.WriteLine( arr.Length);
            for (int i = 0;i < arr.Length - 1; i++)
            {
                int ichange = 0;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        ichange++;
                    }
                }if(ichange == 0)
                {
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
