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

            indexOfItem = LinearSearchRecursive(numbers, itemSearch, 0);

            Console.WriteLine(indexOfItem);
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
