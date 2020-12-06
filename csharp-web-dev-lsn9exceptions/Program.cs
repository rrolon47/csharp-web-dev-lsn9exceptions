using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            // Write your code here!
            if (y.Equals(0))
            {
                throw new ArgumentOutOfRangeException("Cannot divide by zero. Check your input and try again.");
            }

            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            int point = 0;
           

            if (String.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("File is null or empty.");
            }
            else
            { 
                string[] file = fileName.Split(".");
                string fileType = file[1];
                if (fileType.Equals("cs"))
                {
                    point++;
                }
            }
           

            return point;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try 
            {
                Console.WriteLine("Enter student point score:");
                int points = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter total possible points:");
                int total = int.Parse(Console.ReadLine());
                Console.WriteLine($"Student grade: {Divide(points, total)}");

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("cannot divide by zero.  Check your input and try again");
            }


            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            try
            {
                foreach(KeyValuePair<string, string> student in students)
                {
                    Console.WriteLine($"student: {student.Key} file: {student.Value} point:{CheckFileExtension(student.Value)}");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Entry is null or empty.");
            }

        }
    }
}
