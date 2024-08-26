/*
* Action Delegates => void return
* Func Delegates => when we have to return something
Genric Delegates:
Action<>: The Action<> generic delegate; points to a method that takes up to 16 parameters
        and return voids
Func<>: The generic Func<> delegate is used when we want to point to a method that returns a value 16 parameter and return a value
 */
namespace Chapter4{
    public class ActionExample{
        public static void ShowMessage(string message){Console.WriteLine(message);}
        public static void ShowMessageTwo(string val1, string val2){Console.WriteLine(val1+val2);}
        public static int Add(int val1, int val2, int val3)=>(val1+val2+val3);
        static void Main(string[] args)
        {
             Action<string> action = ShowMessage;
             // 16 parameters limit
             Action<string,string> action1=ShowMessageTwo;
            // First and Second parameters and Last return type
            Func<int,int,int,int> action2=Add;
            int sum = action2(1,2,3);

             action("this is a custom message");
             action1("Hello ","World");
        }

       
    }
}