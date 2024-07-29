using System;
namespace Interface
{
    public interface IShape
    {
        double GetArea();
        double GetPerimeter();
    }
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;

        }
        public double GetArea() => (Math.PI * Radius * Radius);
        public double GetPerimeter() => (2 * Math.PI * Radius);
    }
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height) { 
            Width = width;
            Height = height;
        }
        public double GetArea() => (Width*Height);
        public double GetPerimeter() => (2*(Width+Height));

    }
    public class Interface
    {
        static void Main(string[] args)
        {

            Rectangle rec = new Rectangle(5,6);
            Console.WriteLine("The Perimeter is "+rec.GetPerimeter());
            Console.WriteLine("The area is " + rec.GetArea());

            Circle circ = new Circle(5);
            Console.WriteLine("The perimeter is "+circ.GetPerimeter());
            Console.WriteLine("The area is " + circ.GetArea());


        }
    }

}