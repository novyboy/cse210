using System;
/*
Class: BicycleActivity
Attributes:
* speed : double

Behaviors:
* GetDistance() : double
* GetSpeed() : double
* GetPace() : double
*/
public class BicycleActivity : Activity
{
	private double _speed;
	
	public BicycleActivity(string name, string date, double duration, double speed) : base(name, date, duration)
	{
		_speed = speed;
	}
	public override double GetDistance() {
		return GetSpeed() / 60 * base.GetDuration();
	}
	public override double GetSpeed() {
		return _speed;
	}
	public override double GetPace() {
		return 60 / GetSpeed();
	}
}
