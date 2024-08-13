using System;
namespace LabTwo
{
    interface IShape
    {
        void Draw();
    }

    interface IColor
    {
        void FillColor();
    }

    class Circle : IShape, IColor
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }

        public void FillColor()
        {
            Console.WriteLine("Filling color in a circle");
        }
    }

    class MultipleInheritance
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Draw();
            circle.FillColor();
        }
    }
}