using System;
namespace Chapter4{
    class Test4{
        static void Main(string[] args)
        {
            int[] numbers = {2,7, 9, 10, 11, 12, 13, 14, 15};
            var resultEven=numbers.Count(n=> n%2==0);
            var resultOdd=numbers.Count(n=> n%2!=0);
            Console.WriteLine("Even Count: " + resultEven);
            Console.WriteLine("Odd Count: " + resultOdd);
        }
    }
}