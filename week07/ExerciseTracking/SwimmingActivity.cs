using System;
/*
Class: SwimmingActivity
Attributes:
* speed : double

Behaviors:
* GetDistance() : double
* GetSpeed() : double
* GetPace() : double
*/
public class SwimmingActivity : Activity
{
	private double _numberOfLaps;
	
	public SwimmingActivity(string name, string date, double duration, double numberOfLaps) : base(name, date, duration)
	{
		_numberOfLaps = numberOfLaps;
	}
	public override double GetDistance() {
		return _numberOfLaps * 50 / 1000 * 0.62;
	}
	public override double GetSpeed() {
		return GetDistance()/base.GetDuration() * 60; 
	}
	public override double GetPace() {
		return 60 / GetSpeed();
	}
}
