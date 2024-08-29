using System;
using System.Collections.Generic;

namespace Chapter4
{
    class LambdaTwo
    {
        static bool isEven(int num) => (num%2 ==0);
        static void Main()
        {
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int number in numbers)
            {
                if (isEven(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
