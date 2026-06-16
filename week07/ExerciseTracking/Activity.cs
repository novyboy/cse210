using System;
/*
Class: Activity
Attributes:
* name : string
* date : string
* duration : double

Behaviors:
* GetDuration() : double
* GetDistance() : double
* GetSpeed() : double
* GetPace() : double
* GetSummary() : string
*/
public abstract class Activity
{
	private string _name;
	private string _date;
	private double _duration;

	public Activity(string name, string date, double duration)
	{
		_name = name;
		_date = date;
		_duration = duration;
	}
	public double GetDuration() {
		return _duration;
	}
	public abstract double GetDistance();
	public abstract double GetSpeed();
	public abstract double GetPace();
	
	public string GetSummary() {
		return $"{_date} {_name} ({_duration}min): Distance: {GetDistance()}miles Speed: {GetSpeed()}mph Pace: {GetPace()}mpm";
	}
}
