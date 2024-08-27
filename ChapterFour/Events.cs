/*
EVents(Publisher and subscriber)
Event are user actions such as key press, clicks, mouse movements, etc or some occurance such as system generated notification
Applications need to response to an events when they occur
For e.g. interrupt
Events are used for inter process communication
The class that sends or raise events are "Publisher"
The class that handles or recieves events are "Subscriber"

Key Concepts:
* Delegates -> Events are based on delegates
* Publisher and Subscriber
* Event Handlers return void and take two parameters
* First Parameter -> Source of event(publishing object)
* Second Parameter -> Object derived from EventArgs 
* The publisher determines when the event is raised and the subscriber determines what action is taken in response
* An event can have many subscribers
* If multiple subscriber, than event handler are invoked synchronously

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