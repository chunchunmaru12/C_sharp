namespace Chapter4{
    class MethodCollection{
        //void return
        public static void PrintText(){
            Console.WriteLine("Action Delegate: Print Message");
        }
        public static void PrintNumber(int a, int b){
            for(int i=a;i<=b;i++){
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        //value return
        public static int Add(int a, int b){
            return a+b;
        }
        public static string ShowFullName(string FirstName, string LastName){
            return string.Format("Your full nme is {0} {1}",FirstName,LastName);
        }
        public static int RandomNumber(){
            Random r = new Random();
            return r.Next();
        }
       
    }
    public class GenericDelegateExample{
       static void Main(string[] args)
       {
        Action printText = new Action(MethodCollection.PrintText);
        Action<int,int> printNumber = new Action<int,int>(MethodCollection.PrintNumber);
        Func<int,int,int> add = new Func<int,int,int>(MethodCollection.Add);
        Func<string,string,string> Fullname = new Func<string,string,string>(MethodCollection.ShowFullName);
        Func<int> random= new Func<int>(MethodCollection.RandomNumber);
        printText();
        printNumber(10,20);
        Console.WriteLine(add(20,30));
        Console.WriteLine(Fullname("Md","Noor"));
        Console.WriteLine(random());
       }
    }
}