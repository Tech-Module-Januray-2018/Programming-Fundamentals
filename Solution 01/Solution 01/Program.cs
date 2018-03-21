using System;

namespace Solution_01
{
    class Program
    {
        static void Main(string[] args)
        {   
            //initializing four integers 
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            //printing the numbers in 4-digit debit card format
            Console.WriteLine($"{ firstNumber:d4} {secondNumber:d4} {thirdNumber:d4} {fourthNumber:d4}");
        }
    }
}
