using System;
/*
Class: BreathingActivity
Attributes:

Behaviors:
* Run() : void
*/
public class BreathingActivity : Activity
{
	public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
	{
	}
	public BreathingActivity(string name, string description) : base(name, description)
	{
	}
	public void Run() 
	{
		base.DisplayStartingMessage();
		DateTime startTime = DateTime.Now;
		DateTime endTime = startTime.AddSeconds(base._duration);
		while (DateTime.Now < endTime) {
			Console.Clear();
			Console.WriteLine("Breathe in... ");
			base.ShowCountdown(5);
			Console.WriteLine("Now breathe out... ");
			base.ShowCountdown(5);
		}
		Console.Clear();
		base.DisplayEndingMessage();
	}
}
