using System;
namespace Chapter4{
    public delegate void CallbackDelegate(string message);

    class CallbackClass{
       
        public static void LogMessage(CallbackDelegate callback){
            Console.WriteLine("Hello from log");
            // DisplayMessageOne() or DisplayMessageTwo() will be called
             callback("From callback delegate");
        }
    }

public class DelegateCallback
{
    public static void DisplayMessageOne(string message)
    {
        Console.WriteLine("From One"+message);
    }
    public static void DisplayMessageTwo(string message){
        Console.WriteLine("From Two"+message);
    }
     public static void Main()
    {
        //Passing DisplayMessageOne aas parameter to LogMessage method and LogMessage method will then call DisplayMessageOne
        CallbackClass.LogMessage(DisplayMessageOne);
        CallbackClass.LogMessage(DisplayMessageTwo);
        CallbackDelegate callback = DisplayMessageOne;
        callback("Hello, World!");
    }
}
}
