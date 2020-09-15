using System;
using static System.Console;
class StudentGradeDemo
{
    static void Main()
    {
        ReportCard.StudentInfo();
    }
}
class ReportCard
{
    public static string name;
    public static int midGrade;
    public static int finalGrade;
    public static int avg;
    public static char letterGrade;

    public static void StudentInfo()
    {
        Write("Enter name: ");
        name = ReadLine();
        Write("Enter midterm grade: ");
        midGrade = Convert.ToInt32(ReadLine());
        Write("Enter final grade: ");
        finalGrade = Convert.ToInt32(ReadLine());

        if (midGrade < 0 || midGrade > 100 || finalGrade < 0 || finalGrade > 100)
        {
            throw new ArgumentException();
        }

        avg = (midGrade + finalGrade) / 2;
        if (avg >= 90 && avg <= 100)
        {
            letterGrade = 'A';
        }
        else if (avg >= 80 && avg < 90)
        {
            letterGrade = 'B';
        }
        else if (avg >= 70 && avg < 80)
        {
            letterGrade = 'C';
        }
        else if (avg >= 60 && avg < 70)
        {
            letterGrade = 'D';
        }
        else if (avg < 60)
        {
            letterGrade = 'F';
        }
        else
        {
            WriteLine("Invalid input(s) entered...");
            letterGrade = '!';
        }
        Write("Final letter grade received: ");
        WriteLine(letterGrade);
    }
}
