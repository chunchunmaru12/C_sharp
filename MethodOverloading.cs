using System;
namespace LabTwo
{
    public class Calculator
    {
        public int Add(int num1, int num2) =>(num1 + num2);
        public double Add(double num1, double num2)=>(num1 + num2);
        public string Add(string str1, string str2)=>(str1 + str2);
    }
    public class MethodOverloading
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int sum1 = calculator.Add(5, 10);
            Console.WriteLine("Sum of integers: " + sum1);
            double sum2 = calculator.Add(3.14, 2.71);
            Console.WriteLine("Sum of doubles: " + sum2);
            string sum3 = calculator.Add("Hello", " World!");
            Console.WriteLine("Concatenated string: " + sum3);
        }
    }
}