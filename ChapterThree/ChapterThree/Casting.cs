using System;
namespace ChapterThree{
    /*notes:
    Upcasting and Downcasting
    -> Are concepts related to type casting in an inheritance hierarchy
    -> they allow you to conber objects from one type to another type in a class hierarchy
     * Upcasting 
        -> refers to converting desired class object to its base class tye
        -> this is safe operation because a derived class object is inheritly a base class object it can be treated as such 
    * Downcasting
        -> refers to converting base class object back to derived class object
        -> riskier operations because not all base class objects are instances of the derived class
        -> It refers explicit casting and should be used with caution
        * 'as' operator
            -> used to cast an object to a specific type
            -> if succesfully casted it returns the object cast to that type if not it returns null instead of throwing an exception
            Syntax: object as type;
    
     */
    public class Animale{
        public void Eat(){
            Console.WriteLine("eating....");
        }
    }
    public class dug:Animale{
        public void Run()
        {
            Console.WriteLine("Running");
        }
    }
    class Casting{
        static void Main(string[] args)
        {
            Animale dog = new dug();
         //upcasting    
         Animale animal = dog;
            animal.Eat();
           //downcasting
           if(dog is dug){
            Console.WriteLine("dog is object of dug");
           }else{
            Console.WriteLine("dog isnot object of dug");
           }
            dug dig = animal as dug;
            if (dig != null)
            {
                dig.Run();
                dig.Eat();
            }
        }
    }
}