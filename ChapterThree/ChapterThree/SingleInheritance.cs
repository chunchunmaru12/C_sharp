using System;
namespace ChapterThree{
    public class Animal{
        public  void Eat(){
            Console.WriteLine("Eating");
        }

    }
    public class Dog:Animal{
        public void Bark(){
            Console.WriteLine("Barking");
        }
    }
    public class SingleInheritance{
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Bark();
        }
    }
}