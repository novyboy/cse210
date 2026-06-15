using System;
/*
Class: ChecklistGoal
Attributes:
* isComplete : bool

Behaviors:
* RecordEvent() : void
* IsComplete() : bool
* GetStringRepresentation() : string
*/
public class ChecklistGoal : Goal
{
	private int _amountCompleted;
	private int _target;
	private int _bonus;

	public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
	{
		_target = target;
		_bonus = bonus;
		_amountCompleted = 0;
	}
	public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
	{
		_target = target;
		_bonus = bonus;
		_amountCompleted = amountCompleted;
	}
	public override int RecordEvent() {
		_amountCompleted++;
		if (IsComplete()) {
			return base._points + _target;
		} else {
			return base._points;
		};
	}
	
	public override bool IsComplete() {
		return _amountCompleted <= _target;
	}
	
	public override string GetDetailsString() {
		if (IsComplete()) {
			return $"☑ {_amountCompleted}/{_target} {base._shortName} {base._description}";
		} else {
			return $"☐ {_amountCompleted}/{_target} {base._shortName} {base._description}";
		};
	}
	
	public override string GetStringRepresentation() {
		return $"ChecklistGoal,{base._shortName},{base._description},{base._points},{_target},{_bonus},{_amountCompleted}";
	}
}
