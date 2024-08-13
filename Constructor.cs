namespace LabTwo
{
    public class ExampleClass
    {
        // Default constructor
        public ExampleClass()
        {
            Console.WriteLine("Default constructor called.");
        }
        // Parameterized constructor
        public ExampleClass(int value)
        {
            Console.WriteLine($"Parameterized constructor called with value: {value}");
        }

        // Private constructor
        private ExampleClass(string msg)
        {
            Console.WriteLine($"Private constructor called : message {msg}");
        }
        public static ExampleClass CreateInstance(string msg)
        {
            ExampleClass obj = new ExampleClass(msg);
            return obj;
        }
    }

    public class Constructor
    {
        public static void Main()
        {
            ExampleClass obj1 = new ExampleClass();
            ExampleClass obj2 = new ExampleClass(69);
            ExampleClass obj3 = ExampleClass.CreateInstance("hello");
        }
    }
}