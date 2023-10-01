using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int result;
                Console.WriteLine("Enter 1st number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the operation you need to perform (+,-,*,/)");
                string symbol = Console.ReadLine();
                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"sum of 2 numbers is {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Subtraction of 2 numbers is {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Multiplication of 2 numbers is {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Division of 2 numbers is {result}");
                        break;
                    default:
                        Console.WriteLine("you have entered wrong input");
                        break;
                }
                Console.WriteLine("Do you want to continue(y/n)");
                value = Console.ReadLine();


            }
            while (value == "y" | value == "Y");
            Console.WriteLine("you have entered No");
            Console.WriteLine("Exited!");
            Console.Read();

        }
    }
}
