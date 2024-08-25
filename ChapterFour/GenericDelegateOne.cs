namespace Chapter4{
    public delegate T Transformer<T>(T args);
    public class Util{
        public static void Transform<T>(T[] values, Transformer<T> transformer){
            for(int i=0; i<values.Length; i++){
                values[i] = transformer(values[i]);
            }
        }
    }
    public class Test{
        static int Square(int x)=>(x*x);
        static void Main(string[] args)
        {
            int[] values={1,2,3,4};
            Util.Transform(values,Square);
            foreach(int value in values){
                Console.WriteLine(value);
            }
        }
    }
}