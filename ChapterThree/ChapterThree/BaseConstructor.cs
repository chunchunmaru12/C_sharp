
namespace ChapterThree
{
    public class Base
    {
        public Base(int a, int b)
        {
            Console.WriteLine($"Base value of a:{a} and b:{b}");
        }
    }

    public class Derived: Base
    {
        public Derived(int a, int b) : base(a, b)
        {
             Console.WriteLine($"Derived value of a:{a} and b:{b}");
        }
    }
    public class BaseConstructor{
        static void Main(string[] args)
        {
            Derived obj = new Derived(10, 20);
        }
    }

}
