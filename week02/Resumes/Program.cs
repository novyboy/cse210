using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Student Advisor";
        job1._company = "Story Xperiential";
        job1._startYear = 2022;
        job1._endYear = 2024;
        
        Job job2 = new Job();
        job2._jobTitle = "User Experience Designer";
        job2._company = "Story Xperiential";
        job2._startYear = 2025;
        job2._endYear = 2026;
        
        Resume resume = new Resume();
        resume._name = "Nova Sonomura";
        resume._jobs = [job1, job2];
        resume.Display();
    }
}