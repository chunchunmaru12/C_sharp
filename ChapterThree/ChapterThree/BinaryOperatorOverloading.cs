using System;
namespace ChapterThree{
    //
    class ComplexNumber{
        private int x;
        private int y;
        public ComplexNumber(){}
        public ComplexNumber(int i, int j){
            x=i;
            y=j;
        }
        public void ShowXY(){
            Console.WriteLine($"x:{x} and y:{y}");
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2){
            ComplexNumber temp= new ComplexNumber();
            temp.x=c1.x+c2.x;
            temp.y=c1.y+c2.y;
            return temp;
        }
    }
    class BinaryOperatorOverloading
    {
        static void Main(string[] args)
        {
            ComplexNumber c1=new ComplexNumber(10,20);
            c1.ShowXY();
            ComplexNumber c2=new ComplexNumber(20,30);
            c2.ShowXY();
            ComplexNumber c3=(c1+c2);
            c3.ShowXY();

        }
        
    }
}
/*
public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
{
    return c1.x == c2.x && c1.y == c2.y;
}

public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
{
    return !(c1 == c2);
}

public static bool operator >(ComplexNumber c1, ComplexNumber c2)
{
    return c1.x > c2.x && c1.y > c2.y;
}

public static bool operator <(ComplexNumber c1, ComplexNumber c2)
{
    return c1.x < c2.x && c1.y < c2.y;
}

public static bool operator >=(ComplexNumber c1, ComplexNumber c2)
{
    return c1.x >= c2.x && c1.y >= c2.y;
}

public static bool operator <=(ComplexNumber c1, ComplexNumber c2)
{
    return c1.x <= c2.x && c1.y <= c2.y;
}*/