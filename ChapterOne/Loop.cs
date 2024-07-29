using System;

namespace ChapterOne
{
    class Loop
    {
        static void Main(string[] args)
        {   
            int i = 0;
            while (i <= 50)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            int prod = 1;
            Console.WriteLine("Enter your number:");
            int num = int.Parse(Console.ReadLine());
            for (int k = 1; k <= num; k++)
            {
                prod = prod * k;
            }
            Console.WriteLine(prod);

            int a = 0;
            int b = 1;
            int c;
            while (a <= num)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(a);
            }

            string name = "madam";
            int g = 0;
            bool isPalindrome = true;

            for (int x = name.Length - 1; x >= name.Length / 2; x--)
            {
                if (name[g] == name[x])
                {
                    g++;
                }
                else
                {
                    Console.WriteLine("Not Palindrome");
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Palindrome");
            }
        }
    }
}
