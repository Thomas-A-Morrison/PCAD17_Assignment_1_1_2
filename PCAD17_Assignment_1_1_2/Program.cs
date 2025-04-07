// Program:    PCAD_Project_1.1.2
// Date:       7 APR 2025
// Programmer: Thomas A. Morrison

using System;
using System.Globalization;
namespace PCAD_Project_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double sumNumber = firstNumber + secondNumber;

            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {sumNumber}.");
        }
    }
}
