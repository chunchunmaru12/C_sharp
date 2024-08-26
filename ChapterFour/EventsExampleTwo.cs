namespace Chapter4{
    public delegate void ClickEventHandler(object sender, EventArgs e);
    public class Button{
        public event ClickEventHandler? Click;
        public void OnClick(){
            Console.WriteLine("Button has been clicked");
            if(Click!=null){
                Click(this, EventArgs.Empty);
            }
        }

    }
    public class EventsExampleTwo{
        static void Main(string[] args)
        {
            Button button = new Button();
            button.Click += Button_Click;
            button.OnClick();

            static void Button_Click(object sender, EventArgs e)
            {
                Console.WriteLine("Button click event handler");
                Console.ReadKey();
            }
        }
    }
}