using System;
/*
Class: Job
Attributes:
* company : string
* jobTitle : string
* startYear : int
* endYear : int

Behaviors:
* Display() : void
*/
public class Job
{
	public string _company = "";
	public string _jobTitle = "";
	public int _startYear = 0;
	public int _endYear = 0;

	public Job()
	{
	}
	
	public void Display()
	{
		Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
	}
}
