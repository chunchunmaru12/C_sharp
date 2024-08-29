namespace Chapter4{
    class AnonThree{
        public delegate void Process(int number);
        static void Main(string[] args)
        {

            List<int> number= new List<int>{1,2,3,4,5,6,6};
            //Anonymour method as a call back method
            ProcessNumbers(number,delegate(int number){Console.WriteLine("Number: " + number);});
        }
        public static void ProcessNumbers(List<int> number, Process process){
            foreach(var num in number){
                process(num);
            }
        }
    }
}