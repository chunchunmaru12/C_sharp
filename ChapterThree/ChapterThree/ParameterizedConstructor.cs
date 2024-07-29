using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThree
{
    class ConstructorTwo
    {

        public ConstructorTwo(string name,int age)
        {
            Console.WriteLine($"Your name is {name}  and you are {age} years old");
        }
    }
    class ParameterizedConstructor
    {
        static void Main(string[] args)
        {
            ConstructorTwo msg = new ConstructorTwo("Meow",2);
        }

    }
}
