using System;
namespace ChapterThree{
     class Rectangle{
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int width, int height) { Width = width; Height=height; }
        public static bool operator ==(Rectangle r1, Rectangle r2) { return r1.Width == r2.Width && r1.Height == r2.Height;} 
        public static bool operator !=(Rectangle r1, Rectangle r2){ return !(r1==r2);}
     }
    class ComparisonOverloading{
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(10,20);
            Rectangle rect2 = new Rectangle(10,20);
            Rectangle rect3 = new Rectangle(15,25);
            Console.WriteLine(rect1==rect2);
            Console.WriteLine(rect1!=rect2); //;
        }

    }
}
