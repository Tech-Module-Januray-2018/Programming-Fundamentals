using System;

//CONFIRMED from mariaslytherin

namespace Solution_01
{
    class Program
    {
        static void Main(string[] args)
        {   
            //initializing four integers 
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            //printing the numbers in 4-digit debit card format
            Console.WriteLine($"{ firstNumber:d4} {secondNumber:d4} {thirdNumber:d4} {fourthNumber:d4}");
        }
    }
}
