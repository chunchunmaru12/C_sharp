namespace Chapter4{
    class Example3{
        static void Main(string[] args)
        {
            string[] names = {"Amar","Ram","Shyam","Amit","Gita"};
            //Query Syntax:
            var result = from name in names where name.Contains("A") select name;
            //Method Syntax (lambda expression)
            var resultTwo= names.Where(n =>n.Contains("A"));
            Console.WriteLine("names:");
            foreach (var item in result)
            {   
                Console.WriteLine(item);
                
            }
        }
    }
}