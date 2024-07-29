using System;
 

namespace ChapterOne
{
    class Array
    {
        static void Main(string[] args)
        {
            int[,] n1= { {1,2},{ 3, 4 } };
            int [,] n2= { {5, 6 },{7 , 8} };
            int[,] sum= new int[2,2];
            for (int i = 0; i < 2 ; i++) {
                for (int j = 0; j < 2; j++)
                {
                    sum[i,j]=n1[i,j]+n2[i,j];
                }
            }
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 2; j++) { 
                Console.Write(sum[i,j]+"  ");
                }
                Console.WriteLine("");
            }
        }
    }
}
