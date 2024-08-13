using System;
namespace LabTwo
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Mammal : Animal
    {
        public void Sleep()
        {
            Console.WriteLine("Mammal is sleeping.");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    class MultiLevelInheritance
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();  
            dog.Sleep(); 
            dog.Bark();  

        }
    }
}