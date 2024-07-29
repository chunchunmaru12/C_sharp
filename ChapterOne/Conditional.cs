using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne
{
    class Conditional
    {
        static void Main(string[] args)
        {   // if else
            int time=20;
            if(time < 18)
            {
                Console.WriteLine("Good day ");
            }
            else
            {
                Console.WriteLine("Good evening");
            }

            //if else if
            if(time < 10)
            {
                Console.WriteLine("Good day");
            }else if (time> 22)
            {
                Console.WriteLine("Good evening");
            }
            else
            {
                Console.WriteLine("Good night");
            }
            // ternary operator
            string result = (time>22)?"Good day":"Good evening";
            Console.WriteLine(result);
            // switch case
            int day = 5;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    goto case 1;
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
               /* default:
                    Console.WriteLine("wrong");
                    break;*/
            }
            
        }
    }
}
