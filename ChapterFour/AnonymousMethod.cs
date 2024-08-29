/*
* Anonymous Method in C#
-> Is a method which doesnot contain any name
-> introduced in C# 2.0
-> used to create inline methods
-> this allows you to directly write a small block of code directly where delegate is expected without needing to create a separate method

Syntax:
An anonymous method is defined using the delegate keyword and the user can assign this method to a variable of the delegate type.
delegate(parameter_list){
    /code/
}
*/

using System;
namespace Chapter4{
    class Program3{
        public delegate void PrintMessage(string message);
        static void Main(string[] args)
        {
            PrintMessage print = delegate(string message){
                Console.WriteLine(message);
            };
            print("Hello world");
            
        }
    }
}