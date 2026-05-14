using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine() ?? "0";
        int grade = int.Parse(userInput);
        string letter = "F";
        bool minus = true;
        bool plus = true;
        string sign = "";
        if (grade >= 90) {
            letter = "A";
            plus = false;
        } else if (grade >= 80) {
            letter = "B";
        } else if (grade >= 70) {
            letter = "C";
        } else if (grade >= 60) {
            letter = "D";
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
        Console.WriteLine($"Your letter grade is an {letter}{sign}");
        if (grade >= 70) {
            Console.WriteLine($"Congratulations on passing your class!");
        } else {
            Console.WriteLine($"Do better next time.");
        }
    }
}