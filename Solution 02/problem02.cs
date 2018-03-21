using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
			// Getting the input from the console
           var a = double.Parse(Console.ReadLine());
           var b = double.Parse(Console.ReadLine());

		   // Doing calculations
           var S = a * b;

		   // Printing the result
            Console.WriteLine($"{S:f2}");

        }
    }
}