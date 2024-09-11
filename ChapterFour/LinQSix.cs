/*
List<string> names = {"a", "b", "c", "d", "e", "f"};
var result = names.Contains("RAM") || names.Contains("Shyam");

/ var result = names.Where(name=>{Console.WriteLine(name); return true;}).ToList();
*/

using System.Xml;

namespace Chapter4{
    class Example6{
        static void Main(string[] args)
        {
            int[] numbers= {1,2,3,4,5,6,7,8};
            var resultNum= numbers.Where((n,index)=>{Console.WriteLine($"number: {n} index: {index}");return n>4;}).ToList();
            foreach (var number in resultNum){
                Console.WriteLine(number);
            }
            List<string> names = new List<string>{"Ram","Shaym","Amit","Gita","hari"};
            var result = names.Where(name=>{Console.WriteLine(name); return true;}).ToList();
        }
    }
}