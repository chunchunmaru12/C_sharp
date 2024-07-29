using System;
namespace ChapterThree{
    public interface Adventure{
        public abstract void Goal();
    }
    public interface Action:Adventure{
        public abstract void Basket();
    }
    public class Go:Rams,Action{
        public void Basket(){
            Console.WriteLine("Basket!");
        }
    }
    public class Rams: Adventure{

        public void Goal(){
            Console.WriteLine("You are walking");
        }
    }

    public class HybridInheritance{
        static void Main(string[] args)
        {
            Go obj= new Go();
            obj.Basket();
            obj.Goal();

        }
    }
}