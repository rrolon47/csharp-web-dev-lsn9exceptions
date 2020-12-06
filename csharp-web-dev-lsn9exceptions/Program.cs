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

        //static int CheckFileExtension(string fileName)
        //{
            // Write your code here!
            //If a student’s submitted file ends in .cs, they get 1 point.If a student’s 
            //    submitted file doesn’t end in .cs, they get 0 points.If the file submitted 
            //    is null or an empty string, an exception should be thrown. What kind of exception is up to you!
            //return integer representing the number of points a student receives for properly submitting a file in C# 
        //}


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


            }
    }
}
