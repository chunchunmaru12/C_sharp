using System;
namespace Chapter4{
    class Test1{
        static void Main(string[] args)
        {
            int[] numbers= {1,2,3,4,5,6,7,8,9,10,11,12,13};
            var result = numbers.Where(n=> n>5).OrderByDescending(n=> n);
            Console.WriteLine("Result");
            foreach(var number in result){
                Console.WriteLine(number);
            }
        }
    }
}