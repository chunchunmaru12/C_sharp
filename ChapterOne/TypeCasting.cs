using System;

namespace ChapterOne
{
     class TypeCasting
    {
        static void Main(string[] args)
        {   //implicit casting
            int myInt = 9;
            double myDouble = myInt;//automatically cast int to double

            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);

            //explicit casting
            double data = 9.78;
            int convertedData = (int)data;
            Console.WriteLine(data);
            Console.WriteLine(convertedData);
            //String to int parse
            string num="23";
            Console.WriteLine(int.Parse(num));
        }
    }
}
