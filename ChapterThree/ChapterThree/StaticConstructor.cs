using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThree
{
    class ConstructorThree
    {
        static ConstructorThree(){
            Console.WriteLine("Static constructor called !!!!!!!");
        }
        public ConstructorThree() {
            Console.WriteLine("default called!!!!!!");
        }
}
    internal class StaticConstructor
    {
        static void Main(string[] args)
        {
            ConstructorThree obj1 = new ConstructorThree();
            ConstructorThree obj2 = new ConstructorThree();
            ConstructorThree obj3 = new ConstructorThree();
            ConstructorThree obj4 = new ConstructorThree();

        }
        
    }
}
