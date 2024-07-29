using System;
namespace ChapterThree{
    public interface Cricket{
        public abstract void Goal();
    }
    public interface Basketball{
        public abstract void Basket();
    }
    public class Play:Cricket,Basketball{
        public void Goal(){
            Console.WriteLine("Goal!");
        }
        public void Basket(){
            Console.WriteLine("Basket!");
        }
    }
    public class MultipleInheritance{
        static void Main(string[] args)
        {
            Play obj= new Play();
            obj.Basket();
            obj.Goal();
            
        }
    }
}