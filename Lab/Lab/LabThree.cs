using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class LabThree
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i,4}");
            }
            Console.WriteLine();
            Console.WriteLine(new String('-', n * 4 + 4));



            //  Console.WriteLine("\n----------------------\n");

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}|");
                for (int j = 1; j <= n; j++)
                {

                    Console.Write($"{i * j,4}");

                }
                Console.WriteLine();
            }
        }
        }
}
