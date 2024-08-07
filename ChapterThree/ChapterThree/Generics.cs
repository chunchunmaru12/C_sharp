using System;
/*
* Generics:
-> in c # provides a way to define classes, interfaces, and methods with placeholders
for types they operate on
-> Enable code reusability and flexibility while maintaining strong type check 
* Generic Class:
    The generic class can be defined by putting <T> sign after the class name. "T" is not mandatory but is used in most of the languages

        public class TestClass<T>{} 
    A class that can operate on different types specified at runtime
*/
namespace ChapterThree{
    public class Entity<T>{
        private T content;
        public void SetContent(T value) { content = value; }
        public T GetContent() { return content; }
    }
    //Generic methods
    public class Utility{
        public static void Print<T>(T value) {
            Console.WriteLine(value);
        }
    }
    public class Generics{
        static void Main(string[] args)
        {
            Entity<int> entity= new Entity<int>();
            entity.SetContent(5);
            Console.WriteLine(entity.GetContent());
            Entity<string> entityString= new Entity<string>();
            entityString.SetContent("meow");
            Console.WriteLine(entityString.GetContent());
            // method 
            Utility.Print(42);
            Utility.Print(3.142);
            Utility.Print("Hello");
        }
    }
}

