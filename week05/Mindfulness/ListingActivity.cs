using System;
/*
Class: ListingActivity
Attributes:
* count : int
* prompts : List<string>

Behaviors:
* GetRandomPrompt() : string
* GetListFromUser() : List<string>
*/
public class ListingActivity : Activity
{
	private int _count = 0;
	private List<string> _prompts;
	
	public ListingActivity() : base("Listing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
	{
		_prompts = [
			"Who are people that you appreciate?",
			"What are personal strengths of yours?",
			"Who are people that you have helped this week?",
			"When have you felt the Holy Ghost this month?",
			"Who are some of your personal heroes?"
		];
	}
	
	public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
	{
		_prompts = prompts;
	}
	public void Run() 
	{
		base.DisplayStartingMessage();
		Console.Clear();
		
		Console.WriteLine(GetRandomPrompt());
		Console.WriteLine("Think about the prompt... ");
		base.ShowCountdown(5);
		Console.WriteLine("List some thoughts...");
		_count = GetListFromUser().Count;
		
		Console.WriteLine($"You entered {_count} thoughts.");
		base.DisplayEndingMessage();
	}
	public string GetRandomPrompt() {
		Random randomGenerator = new Random();
		int randomIndex = randomGenerator.Next(0, _prompts.Count);
		return _prompts[randomIndex];
	}
	public List<string> GetListFromUser() {
		List<string> list = new List<string>();
		
		DateTime startTime = DateTime.Now;
		DateTime endTime = startTime.AddSeconds(base._duration);
		while (DateTime.Now < endTime) {
			string userInput = Console.ReadLine() ?? "";
			list.Add(userInput);
		}
		return list;
	}
}
