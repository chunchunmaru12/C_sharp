using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThree
{
    class ConstructorFour
    {
        private ConstructorFour()
        {
            Console.WriteLine("Private constructor called");
        }
        public static ConstructorFour CreateInstance() { 
            ConstructorFour obj = new ConstructorFour();
            return obj;
        }
        public int add(int a , int b )=> (a+b);
    }

    class PrivateConstructor
    {
        static void Main(string[] args)
        {
           ConstructorFour obej= ConstructorFour.CreateInstance();
            // private constructor is used to restrict the instantiation of the class singleton pattern
            Console.Write(obej.add(2, 5));
        }
    }
}
