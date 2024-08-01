/*
Operator Overloading:
        -> The concept of function overloading can be applied to operator as well
        -> Operator overloading gives the ability to use same operator to do various operations
        -> It provides additional capabilities to C# operators
           when they are applied to user defined data types
        -> It enables to make user defined implementations of various operations where one of both of the operands are of user defined 
           class
Syntax:
access specifier  className  operator Operator_symbol (parameters)
{
     Code
}

Various operator available for overloading
1. Unary Operators: +,-,!,~,++,--
2. Binary Operators: +,-,*,/,%
3. Comparison operators: ==, !=
4. Conditional operators: &&, ||
5. Assignment Operator: +=, -=, *=, /=, %=,=
*/
using System;
namespace ChapterThree
{
   //unary operators overload
   class Complex
   {
      private int x;
      private int y;
      public Complex() { }
      public Complex(int i, int j)
      {
         x = i;
         y = j;
      }
      public void ShowXY()
      {
         Console.WriteLine($"x:{x} & y:{y}");
      }
      /* public static Complex operator -(Complex c){
          Complex temp = new Complex();
          temp.x=-c.x;
          temp.y=-c.y;
          return temp;
       }*/
      public static Complex operator ++(Complex c)
      {
         Complex temp = new Complex();
         temp.x = c.x + 10;
         temp.y = c.y + 10;
         return temp;
      }
   }
   class OperatorOverloading
   {
      static void Main(string[] args)
      {
         Complex c1 = new Complex(10, 20);
         c1.ShowXY();
         Complex c2 = new Complex();
         c2.ShowXY();
         //c2=-c1;
         c2=++c1;
         c2.ShowXY();
      }
   }
}
