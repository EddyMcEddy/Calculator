using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Calculator");
            Console.WriteLine("_____________________");

            Console.Write("Enter first digit: ");
            double userFirstDigit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the sign you like: ");
            var userSign = Console.ReadLine();

            Console.WriteLine("Enter your second digit: ");
            double userSecondDigit = Convert.ToDouble(Console.ReadLine());


            if (userSign == "-")
            {
                Console.WriteLine(userFirstDigit - userSecondDigit);
            }
            else if (userSign == "+")
            {
                Console.WriteLine(userFirstDigit + userSecondDigit);
            }
            else if (userSign == "%")
            {
                Console.WriteLine(userFirstDigit % userSecondDigit);
            }
            else if (userSign == "*")
            {
                Console.WriteLine(userFirstDigit * userSecondDigit);
            }
            else if (userSign == "/")
            {
                Console.WriteLine(userFirstDigit / userSecondDigit);

            }
            else
            {
                Console.WriteLine("Invalid sign");
            }

        }
    }
}
