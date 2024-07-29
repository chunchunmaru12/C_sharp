using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("Input year");
            string year=Console.ReadLine();
            y=int.Parse(year);
            if (y % 4 == 0)
            {
                if(y%100==0)
                {
                    if (y % 400==0)
                    {
                        Console.WriteLine("It is leap year");
                    }
                    else
                    {
                        Console.WriteLine("Meow Meow");
                    }

                }
                else
                {
                    Console.WriteLine("It is leap year");
                }
            }
            else
            {
                Console.WriteLine("Meow Meow");
            }
        }
    }
}
