namespace Chapter4
{
    public delegate double Algo(double x);
    public class MathLibrary
    {
        public static double Sum(List<double> data, Algo algo)
        {
            double sum = 0;
            foreach (double item in data)
            {
                sum += algo(item);
            }
            return sum;
        }

    }
    class DelegateChallenge
    {
        public static double Square(double x) => (x * x);

        public static void Main()
        {
            Algo algo = new Algo(Square);
            List<double> data = new List<double>() { 1, 2, 3, 4, 5 };
            Console.WriteLine(MathLibrary.Sum(data, algo));

        }
    }
}