using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine() ?? "0";
        int grade = int.Parse(userInput);
        string letterGrade = "F";
        bool minus = true;
        bool plus = true;
        string sign = "";
        if (grade >= 90) {
            letterGrade = "A";
            plus = false;
        } else if (grade >= 80) {
            letterGrade = "B";
        } else if (grade >= 70) {
            letterGrade = "C";
        } else if (grade >= 60) {
            letterGrade = "D";
        } else {
            plus = false;
            minus = false;
        };
        int small = grade % 10;
        if (plus && small >= 7) {
            sign = "+";
        }
        else if (minus && small < 3) {
            sign = "-";
        }
        Console.WriteLine($"Your letter grade is an {letterGrade}{sign}");
    }
}