namespace Chapter4{
    class Test3{
        static void Main(string[] args)
        {   int max=0;
            string[] words ={"dog", "cat", "elephant", "cat", "hyppopotamus", "whale"};
            var result = words.OrderByDescending(w => w.Length).First();
            Console.WriteLine(result);
        }
    }
}