namespace Chapter4
{
    class LambdaThree
    {
        public delegate void Process(int number);
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 6 };
            // Lambda expression as a callback method
            ProcessNumbers(numbers, number => Console.WriteLine("Number: " + number));
        }
        public static void ProcessNumbers(List<int> numbers, Process process)
        {
            foreach (var number in numbers)
            {
                process(number);
            }
        }
    }
}