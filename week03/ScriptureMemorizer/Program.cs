/* added re-try feature and check feature */

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi",11,22);
        
        Scripture scripture = new Scripture(reference, "And I answered him, saying: Yea, it is the love of God, which sheddeth itself abroad in the hearts of the children of men; wherefore, it is the most desirable above all things.");
        
        
        string userInput = "";
        do {
            int hiddenWords = 0;
            do {
                Console.Clear();
                if (userInput == "check") {
                    Console.WriteLine(scripture.GetOriginalText());
                }
                else {
                    scripture.HideRandomWords(hiddenWords);
                    Console.WriteLine(scripture.GetDisplayText());
                    hiddenWords++;
                }
                Console.Write("Press enter to continue, type 'check' to see the original scripture, or type 'quit' to finish: ");
                userInput = Console.ReadLine() ?? "";
            } while (!scripture.IsCompletelyHidden() && userInput != "quit");
            
            scripture.ShowAll();
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("Try again? (yes/no): ");
            userInput = Console.ReadLine() ?? "";
        } while (userInput == "yes");
    }
}