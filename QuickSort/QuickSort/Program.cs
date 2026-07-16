using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 50, 21, 12, 18, 30, 8, 23, 65, 41, 32 };

            Console.WriteLine("Original list before sorting");
            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine( "Partition Index " + Partition(numbers, 0, numbers.Length - 1));
            QuickSort(numbers, 0, numbers.Length - 1);

            Console.WriteLine("After Sorting ");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

        }

        // The QuickSort method implementation
        public static void QuickSort(int[] arr, int low, int high)
        {
            // Base case
            if (low < high)
            {

                // partition index
                int partitionIndex = Partition(arr, low, high);

                // Recursive call for elements smaller than pivot : left hand side sub list
                QuickSort(arr, low, partitionIndex - 1);

                // Recursive call for elements greater than pivot: right hand side of sub list
                QuickSort(arr, partitionIndex + 1, high);
            }
        }
        // Partition methor will retunr the partitionIndex: Final index position
        // of the pivot element in the list passed.
        public static int Partition(int[] arr, int low, int high)
        {
            // choose the pivot element: First, last, middle, random
            int pivot = arr[high];  // Last element as pivot

            // set all the pointers
            int i = low - 1;
            
            //iterate the list and move all smaller elements to the left side
            //elements from low to i are smaller than pivot 
            int j= low;
            while(j < high)
            {
                if (arr[j] < pivot)
                {
                    i++; // There is a reason why we increase i before swap:
                    // and you should know that.
                    // Swap element i with j
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                j++;
            }
            // Move the pivot after smaller elements and return its index position

            int temp1 = arr[j]; // it could be high as well both are equal at this point
            arr[j] = arr[i + 1]; // why i + 1: 
            arr[i + 1] = temp1;

            return i + 1; // index positon of pivot element
                                 
        }
    }
}
