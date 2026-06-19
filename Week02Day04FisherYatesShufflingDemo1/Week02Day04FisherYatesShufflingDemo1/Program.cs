namespace Week02Day04FisherYatesShufflingDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5] { 1, 2, 3, 4, 5 };

            // calling DisplayData() to print the list before shuffling
            DisplayData(marks);

            // Calling ShuffleDataFisherYatesAlgo Method to shuffly your list
            ShuffleDataFisherYatesAlgo(marks);

            Console.WriteLine("\nList after shuffling");
            // calling DisplayData() to print the list after shuffling
            DisplayData(marks);
        }

        /* DisplayData() : will print the array
         * Inputs        : collection
         * Return        : nothing
         * 
         */

        public static void DisplayData(int[] myList)
        {
            foreach (int item in myList)
            { 
                Console.Write($" {item},");
            }
        }


        /* ShuffleDataFisherYatesAlgo : will use Fisher yates algo to shuffle the values
         * Input                      : collection
         * Return                     : nothing
         *
         * */
        public static void ShuffleDataFisherYatesAlgo(int[] myList)
        {
            // Create a random object to generate random number
            Random rand = new Random();

            // Get the number of elements in list
            int numberOfElements = myList.Length;

            //Start shuffling using Fisher-yates Algorithm

            // We iterate from the last element down to second element [index 1]
            for (int i = numberOfElements - 1; i > 0; --i)
            {
                // generate a random index j between 0 - n-1 (inclusive)

                int j = rand.Next(0, i + 1);

                // Swap the elements at position j and n-1
                // temp stores the element temporarily

                int temp = myList[i];
                // Place the element from positon j into n-1
                myList[i] = myList[j];

                // Put the element stored in temp to into j
                myList[j] = temp;

                // at this point, the element at index n-1 has been randomly 
                // swapped 
            }
        }
    }
}
