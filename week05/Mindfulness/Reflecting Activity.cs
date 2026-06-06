using System;
/*
Class: ReflectingActivity
Attributes:
* prompts : List<string>
* questions : List<string>

Behaviors:
* Run() : void
*/
public class ReflectingActivity : Activity
{
	private List<string> _prompts;
	private List<string> _questions;
	
	public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
	{
		_prompts = [
			"Think of a time when you stood up for someone else.",
			"Think of a time when you did something really difficult.",
			"Think of a time when you helped someone in need.",
			"Think of a time when you did something truly selfless."
		];
		_questions = [
			"Why was this experience meaningful to you?",
			"Have you ever done anything like this before?",
			"How did you get started?",
			"How did you feel when it was complete?",
			"What made this time different than other times when you were not as successful?",
			"What is your favorite thing about this experience?",
			"What could you learn from this experience that applies to other situations?",
			"What did you learn about yourself through this experience?",
			"How can you keep this experience in mind in the future?"
		];
	}
	
	public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
	{
		_prompts = prompts;
		_questions = questions;
	}
	public void Run() 
	{
		base.DisplayStartingMessage();
		Console.Clear();
		DateTime startTime = DateTime.Now;
		DateTime endTime = startTime.AddSeconds(base._duration);
		Console.WriteLine(GetRandomPrompt());
		while (DateTime.Now < endTime) {
			Console.WriteLine(GetRandomQuestion());
			base.ShowSpinner(5);
		}
		Console.Clear();
		base.DisplayEndingMessage();
	}
	public string GetRandomPrompt() {
		Random randomGenerator = new Random();
		int randomIndex = randomGenerator.Next(0, _prompts.Count);
		return _prompts[randomIndex];
	}
	public string GetRandomQuestion() {
		Random randomGenerator = new Random();
		int randomIndex = randomGenerator.Next(0, _questions.Count);
		return _questions[randomIndex];
	}
	public void DisplayPrompts() {
		foreach (string prompt in _prompts) {
			Console.WriteLine(prompt);
		}
	}
	public void DisplayQuestions() {
		foreach (string question in _questions) {
			Console.WriteLine(question);
		}
	}
}
