using System.Xml;

namespace Chapter4{
    class Example4{
        static void Main(string[] args)
        {
            List<string> names = new List<string>{"Ram","Shaym","Amit","Gita","hari"};
            var result = from name in names orderby name select name;
                        var resultTwo= names.OrderBy(name=>name);
            foreach (var item in result)
            {   
                Console.WriteLine(item);
                
            }
        }
    }
}