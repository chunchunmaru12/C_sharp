namespace Chapter4{
    public class Program1{
        public delegate T Operation<T>(T a, T b);
        public static int Add(int a, int b)=>(a+b);

        public static string Concatenate(string a, string b)=>(a+b);
        public static double Multiply(double a, double b)=>(a*b);
        static void Main(string[] args)
        {
            //integer delegate
            Operation<int> operation = Add;
            int result = operation(5,10);
            Console.WriteLine("Add: "+result);
            //string delegate
            Operation<string> operation1 = Concatenate;
            string stringResult = operation1("Hello"," world!");
            Console.WriteLine("Concatenate: "+stringResult);
            //double delegate
            Operation<double> operation2 = Multiply;
            double mulResult = operation2(20,30);
            Console.WriteLine("Multiply: "+mulResult);

        }
    }
}