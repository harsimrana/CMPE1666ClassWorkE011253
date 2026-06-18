using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02Day03ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List: is similar to array
             * - store multiple entities of given type
             * - access an element using the name of the list and index
             * - List variable is reference type
             * 
             */

            // Create a list

            // List <data type> nameOfList = new List <DataType> ();
            List<int> number = new List<int>(); // Empty list to maintain interger values
            List<double> marks = new List<double> { 10, 12, 15 }; // List with 3 starting values
                                                                  // 
            // List with 3 starting string values      Maximum of elements
            List<string> studentNames = new List<string>(20) { "ABC", "XYZ", "Simran", "123" };

            // Access the list elements
            // Tryting to access the first element from both lists whichs is at index position 0

            Console.WriteLine($"Student = {studentNames[0]} : {marks[0]}");

            Console.WriteLine("List of all the students");

            // Count property will give you current total number of elements in the list
            for (int i = 0; i < studentNames.Count; ++i)
            {
                Console.WriteLine(studentNames[i]);
            }

            // Basic Operations possible on List

            /* Add elements
             * Insert element
             * Remove elements
             */

            // Add an element to studentNames list
            studentNames.Add("Rex"); // Add the new element at the end of list

            Console.WriteLine("After adding new element revised list");

            foreach (string item in studentNames)
            {
                Console.WriteLine(item);
            }

            // Insert an element in a list: specifix index 
            // index, value
            studentNames.Insert(2, "Boss");

            // Feels like we need a method
            Console.WriteLine("After adding new element revised list");

            foreach (string item in studentNames)
            {
                Console.WriteLine(item);
            }

            //Create an array and add it to your list
            string[] newNames = { "123", "Lucky", "parking" };

            // Insert new set of names at index position 3 in our list

            studentNames.InsertRange(3, newNames);

            Console.WriteLine("After inserting new elements revised list:");

            PrintList(studentNames);

            // Remove an element from the list
            // element to be deleted : the first occurrence
            studentNames.Remove("123");

            Console.WriteLine("After removing 123 from the list");
            PrintList(studentNames);

            // Remove an element from a particular index
            studentNames.RemoveAt(0); // index position

            Console.WriteLine("After removing first element index 0 from the list");
            PrintList(studentNames);

            // Clear your list 
            //studentNames.Clear(); // delete all the elements from the list

            Console.WriteLine("After removing all elements from the list");
            PrintList(studentNames);

            // Count property: will give you total number of elements in the list
            Console.WriteLine($" Total elements in the list {studentNames.Count}");
            Console.WriteLine($" Total capacity of the list {studentNames.Capacity}");

            // Sort your list
            studentNames.Sort(); // sort your list using QuickSort algo for sorting

            Console.WriteLine("Printing my list after sorting");
            PrintList(studentNames);

            // To reverse your list
            studentNames.Reverse();
            Console.WriteLine("Printing my list after reversing ");
            PrintList(studentNames);

            // Max() , Min() and Average()

            // string.join on a list will concat all element
                                  //         separator, list
            // will return a single string value
            string concatedList = string.Join(",", studentNames);

            Console.WriteLine($"Printing elements after joining {concatedList}");
            
            // Contain() - will find an element in the list Binary search

        }

        public static void PrintList(List<string> list)
        {
            // Iterating through my list one at a time and printing it
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }


        /* Exercise Question: Try to complete it before the beginning of next class
         Create a list of struct :
          Student information 
               StudentName     [string]
               StudentMarks    [double]
               StudentEmail    [string]
               StudentAge      [int]

         Window app to give interface so user can:
               Add a new student               :   Button
               Remove a student                :   Button
               Insert a student specific index :   Button
               Clear all student from list     :   Button

        */
    }
}
