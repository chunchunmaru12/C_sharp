using System;

namespace ChapterOne
{
    class UserInput
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hi,{0}! How are you ", name);
            Console.WriteLine("Hi "+name+",How are you");
            Console.WriteLine($"Hi {name}");
            Console.ReadKey();
        }
    }
}
