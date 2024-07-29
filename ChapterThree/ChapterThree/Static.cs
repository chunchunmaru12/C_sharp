using System;
/*
-> A c# static class cannot be initiated 
-> The sole purpose of the class is to provide
    blueprints to its inherited classes
-> Class is created using "static" keyword
-> You cannnot create the object of static class
-> A static class can contain static members only
*/
namespace ChapterThree{
    static class Person{
        public static string name;
        public static int age;
        static Person(){
            name = "md";
            age = 23;
        }
        public static void Display(){
            Console.WriteLine($"name: {name} age: {age}");
        }
    }
    class Static{
        static void Main(string[] args)
        {
            Person.Display();
        }
    }
}