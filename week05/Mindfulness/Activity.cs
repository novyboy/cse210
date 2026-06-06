using System;
/*
Class: Activity
Attributes:
* name : string
* description : string
* duration : int

Behaviors:
* DisplayStartingMessage() : void
* DisplayEndingMessage() : void
* ShowSpinner(seconds : int) : void
* ShowCountdown(seconds : int) : void
*/
public class Activity
{
	private string _name;
	private string _description;
	protected int _duration;

	public Activity(string name, string description)
	{
		_name = name;
		_description = description;
	}
	public void DisplayStartingMessage() 
	{
		Console.WriteLine($"Welcome to the {_name} Activity");
		Console.WriteLine($"{_description}");
		Console.Write("How long, in seconds, would you like for your session? ");
		string userInput = Console.ReadLine() ?? "";
		_duration = int.Parse(userInput);
		Console.WriteLine($"Great! The activity will last {_duration} seconds.");
		Console.WriteLine("Get Ready...");
		ShowSpinner(5);
	}
	public void DisplayEndingMessage() 
	{
		Console.WriteLine($"Well done!");
		ShowSpinner(5);
		Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
		ShowSpinner(5);
	}
	public void ShowSpinner(int duration) 
	{
		for (int i = duration * 2; i > 0; i--) {
			if (i % 4 == 3) {
				Console.Write("\\");
			}
			else if (i % 4 == 2) {
				Console.Write("|");
			}
			else if (i % 4 == 1) {
				Console.Write("/");
			}
			else if (i % 4 == 0) {
				Console.Write("—");
			}
			Thread.Sleep(500);
			Console.Write("\b");
		}
	}
	public void ShowCountdown(int duration) 
	{
		for (int i = duration; i > 0; i--) {
			string text = $"{i}";
			Console.Write(text);
			Thread.Sleep(1000);
			Console.Write(new string('\b', text.Length));
		}
	}
}
