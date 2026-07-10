using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Week04Day04Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Recursion: when a method calls itself
             * Any programming problem which can solved using a loop
             * can also be solved using recursion
             * 
             * * Calling phase -> Base Case -> Return Phase
             * 
             * * Missing base case- Infinite loop 
             * 
             * 1. Method should call itself
             * 2. Define base case [stop condition]
             * 3. With each call it should go towards the base condition
             */

            // using loop print 1 to 5 numbers on screen
            for (int i = 1; i <= 5; ++i)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Same solution using recursion");

            PrintNumber(1);

            // Sum of numbers till 5
            int sum = 0;
            for (int i = 1; i <= 5; ++i)
            {
                sum += i;   
            }
            Console.WriteLine($"Sum of numbers till 5 is = {sum}");

            Console.WriteLine($"Sum of numbers till 5 recursively = {CalculateTotal(5)}");

            Console.Write("Enter the value for which you would like to calculate Factorial: ");
            int num = int.Parse( Console.ReadLine() );
            
            Console.WriteLine($"Factorial of 5! = {Factorial(num)}");

            // Declare an array for Linear search operation
            int[] numbers = { 4, 5, 6, 15, 21, 37 };

            int itemSearch = 19;

            int indexOfItem = -1; // -1 means not in the list

            indexOfItem = LinearSearchRecursive(numbers, itemSearch, 37);

            Console.WriteLine(indexOfItem);

            Console.WriteLine("Binary Search Iterative Solution");

            indexOfItem = BinarySearchIterative(numbers, 14);

            string message = indexOfItem == -1 ? "Item is not in the list" : " Item is found at index " + indexOfItem;

            Console.WriteLine(message);

            Console.WriteLine("Binary Search Recursive Solution");

            indexOfItem = BinarySearchRecursive(numbers, 140, 0, 5);

            message = indexOfItem == -1 ? "Item is not in the list" : " Item is found at index " + indexOfItem;

            Console.WriteLine(message);
        }

        public static int BinarySearchRecursive(int[] collection, int target, int low, int upper)
        {
            // Base Condition I: otherwise it will become infinite loop
            if (low > upper)
                return -1; // Means item not found

            int mid = (low + upper) / 2;

            // Base condition II
            if (target == collection[mid])
                return mid;   // Found the match so return the index of that element
            else if (target < collection[mid])
            {
                // Need to search in the first half of the list
                // update upper
                upper = mid - 1;
                return BinarySearchRecursive(collection, target, low, upper);
            }
            else
            {
                // Need to search in the upper half of the list
                //update low 
                low = mid + 1;
                return BinarySearchRecursive(collection, target, low, upper);
            }


        }
        public static int BinarySearchIterative(int[] collection, int target)
        {
            int low =0, upper = collection.Length - 1, mid=0;

            /*Repeat step 1 to 3 till  low <= upper
                 *1. Find the new mid by adding (low + Upper) /2
                 * 
                 *2. if element at Mid == target: return index
                 * 
                 *3.  if target < element @mid
                 *3a.  upper := mid- 1
                 * else
                 *3b  low := mid +1 
             *  
             * If low > upper return -1
             * */
            while (low <= upper)                //Repeat step 1 to 3 till  low <= upper
            {
                mid = (low + upper) / 2;        // Step 1

                if (collection[mid] == target)  // Step 2
                    return mid;

                if (target < collection[mid])  // Step 3
                {
                    upper = mid - 1;           // Step 3a
                }
                else
                {
                    low = mid + 1;             // Step 3b
                }
            }

            return -1; // Item is not in the list

        }


        // Write a method LinearSearchRecursive to find an item in the list
        // if item is found return the index of that otherwise -1
        public static int LinearSearchRecursive(int[] collection, int target, int index = 0) 
        {
            /*1.Method should call itself
             *2.Define base case [stop condition]
             *3.With each call it should go towards the base condition
             */

            //Base Case 1: Element not found
            // Index is going to be outside the upper bound for the final call
            if (index >= collection.Length)
            {
                return -1;
            }
                
            // Base Case 2: Element found
            if (target == collection[index])
                return index;

            return LinearSearchRecursive(collection, target, index + 1);
        }

        // write a method to calculate total of first n numbers-
        // where n is provided by user

        public static int CalculateTotal(int n)
        {
            // Base condition
            if(n == 0)
                return 0;
            //Console.WriteLine(n);
            return  CalculateTotal(n - 1) + n;
        }

        public static int Factorial(int n)
        {
            // Base condition
            if (n == 0)
                return 1;  // 0! = 1
            //Console.WriteLine(n);
            return Factorial(n - 1) * n;
        }

        public static void PrintNumber(int n)
        {
            // Always put base condition as the first thing
            if (n == 6) // Base case: going to stop Recursive calls
                return;

            //Calling the same function
            PrintNumber(n+1); // Step 3: go towards base condition

            //Action you want to take
            Console.WriteLine(n);
        }
    }
}
