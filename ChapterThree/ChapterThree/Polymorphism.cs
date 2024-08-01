using System;
namespace ChapterThree{
    /*
    Polymorphism
        Poly -> means "many"    many forms
        Morph -> means "forms"
        -> It is a concept by which we can perform a single action in different ways
        Compile time              Runtime
        Method Overloading        Method Overriding
        Static binding            Dynamic binding(virtual function)
        Opertor overloading    

        Compile-time polymorphism
            -> Method overloading and operator overloading 
            -> It allows different methods or operators to have the same name but different parameters
        Method Overloading
            -> This is when you define multiple methods with the same name but different parameter lists within the same class
        Operator Overloading:
            -> Allos you to definecustom behaviour for operator (e.g +, -, *, /) for user defined classess 
        Method Overloading:
        i) Number of parameters
            Calculate(int,int)
            Calculate(int,int,int)  
        ii) Datatype of parameters
            Calculate(int,int)
            Calculate(int,float)
            Calculate(float, int)
            Calculate(float,float)

    */
    public class Polymorphism{
        public class MathOperations{
            public int Add(int a, int b)=>(a+b);
            public double Add(double a, double b)=> (a + b);
            public int Add(int a, int b, int c)=>(a+b+c);
        }
        static void Main(string[] args)
        {
            MathOperations mathObject = new MathOperations();
            Console.WriteLine(mathObject.Add(5,4));
            Console.WriteLine(mathObject.Add(5.123,4.452));
            Console.WriteLine(mathObject.Add(5,4,1));
        }
    }
}