using System;
namespace ChapterThree
{
    class ObjExample
    {
        static int Add(int a, int b)=> (a+b);
        int Subtract(int a, int b)=> (a-b);
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            ObjExample ob = new ObjExample();
            Console.WriteLine(ob.Subtract(1, 2));
        }
    }
}