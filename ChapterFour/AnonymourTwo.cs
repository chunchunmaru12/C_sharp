using System;
using System.Collections.Generic;
namespace Chapter4{
class Program4
{
    delegate bool Filter(int number);

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Filter isEven = delegate (int number)
        {
            return number % 2 == 0;
        };
    
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

