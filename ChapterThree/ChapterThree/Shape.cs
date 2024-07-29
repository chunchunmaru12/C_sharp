using System;

namespace ChapterThree
{
    class Circle
    {
        private float r, area;
        public float radius
        {
            get { return r; }
            set
            {
                r = value;
                area = (float)(3.141 * r * r);
            }
        }
        public float Area { get { return area; } }
    }

    class Shape
    {
        static void Main(string[] args)
        {
            Circle obj = new Circle();
            obj.radius = 7;
            Console.WriteLine("Radius: " + obj.radius);
            Console.WriteLine("Area: " + obj.Area);
        }
    }
}
