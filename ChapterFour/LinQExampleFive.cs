namespace Chapter4{
    class Example5{
        static void Main(string[] args)
        {
            string[] words= { "Cat", "Dog", "Elephant", "ant", "tiger"};
            var result = from word in words where words.Length>3 select word;
            var resultTwo=words.Count(word=>word.Length>3);
            Console.WriteLine("total number of word with length higher than 3 are :"+result.Count());
        }
    }
}