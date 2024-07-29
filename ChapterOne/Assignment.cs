using System;

namespace ChapterOne
{
    class Assignment
    {
        static void Main(string[] args)
        {
           /* int[] num = new int[4]; 
            int sum = 0;    
            for (int n = 0; n < 4; n++)
            {
                Console.Write("Enter your " + (n + 1) + " number: "); 
                num[n] = Convert.ToInt32(Console.ReadLine());
                sum += num[n];
            }
            Console.WriteLine("The sum of all  numbers is: " + sum);
           */
            int a, b, c, d, s = 0;
            Console.WriteLine("Enter your first number");
            string input = Console.ReadLine();
            a = int.Parse(input);
            Console.WriteLine("Enter your second number");
            input = Console.ReadLine();
            b = int.Parse(input);
            Console.WriteLine("Enter your third number");
            input = Console.ReadLine();
            c = int.Parse(input);
            Console.WriteLine("Enter your fourth number");
            input = Console.ReadLine();
            d = int.Parse(input);
            s = a + b + c + d;

            Console.WriteLine("The sum of the numbers is: " + s);
        }
    }
}

