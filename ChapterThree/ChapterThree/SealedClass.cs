/*
* Sealed Class and functions
    * Sealed Class
        -> Are used to restrict the inheritance feature of OOP
        -> "Sealed" modifier is used. -> Cannot be inherited 
    * Sealed Method & Properties:
        ->"Sealed" modifier can also be used in methods and peroperties
        that overrides a virtual method or property in the base class.
*/
using System;
namespace ChapterThree{
    class X{
        protected virtual void F(){
            Console.WriteLine("X.F");
        }
        protected virtual void F2(){
            Console.WriteLine("X.F2");
        }
    }
    class Y:X{
        sealed protected override void F(){
            Console.WriteLine("Y.F");
        }
        protected override void F2(){
            Console.WriteLine("Y.F2");
        }
    }
    class Z:Y{
    /*   //error
        protected override void F(){
            Console.WriteLine("Z.F");
        }
    */
        protected override void F2(){
            Console.WriteLine("Z.F2");
        }
    }
    class SealedClass{
        static void Main(string[] args)
        {
            
        }
    }
}