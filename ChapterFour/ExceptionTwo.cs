namespace Chapter4{
    public class ExceptionTwo{
        static void Main(string[] args)
        {
            try{
                int numerator=10;
                int denominator=0;
                //int denominator=10;
                int result= numerator/denominator;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException ex){
                Console.WriteLine("Error: " + ex.Message);
            }
            catch(Exception ex){
                Console.WriteLine( ex.Message);
            }finally{
                Console.WriteLine("I am done!");
            }
        }
    }
}