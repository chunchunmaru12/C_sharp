using System;
namespace ChapterThree{
    public class Animals{
        public void Eat(){
            Console.WriteLine("Eating");
        }
    }
    public class Mammal:Animal{
        public void Walk(){
            Console.WriteLine("walking");
        }
    }
    public class Dogs:Mammal{
        public void Bark(){
            Console.WriteLine("Barking");
        }
    }
    public class MultilevelInheritance{
        static void Main(string[] args)
        {
            Console.WriteLine("Dog class");
            Dogs meow= new Dogs();
            meow.Bark();
            meow.Walk();
            meow.Eat();
        }
    }
}