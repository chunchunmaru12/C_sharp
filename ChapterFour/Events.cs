/*
EVents(Publisher and subscriber)
Event are user actions such as key press, clicks, mouse movements, etc or some occurance such as system generated notification
Applications need to response to an events when they occur
For e.g. interrupt
Events are used for inter process communication
The class that sends or raise events are "Publisher"
THe class that handles or recieves events are "Subscriber"
*/
namespace Chapter4{
    public delegate void DelEventHandler();
    public class Events{
        public static event DelEventHandler? add;
        static void USA(){
            Console.WriteLine("Country: USA");
        }
        static void Nepal(){
            Console.WriteLine("Country: Nepal");
        }
        static void Japan(){
            Console.WriteLine("Country: Japan");
        }
        static void Main(){
            add+=new DelEventHandler(USA);
            add+=Nepal;
            add+=Japan;
            add();
        }
    }
}