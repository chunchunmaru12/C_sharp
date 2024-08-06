namespace ChapterThree{
    public class Parent{
        public virtual void ParentMethod(){
            Console.WriteLine("Parent method called inside parent class");
        }
    }
    public class Child: Parent{
        public override void ParentMethod(){
            base.ParentMethod();
            Console.WriteLine("Parent method called inside Child class");
        }
    }
    public class BaseMethod{
        static void Main(string[] args)
        {
            Child child = new Child();
            child.ParentMethod();
        }
    }
}