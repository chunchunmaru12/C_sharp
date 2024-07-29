using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
note: 
    -> Destructor in c# are methods inside the class used to destroy instance of that class
    when they are no longer needed.
    -> The destructor is called implicitly by .NET framworks garbage collector and therefore
    -> Programmer has no control as wehn to invoke the distructor
    -> An instance variable or an object is eligibile for destruction when its no longer reacheable
*/
namespace ChapterThree
{
    public class DistructorExample{
        public DistructorExample(){
            Console.WriteLine("Constructor called");
        }
        ~DistructorExample(){
            Console.WriteLine("Destructor called");
        }
    }
    class Destructor
    {
        static void Main(string[] args)
        {
            DistructorExample example = new DistructorExample();
        }/*
        Important points:
        -> Unquie to the class i.e. there cannot be more than one destructor in a class
        -> No return type and exact name as the class.
        -> Distringuish apart from the constructor because of the "tidle" symbol prefixed to its name
        -> Deoesnot accept any parameters and modifiers
        -> Cannot be defined in structure. It is only used with classes
        -> Also called as Finalizer.
        */
    }
}
