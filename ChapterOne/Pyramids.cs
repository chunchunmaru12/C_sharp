using System;


namespace ChapterOne
{
    internal class Pyramids
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Pyramid:");
            Console.WriteLine("Enter the length:");
            int n=int.Parse(Console.ReadLine());
            for(int a=0; a < n; a++)
            {
                for (int b = 0; b < (n-1- a); b++)
                {
                    Console.Write(" ");
                }
                for (int c=0; c < (2*a+1); c++)
                {
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
