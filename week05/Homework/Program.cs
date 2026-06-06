using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John Doe", "General");
        Console.WriteLine(assignment.GetSummary());
        
        MathAssignment mathAssignment = new MathAssignment("John Doe", "Mathematics", "Section 4.4", "Problems 9-10");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        
        WritingAssignment writingAssignment = new WritingAssignment("John Doe", "Writing", "All About the Program");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}