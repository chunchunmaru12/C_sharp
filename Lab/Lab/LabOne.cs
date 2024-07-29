using System;
namespace Lab
{
    class LabOne
    {
        static void Main(string[] args)
        {
            // lab. Writee a program to demonstarte the difference between Console.ReadLine()
            // and Console.Read(),Console,Write() and Console.WriteLine() in c#
            Console.WriteLine("Enter your name: "); // this echo whatever written inside of it and goes to next line
            string name=Console.ReadLine(); // it reads the characters entered by users until enter key is pressed and stored in name variable
            Console.WriteLine("Your name is:"+name);// this displays the result in formatted way such that entered name is also displayed
            Console.Write("Hello {0}",name); // this displays the text written inside without breaking line
            Console.WriteLine(" can i help you.");
            Console.WriteLine("Its a lovely day, isnot it?");
            Console.Write("enter your : ");
            int sn = Console.Read();
            Console.WriteLine($"your number is {sn}");
            Console.WriteLine("Bye");
            Console.ReadKey();
        
        }
    }
}