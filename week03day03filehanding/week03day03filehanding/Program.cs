using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace week03day03filehanding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File processing");

            // File class can be used to work with your files
            // using system.IO
            // To write into a file : use following methods

            /* File.WriteAllLines(file_path, datatofile)
             * -- data will be in string format
             * 
             * To Read data from file: use the following method
             * File.ReadAllLines(file_path)
             * -- Read all lines from a file and return as an array of strings
             * 
             * File.ReadAllText(file_path)
             * -- Read all data from the file and returns it as ONE string
             */

            // Storing the file path in a variable
            string filePath = "../../../students.txt";

            // Example data to write to your file
            string[] students = { "Simran", "Rex", "Rosine", "Lucky" };

            // write all lines to the text file
            // UNCOMMENT THE FOLLOWING LINE TO WRITE DATA TO FILE
            //File.WriteAllLines(filePath, students);

            //Console.WriteLine("Data has been written to file successfully");

            // Read all lines from the file
            try
            {
                // Reading all lines and storing it in an array of string
                string[] readData = File.ReadAllLines(filePath);

                Console.WriteLine("Data from file: ");
                
                int numberOfLines = 0;
                foreach (string line in readData)
                {
                    numberOfLines++;

                    // splitting the string wherever we have a comma
                    string[] wordsInLine = line.Split(',');

                    if (wordsInLine.Length > 1)
                    {
                        Console.WriteLine("Words in the line are following");
                        foreach (string word in wordsInLine)
                        {
                            Console.Write(word + " ");
                        }
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine($"Number of lines in the file {numberOfLines}");

                // Reading all text at once
                string fileData = File.ReadAllText(filePath);

                Console.WriteLine(fileData);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while doing file operations");
            }

        }
    }
}
