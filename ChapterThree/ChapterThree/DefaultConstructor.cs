using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * note:
 * Constructors: Special Method of a class that is automatically called when an instance of a class is created.
 * Used to initialize the objects data member and perform any setup steps required when the  object is first created
 * key difference between method and constructor
 * A constructor doesnot have a return type
 * the name of constructor must be the same name as the class
 * Unlike methods constructors are not considered members of a class
 * Automatically called when new instance is created
 *      All classess are constructor whether you define one or not because 
 *      c# automatically provides default  constructor that initialize all member variables to zero
 *      However once you define your own constructor the default is ignored
 * 
 */
namespace ChapterThree
{
    class ConstructorOne
    {
        public ConstructorOne()
        {
            Console.WriteLine("Default constructor called.");
        }
        public ConstructorOne(string name) { Console.WriteLine(name); }
        public ConstructorOne(int id):this("md") { Console.WriteLine(id); }
        
    }
 
    class DefaultConstructor
    {
       
        static void Main(string[] args)
        {
            ConstructorOne cons = new ConstructorOne();
            ConstructorOne cons2 = new ConstructorOne(1);
        }
    }
}
