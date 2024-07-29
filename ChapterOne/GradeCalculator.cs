using System;
namespace ChapterOne{
    class GradeCalculator{
        static void Main(string[] args)
        {
            int score;
            Console.WriteLine("Enter your score");
            string s=Console.ReadLine();
            score=int.Parse(s);
            if(score<0 && score>100){
                Console.WriteLine("invalid score");
            }else if(score>90 && score<100){
                Console.WriteLine("you got A");
            }else if(score>80 && score<90){
                Console.WriteLine("you got B");
            }else if(score>70 && score<80){
                Console.WriteLine("you got C");
            }else if(score<60){
                Console.WriteLine("you got D");
            }else{
                Console.WriteLine("F");
            }
        }
    }
}