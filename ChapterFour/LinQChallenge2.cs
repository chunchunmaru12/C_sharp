
namespace Chapter4
{
    class Test2
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>{"apple", "orange", "banana", "umbrella", "grape", "elephant"};
            var result = words.Where(w => "aeiouAEIOU".Contains((w[0])));
            // var res= words.Where(w=>w.StartsWith("a")||w.StartsWith("e")||w.StartsWith("i") || w.StartsWith("o")|| w.StartsWith("u"));
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}
