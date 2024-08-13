using System;
namespace ChapterOne{
    class GradeCalculator{
          static void Main()
    {
        try
        {
            Console.Write("Enter the score (0-100): ");
            int score = int.Parse(Console.ReadLine());

            string grade;

            // Determine the letter grade based on the score
            if (score >= 90 && score <= 100)
            {
                grade = "A";
            }
            else if (score >= 80 && score <= 89)
            {
                grade = "B";
            }
            else if (score >= 70 && score <= 79)
            {
                grade = "C";
            }
            else if (score >= 60 && score <= 69)
            {
                grade = "D";
            }
            else if (score < 60 && score >= 0)
            {
                grade = "F";
            }
            else
            {
                Console.WriteLine("Invalid score. Please enter a score between 0 and 100.");
                return;
            }

            Console.WriteLine("The corresponding letter grade is: " + grade);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer score.");
        }
}}}