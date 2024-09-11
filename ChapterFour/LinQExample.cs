namespace Chapter4{
    class Example2{
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};
            //Query Syntax:
            var result = from num in numbers where (num%2==0) select num;
            //Method Syntax (lambda expression)
            var resultTwo= numbers.Where(n =>(n%2==0));
            Console.WriteLine("Even Numbers from Query:");
            foreach (var item in result)
            {   
                Console.WriteLine(item);  
            }
            Console.WriteLine("Even Numbers from Lambda:");
           foreach (var item in resultTwo){
            Console.WriteLine(item);
           }
        }
    }
}