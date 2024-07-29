using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne
{
    class NumberClassification
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter your number");
            string n=Console.ReadLine();
            num=int.Parse(n);
            if (num > 0)
            {
                Console.WriteLine("It is positive");
            }else if (num<0)
            {
                Console.WriteLine("It is negative");
            }
            else
            {
                Console.WriteLine("It is zero");
            }
        }
    }
}
