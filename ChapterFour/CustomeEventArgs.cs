using System;
namespace Chapter4{
public class CustomEventArgs : EventArgs
{
    public string Message { get; }

    public CustomEventArgs(string message)
    {
        Message = message;
    }
}
public class Publisher
{
    public delegate void CustomEventHandler(object sender, CustomEventArgs e);
    public event CustomEventHandler? CustomEvent;
    public void DoSomething()
    {
        OnCustomEvent(new CustomEventArgs("Event Triggered"));
    }
    protected virtual void OnCustomEvent(CustomEventArgs e)
    {
        CustomEvent?.Invoke(this, e);
    }    
   
}
public class Subscriber
{
    public void OnCustomEvent(object sender, CustomEventArgs e)
    {
        Console.WriteLine("Event handled: " + e.Message);
    }
}
public class CustomeEventArgs
{
    static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();
        publisher.CustomEvent += subscriber.OnCustomEvent; 
        publisher.DoSomething();
    }
}

}
