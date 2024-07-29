using System;

namespace ChapterOne
{
     class DataType
    {
        static void Main(string[] args)
        {
            int myNum = 5;
            double myDoubleNum = 5.9999D;
            char myChar = 'A';
            bool myBool = false;
            string myString = "Za Warudo!";
            long longNum=140000000000000L;
            float floatNum = 5.69F;
            //scientific notation
            float f1=45e3F;
            double d1=12E4D;
                
            //constants 
            const int num=20;
            Console.WriteLine(myNum);
        }
    }
}
