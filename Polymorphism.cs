// Lab 4. Concept of Polymorphism 
// Lab 5. concept of default, parameterized or private constructor
// Lab 6. concept of multi level and multiple inheritance
using System;
namespace LabTwo{
    public class Polymorphism{
        //without parameter
        public  void Add(){
            Console.WriteLine("This is funtions Without Parameter and sum is "+(10+20+30));
        }
         //with only one parameter
        public void Add(int a){
            Console.WriteLine("This is FunctionWithParameter and sum with 10 is "+(a+10));
        }
         //with two parameter
        public void Add(int a, int b){
            Console.WriteLine("This is FunctionWithTwoParameter and sum is "+(a+b));
        }
         //with three parameter
        public void Add(int  a, int b, int c){
            Console.WriteLine("This is FunctionWithThreeParameter and sum is "+(a+b+c));
        }
        
        static void Main(string[] args)
        {   Console.WriteLine("Enter the three number : ");
            int numOne= int.Parse(Console.ReadLine());
            int numTwo= int.Parse(Console.ReadLine());
            int numThree= int.Parse(Console.ReadLine());
            Polymorphism obj = new Polymorphism();
            obj.Add();
            obj.Add(numOne);
            obj.Add(numOne,numTwo);
            obj.Add(numOne,numTwo,numThree);
        }
    }
}
