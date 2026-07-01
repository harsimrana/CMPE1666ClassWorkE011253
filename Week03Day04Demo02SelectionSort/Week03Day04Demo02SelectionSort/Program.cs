using System.Diagnostics.Contracts;

namespace Week03Day04Demo02SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array to store numbers
            int[] numbers = { 1000, 7, 0, 9, 21, -37, 17, -1 };

            // Print array before sorting
            Console.WriteLine("List before sorting");
            foreach (int numb in numbers)
            { 
                Console.WriteLine(numb);
            }

            //Sort the list using Selection Sort
            // UNCOMMENT THE FOLLOWING LINE TO TEST IT WITH SELECTION SORT
            //SelectionSort(numbers);

            // sort using Insertion Sort
            InsertionSort(numbers);  // n2


            // Print after sorting
            Console.WriteLine("List after sorting");
            foreach (int numb in numbers)
            {
                Console.WriteLine(numb);
            }

        }

        /* Method to perfomr selection  sort
         * Inputs:  An array to sort
         * Output: Nothing
         */
        public static void SelectionSort(int[] arr)
        { 
           int numberOfElements = arr.Length;

            int minElementIndex;

            //Number of passes will be controlled by outer loop
            for (int i = 0; i < numberOfElements - 1; ++i)
            {
                minElementIndex = i;
                // Finding the smallest element's index from the rest of the list
                for (int j = i + 1; j < numberOfElements; ++j)
                {
                    if (arr[j] < arr[minElementIndex])
                    {
                        minElementIndex = j;
                    }
                }

                if (minElementIndex != i)
                {
                    //Swap the found minimum element 
                    int temp = arr[minElementIndex];
                    arr[minElementIndex] = arr[i];
                    arr[i] = temp;
                }
            }


        }

        /* Method to perfomr Insertion  sort
         * Inputs: An array to sort
         * Output: Nothing
         */
         public static void InsertionSort(int[] arr)
         {
            for (int i = 1; i < arr.Length; ++i)
            {
                //Key: Element to be inserted
                int temp = arr[i];
                int j = i - 1;

                //Move elements greater than key to one position ahead
                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Insert the key at the correct position
                arr[j + 1] = temp;
            }// end of outer loop
         }// end of function insertion
    }// end of class
}// end of namespace
