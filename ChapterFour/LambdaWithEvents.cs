namespace Chapter4{
    public class EventPublisher{
        public event EventHandler? SomethingHappened;
        public void DoSomething(){
            Console.WriteLine("Doing something");
            SomethingHappened?.Invoke(this,EventArgs.Empty);
        }
    }
    class LambdaWithEvents{
        static void Main(string[] args)
        {
            EventPublisher eventPublisher = new EventPublisher();
            eventPublisher.SomethingHappened += (sender, e) =>{
                Console.WriteLine("Event handler called via lambda expression " );
            };
            eventPublisher.DoSomething();
        }

    }
}