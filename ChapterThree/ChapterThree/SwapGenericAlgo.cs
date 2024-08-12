namespace ChapterThree{

/* Generic Array for stack
    class Test<T>{
        T[] t = new T[5];
        int count = 0;
        public void addItem(T item){
            if(count<5){
                t[count] = item;
                count++; 
            }else{
                Console.WriteLine("Overflow Exist");
            }
        }
        public void displayItem(){
            for(int i=0; i<count; i++){
                Console.WriteLine($"Item at index {i} is {t[i]}");
            }
        }
        class GenericExample{
            static void Main(string[] args)
            {
                Test<int> obj = new Test<int>();
                obj.addItem(1);
                obj.addItem(2);
                obj.addItem(3);
                obj.addItem(4);
                obj.displayItem();
            }
        }
    }
*/
public class SwapGenericAlgo
{
    public void Swap<T>(ref T a, ref T b)
    {
        T temp;
        temp = a;
        a = b;
        b = temp;
    }
    static void Main(string[] args)
    {
        int a=40, b=60;
        Console.WriteLine($"Before swap: {a}, {b}");
        SwapGenericAlgo algo = new SwapGenericAlgo();
        algo.Swap<int>(ref a, ref b);
        Console.WriteLine($"After swap: {a}, {b}");

    }
    }
}

