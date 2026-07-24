using System.Diagnostics.Tracing;

namespace Week07Day04DelegatesDemo
{
    internal class Program
    {
        // To use delegate, delegate type

        // which will return nothing, but it will take one string parameter
        delegate void delSingleString(string str);


        static void Main(string[] args)
        {
            // What are delegates
            int ageUser = 25; // ageUser is an instance of an interger value

            ageUser = 45;

            List <int> balls = new List<int>();

            // Similary a delegate creates an object that can be a reference to a method
            Console.WriteLine("Inside Main ");

            // Creating delegate object and assigning the method PrintName to it
            delSingleString delStr1 = new delSingleString(PrintName);

            // To execute the method, you can use invoke method
            delStr1.Invoke("Simran");

            // You can omit the new and constructor stuff, C# will handle that for you
            delStr1 = PrintName;
            //delStr1.Invoke("34");
            // Keyword Invoke is also optional
            delStr1("Simran");  // YES, Possible

            delStr1 = PrintMarks;

            delStr1("45");
            //PrintName("Simran");
        }

        public static void PrintName(string str)
        {
            Console.WriteLine($" Your name {str}");
        }

        public static void PrintMarks(string str)
        {
            Console.WriteLine($"Your Marks are {str}");
        }
    }
}
