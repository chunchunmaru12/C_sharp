using System;
namespace ChapterThree{
    /*
    Abstract class:
     -> A Class that cannot be instantiated instead on its concrete sub classes can be intantiated
     -> It is designed to be a base class
     Abstract member:
     -> An abstract method is a method without a body
     -> the implementation of an abstract method is done by a derived class
     -> When the derived class inherits the abstract method it must override the abstract method 
    */
    public abstract class Shapes{
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public void Display(){
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}");
        }
    }
    public class CircleShape : Shapes{
        public double Radius { get; set; }
        public CircleShape(double radius){
            Radius = radius;
        }
        public override double GetArea()=>(Math.PI*Radius*Radius);
        public override double GetPerimeter()=>(Math.PI*2*Radius);
    }
    public class RectangleShape : Shapes{
        public double Length{ get;set; }
        public double Breadth{ get;set; }
        public RectangleShape(double length,double breadth){
            Length=length;
            Breadth=breadth;
        }
        public override double GetArea()=>(Length*Breadth);
        public override double GetPerimeter()=>(2*(Length+Breadth));
    }
    class AbstractExample{
       static void Main(string[] args)
       {
    
         Console.WriteLine("Circle: ");
         Shapes cir=new CircleShape(7);
         cir.Display(); 
         Console.WriteLine("Rectangle:");
         Shapes rect = new RectangleShape(4,5);
         rect.Display();
       } 
    }
}