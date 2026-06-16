using System;
/*
Class: RunningActivity
Attributes:
* speed : double

Behaviors:
* GetDistance() : double
* GetSpeed() : double
* GetPace() : double
*/
public class RunningActivity : Activity
{
	private double _distance;
	
	public RunningActivity(string name, string date, double duration, double distance) : base(name, date, duration)
	{
		_distance = distance;
	}
	public override double GetDistance() {
		return _distance;
	}
	public override double GetSpeed() {
		return GetDistance()/base.GetDuration() * 60; 
	}
	public override double GetPace() {
		return 60 / GetSpeed();
	}
}
