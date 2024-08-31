using System;
namespace Chapter4
{
    class ExceptionThree
    {
        static void Main()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                int index = 3;
                int value = numbers[index];
                Console.WriteLine("Value at index {0}: {1}", index, value);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: "+ ex.Message);
            }
        }
    }
}