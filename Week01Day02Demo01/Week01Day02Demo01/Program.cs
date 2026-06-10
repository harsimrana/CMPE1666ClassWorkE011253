using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01Day02Demo01
{
    internal class Program
    {
        // No Global variables

        struct Employee
        {
            public int Id;
            public string Name;
            public double Salary;

            public Employee(int id, string name, double salary)
            {
                Id = id;
                Name = name;
                Salary = salary;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($" ID: {Id} Name= {Name} Salary ={Salary}");
            }
        }

        private static void PrintTable(int number)
        {
            for(int i = 1; i<= 10; i++)
            {
                Console.WriteLine($" {number} x {i} = {number * i}");
            }

        }
        static void Main(string[] args)
        {
            // Single line comment
            /* Multiline comment
             */
            // Declaring variables 
            /*
            double radius, areaCircle = 0;
            char choice;

            do
            {
                // Input
                Console.Write("Enter the value of radius of circle: ");
                radius = double.Parse(Console.ReadLine());

                if (radius > 0 && radius < 100) // Compound condition: using logical AND 
                {
                    //Processing
                    areaCircle = Math.PI * radius * radius;

                    //Output
                    Console.WriteLine($"Area of the circle =  {areaCircle:0.00}");
                }
                else
                {
                    Console.WriteLine("Radius must be greater than 0 and less than 100");
                }

                Console.Write("Press Y to continue: ");
                choice = char.Parse(Console.ReadLine());

            } while (choice == 'y' || choice == 'Y');

            */

            // Loops
/*
            int number;

            Console.Write("For which number you need mulitiplication table: ");
            number = int.Parse(Console.ReadLine());

            PrintTable(number);

            // Create an array and populate the array by taking values from 
            // user. Then, find sum of all the values and print on Console window.

            // Declaring and initializing an array

            int[] marks = { 1, 2, 3, 4, 5 };
            //int[] marks = new int[5]; // 5 elements

            int i = 0, sum = 0;

            // Input from user
            while (i < marks.Length)
            {
                Console.Write($"Enter element number {i + 1} :");
                marks[i] = int.Parse(Console.ReadLine());

                sum += marks[i];  
                // sum = sum + marks[i];
                i++;
            }

            Console.WriteLine($"Sum of numbers = {sum}");

            // print the array 
            foreach( int element in marks)
            {
                Console.WriteLine(element);
            }
*/

            // Random number

            Random rn = new Random();

            Console.WriteLine($" Random number { rn.Next(1,7) }");

            Employee emp1 = new Employee(1, "Simran", 15.6);

            Console.WriteLine($" Employee Id  = {emp1.Id} Name = {emp1.Name}");

            Employee[] companyEmployees = new Employee[4];

            companyEmployees[0] = new Employee(1, "Harsimran", 15.6);
            companyEmployees[1] = new Employee(2, "Rex", 23.5);
            companyEmployees[2] = new Employee(3, "Boss", 55.6);
            companyEmployees[3] = new Employee(4, "Lucky", 23.6);

            for (int j = 0; j < companyEmployees.Length; ++j)
            {
                companyEmployees[j].DisplayInfo();
                //Console.WriteLine($" Id= {companyEmployees[j].Id} Name= {companyEmployees[j].Name} ");
            }

            // Create a simple ball on the screen to move it.
        }
    }
}
