/* used json to load and save journal */

using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string> {
            "Today’s brightest moment",
            "Unexpected blessing",
            "Kindness received",
            "Kindness given",
            "Gratitude list",
            "Hand of the Lord",
            "Scripture connection",
            "Prayer reflection",
            "Christlike attribute",
            "Promptings felt",
            "Mercy moment",
            "Covenant connection",
            "Strongest emotion",
            "Emotional resilience",
            "Self-compassion",
            "Personal victory",
            "Do-over moment",
            "Better choice",
            "Tomorrow’s intention",
            "Skill growth",
            "Most interesting person",
            "Meaningful conversation",
            "Someone I served",
            "Someone who inspired me",
            "Who I’m becoming",
            "Faith strengthened",
            "Repentance moment",
            "Joy in discipleship",
            "Future blessing",
            "Dream God planted",
            "Symbol of today",
            "Tender mercy memory"
        };
        List<Entry> entries = new List<Entry>();
        Journal journal = new Journal();
        int numberChoice = 0;
        
        do {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Add Journal Entry");
            Console.WriteLine("2. View Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine() ?? "";
            numberChoice = int.Parse(userInput);
            
            switch (numberChoice)
            {
                case 1:
                    Random randomGenerator = new Random();
                    int index = randomGenerator.Next(0, prompts.Count);
                    string prompt = prompts[index];
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine() ?? "";
                    
                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._response = response;
                    entry._date = DateTime.Now;
                    journal._entries.Add(entry);
                    break;
                
                case 2:
                    journal.Display();
                    break;
                
                case 3:
                    Console.Write("What file do you want to save to? ");
                    string saveFilename = Console.ReadLine() ?? "";
                    journal.Save(saveFilename);
                    Console.WriteLine("Saved Journal File: ");
                    journal.Display();
                    break;
                
                case 4:
                    Console.Write("What file do you want to load from? ");
                    string loadFilename = Console.ReadLine() ?? "";
                    journal.Load(loadFilename);
                    Console.WriteLine("Loaded Journal File: ");
                    journal.Display();
                    break;
                
                case 5:
                    Console.Write("See you next time.");
                    break;
                
                default:
                    break;
            };
        } while (numberChoice != 5);
    }
}