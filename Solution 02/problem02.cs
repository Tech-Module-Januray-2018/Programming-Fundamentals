using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
           var a = double.Parse(Console.ReadLine());
           var b = double.Parse(Console.ReadLine());

           var S = a * b;

            Console.WriteLine($"{S:f2}");

        }
    }
}