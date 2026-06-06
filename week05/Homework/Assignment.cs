using System;
/*
Class: Assignment
Attributes:
* studentName : string
* topic : string

Behaviors:
* GetSummary() : string
*/
public class Assignment
{
	protected string _studentName;
	private string _topic;

	public Assignment(string studentName, string topic)
	{
		_studentName = studentName;
		_topic = topic;
	}
	public string GetSummary()
	{
		return $"{_studentName} - {_topic}";
	}
}
