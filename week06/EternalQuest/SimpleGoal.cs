using System;
/*
Class: SimpleGoal
Attributes:
* isComplete : bool

Behaviors:
* RecordEvent() : void
* IsComplete() : bool
* GetStringRepresentation() : string
*/
public class SimpleGoal : Goal
{
	private bool _isComplete;

	public SimpleGoal(string name, string description, int points) : base(name, description, points)
	{
		_isComplete = false;
	}
	public override int RecordEvent() {
		_isComplete = true;
		return base._points;
	}
	
	public override bool IsComplete() {
		return _isComplete;
	}
	
	public override string GetStringRepresentation() {
		return $"SimpleGoal:{base._shortName},{base._description},{base._points}";
	}
}
