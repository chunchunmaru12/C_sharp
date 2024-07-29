using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne
{
     class Largest
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter first number:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            c =int.Parse(Console.ReadLine());
            if(a>b && a > c)
            {
                Console.WriteLine("{0} is the greatest",a);
            }else if (b>c)
            {
                Console.WriteLine("{0} is the greatest",b);
            }
            else
            {
                Console.WriteLine("{0} is the greatest",c);
            }
        }
    }
}
