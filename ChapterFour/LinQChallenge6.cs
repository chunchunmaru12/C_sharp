namespace Chapter4{
    class Test6{
        static void Main(string[] args)
        {
            int[] scores = {85, 90 , 78, 92,88 ,95,67,95,91};
            var result = scores.OrderByDescending(s => s).Distinct().Take(3);
            foreach (var score in result){
                Console.WriteLine(score);
            }
        }
    }
}