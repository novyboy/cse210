//exceeding requirements: added counter for activities along with a overall activity timer

using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        int breathingActivityCount = 0;
        int reflectingActivityCount = 0;
        int listingActivityCount = 0;
        DateTime startTime = DateTime.Now;
        
        do {
            Console.WriteLine("Menu Options:");
            Console.WriteLine($"   1. Start breathing activity (completed {breathingActivityCount} times)");
            Console.WriteLine($"   2. Start reflecting activity (completed {reflectingActivityCount} times)");
            Console.WriteLine($"   3. Start listing activity (completed {listingActivityCount} times)");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine() ?? "0";
            int menuNumber = int.Parse(userInput);
            
            if (menuNumber == 1) {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                breathingActivityCount++;
            }
            if (menuNumber == 2) {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                reflectingActivityCount++;
            }
            if (menuNumber == 3) {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                listingActivityCount++;
            }
        } while (int.Parse(userInput) != 4);
        Console.WriteLine("You have completed:");
        Console.WriteLine($"{breathingActivityCount} Breathing Activities");
        Console.WriteLine($"{reflectingActivityCount} Reflecting Activities");
        Console.WriteLine($"{listingActivityCount} Listing Activities");
        Console.WriteLine($"In {DateTime.Now - startTime}");
    }
}