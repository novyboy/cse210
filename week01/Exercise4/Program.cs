using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = 0;
        do {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine() ?? "0";
            number = int.Parse(userInput);
            if (number != 0) numbers.Add(number);
        } while (number != 0);
        
        numbers.Sort();
        
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();
        int minPosNum = numbers.Where(i => i > 0).DefaultIfEmpty(0).Min();
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {minPosNum}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int sortedNumber in numbers)
        {
            Console.WriteLine(sortedNumber);
        }
    }
}