using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne
{
    class Vowel
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("Enter a character: ");
            a = char.Parse(Console.ReadLine());
            /*      switch (a)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("Vowel");
                        break;
                    default:
                        Console.WriteLine("Consonant");
                        break;
                }
    */
            string result = "";
            char[] vow = { 'a', 'e', 'i', 'o', 'u' };
            foreach (var item in vow)
            {
                if (a == item)
                {
                    result = "Vowel";
                    break;
                }
            }
            if (result == "Vowel")
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Constant");
            }

        }
    }
}
