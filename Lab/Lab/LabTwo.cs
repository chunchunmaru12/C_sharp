using System;

namespace Lab
{
    internal class LabTwo
    {
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Math error: Division by zero");
                return 0;
            }
            return a / b;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to my calculator:");
                Console.Write("Enter the First number to perform the operation on: ");

                if (!double.TryParse(Console.ReadLine(), out double numOne))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.Write("Enter the Second number to perform the operation on: ");
                if (!double.TryParse(Console.ReadLine(), out double numTwo))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Press\n 1 for Addition \n 2 for Subtraction\n 3 for Multiplication\n 4 for Division\n 5 to Exit ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                    continue;
                }

                double result;
                switch (choice)
                {
                    case 1:
                        result = Add(numOne, numTwo);
                        Console.WriteLine("Your sum: " + result);
                        break;
                    case 2:
                        result = Subtract(numOne, numTwo);
                        Console.WriteLine("Your difference: " + result);
                        break;
                    case 3:
                        result = Multiply(numOne, numTwo);
                        Console.WriteLine("Your product: " + result);
                        break;
                    case 4:
                        result = Divide(numOne, numTwo);
                        Console.WriteLine("Your division: " + result);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid choice.");
                        break;
                }
            }
        }
    }
}
