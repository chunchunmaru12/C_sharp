using System;
namespace Chapter4{
    class Test5{
        static void Main(string[] args)
        {
            int[] numbers = {-2,7, -9, -10, 11, 12, 13, 14, 15};
            var postiveSum = numbers.Where(n => n % 2 == 0).Sum();
            var negativeSum=numbers.Where(n => n % 2 != 0).Sum();
            Console.WriteLine("Even Sum: " + postiveSum);
            Console.WriteLine("Odd Sum: " + negativeSum);
        }
    }
}