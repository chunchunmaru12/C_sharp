using System;
namespace ChapterThree{
    public class Man{
        public void Eat(string food){
            Console.WriteLine("You are eating "+food);
        }
    }
    public class Ram:Man{
        public void Walk(){
            Console.WriteLine("You are walking");
        }
    }
    public class Ramesh:Man{
        public void Read(){
            Console.WriteLine("You are reading");
        }
    }
    public class HierarchyInheritance{
        static void Main(string[] args)
        {
            Ramesh obj = new Ramesh();
            obj.Eat("banana");
            obj.Read();
            Ram obj1 = new Ram();
            obj1.Walk();
            obj1.Eat("mangoe");
        }

    }
}