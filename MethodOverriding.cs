using System;
namespace LabTwo{
class Animals
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animals makes a sound");
    }
}

class Dogs : Animals
{
    public override void MakeSound()
    {
        Console.WriteLine("The dogs barks");
    }
}

class Cat : Animals
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animals animals = new Animals();
        animals.MakeSound();  // Output: The animals makes a sound

        Dogs dog = new Dogs();
        dog.MakeSound();     // Output: The dogs barks

        Cat cat = new Cat();
        cat.MakeSound();     // Output: The cat meows
    }
}
}