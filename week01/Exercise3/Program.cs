using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        
        Console.WriteLine("Guess the Magic Number!");
        
        int numberOfGuesses = 0;
        int guess = 0;
        do {
            Console.Write("Your guess is: ");
            string userInput = Console.ReadLine() ?? "";
            guess = int.Parse(userInput);
            if (guess < magicNumber) {
                Console.WriteLine("Higher");
            } else if(guess > magicNumber) {
                Console.WriteLine("Lower");
            }
            numberOfGuesses++;
        } while (guess != magicNumber);
        Console.WriteLine($"Correct! You guessed the magic number in {numberOfGuesses} guesses");
    }
}