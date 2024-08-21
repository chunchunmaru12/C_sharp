using System;
//Notes
/*
1. All Delegate instances have multicast Capability
2. Delegate instances can reference not just single target method but also a list of target method
3. The + and +=operators combine delegate instances
3. The - and -= operators remove the right delegate operand from left delegate operand
*/
namespace Chapter4
{
    public delegate void MyDelegate(string message);

    public class Program
    {
        public static void Main()
        {
            MyDelegate myDelegate = null;
            myDelegate += Method1;
            myDelegate += Method2;
            myDelegate += Method3;

            myDelegate("Hello, world!");
        }

        public static void Method1(string message)
        {
            Console.WriteLine("Method 1: " + message);
        }

        public static void Method2(string message)
        {
            Console.WriteLine("Method 2: " + message);
        }

        public static void Method3(string message)
        {
            Console.WriteLine("Method 3: " + message);
        }
    }
}