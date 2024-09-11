/*
* Join Operator:
    -> Join operator
       -> operates on two collections(inner and outer collections)
       -> same as SQL inner join
       -> returns a new collection that satisfies the specific condition
    List<string> str1 = new List<string>(){"one", "two", "three"};
    List<string> str2 = new List<string>(){"one", "two", "three"};
    var joinOperator = str1.Joinn(str2,s1=>s1,s2=>s2,(s1,s2)=>s2);
    *Concat
    *Union 
*/
using System;
namespace Chapter4{
    class Advance1{
        static void Main(string[] args)
        {
            List<string> names = new List<string>(){"Hello","meow","Negga"};
            List<string> namesTwo = new List<string>(){"Hello","World","Howl","Moving"};
            //inner join
            var joinResult = names.Join(namesTwo,str1=>str1,str2=>str2,(str1,str2)=>str2);
            //distinct results
            var resultUnion = names.Union(namesTwo);
            //Appends two sequences:
            var resultConcat = names.Concat(namesTwo);
            Console.Write("Join: ");
            foreach(var name in joinResult){
                Console.WriteLine(name);
            }
            Console.Write("Union: ");
            foreach(var name in resultUnion){
                Console.WriteLine(name);
            }
            Console.Write("Concat: ");
             foreach(var name in resultConcat){ 
                Console.WriteLine(name);
            }
        }
    }
}