using System;

namespace Solution_01
{
    class Program
    {
        static void Main(string[] args)
        {   
            //initializing four integers 
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var fourthNumber = int.Parse(Console.ReadLine());

            //printing the numbers in 4-digit debit card format
            Console.WriteLine($"{ firstNumber:d4} {secondNumber:d4} {thirdNumber:d4} {fourthNumber:d4}");
        }
    }
}
