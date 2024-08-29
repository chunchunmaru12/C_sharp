using System;

namespace Chapter4
{
    class LambdaOne
    {
        public delegate void PrintMessage(string message);

        static void Main(string[] args)
        {
            PrintMessage print = (message) =>
            {
                Console.WriteLine(message);
            };

            print("Hello world");
        }
    }
}