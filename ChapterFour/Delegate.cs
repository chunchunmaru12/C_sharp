namespace Chapter4{
    delegate int NumberChanger(int n);
    class TestDelegate{
        static int num=10;
        public static int AddNum(int p){
            num += p;
            return num;
        }
        public static int MulNum(int q){
            num*=q;
            return num;
        }
        public static int getNum(){
            return num;
        }
        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MulNum);
            nc1(25);
            Console.WriteLine($"Value of numer {getNum()}");
            nc2(5);
            Console.WriteLine($"Value of numer {getNum()}"); // ;
            }
    }
}