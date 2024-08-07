/*
* Collections:
    * Dictionary:
        -> A collection type that represents a collection type that represents a collection key value pair
        -> It is a part of System.Collections.Generic namespace
        -> Also known as maps or hash tables
        -> IT represents a data structure that allows you to access an element based on a key
        *Syntax: Dictionary <Tkey, Tvalue>
*/
using System.Collections.Generic;
namespace ChapterThree{
    public class Collection{
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>(5);
            d.Add(1,"a");
            d.Add(2,"b");
            d.Add(3,"c");
            d.Add(4,"d");
            d.Add(5,"e");
            d.Add(6,"f");
            for(int i=1; i<=d.Count; i++){
                Console.WriteLine(d[i]);
            }

        }
    }
}