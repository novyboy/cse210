using System;
/*
Class: SimpleGoal
Attributes:
* goals : List<Goal>
* score : int

Behaviors:
* RecordEvent() : void
* IsComplete() : bool
* GetStringRepresentation() : string
*/
public class GoalManager
{
	private List<Goal> _goals;
	private int _score;

	public GoalManager()
	{
		_goals = new List<Goal>();
		_score = 0;
	}
	public void Start()
	{
		string userInput = "";
		
		do {
			Console.Clear();
			Console.WriteLine("What would you like to do?");
			Console.WriteLine("1) Display Player Info");
			Console.WriteLine("2) List Goal Names");
			Console.WriteLine("3) List Goal Details");
			Console.WriteLine("4) Create Goal");
			Console.WriteLine("5) Record Event");
			Console.WriteLine("6) Save Goals");
			Console.WriteLine("7) Load Goals");
			Console.WriteLine("8) Quit");
			userInput = Console.ReadLine() ?? "";
			int numberOption = int.Parse(userInput);
			
			if (numberOption == 1) {
				DisplayPlayerInfo();
			} else if (numberOption == 2) {
				ListGoalNames();
			} else if (numberOption == 3) {
				ListGoalDetails();
			} else if (numberOption == 4) {
				CreateGoal();
			} else if (numberOption == 5) {
				RecordEvent();
			} else if (numberOption == 6) {
				SaveGoals();
			} else if (numberOption == 7) {
				LoadGoals();
			}
			if (numberOption != 8) {
				Console.Write("Press Enter to Continue: ");
				Console.ReadLine();
			}
		}
		while(userInput != "8");
	}
	public void DisplayPlayerInfo()
	{
		Console.WriteLine($"Score: {_score}");
	}
	public void ListGoalNames()
	{	
		Console.WriteLine("Goal Names:");
		foreach (Goal goal in _goals) {
			Console.WriteLine(goal.GetShortName());
		};
	}
	public void ListGoalDetails() {
		Console.WriteLine("Goal Details:");
		foreach (Goal goal in _goals) {
			Console.WriteLine(goal.GetDetailsString());
		};
	} 
	public void CreateGoal() {
		string userInput = "";
		Console.WriteLine("Which Goal Would You Like to Create?");
		Console.WriteLine("1) Simple Goal");
		Console.WriteLine("2) Checklist Goal");
		Console.WriteLine("3) Eternal Goal");
		userInput = Console.ReadLine() ?? "";
		int numberOption = int.Parse(userInput);
		
		Console.Write("Name: ");
		string name = Console.ReadLine() ?? "";
		
		Console.Write("Description: ");
		string description = Console.ReadLine() ?? "";
		
		Console.Write("Points: ");
		userInput = Console.ReadLine() ?? "";
		int points = int.Parse(userInput);
		
		if (numberOption == 1) {
			SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
			_goals.Add(simpleGoal);
		} else if (numberOption == 2) {
			Console.Write("Target: ");
			userInput = Console.ReadLine() ?? "";
			int target = int.Parse(userInput);
			
			Console.Write("Bonus: ");
			userInput = Console.ReadLine() ?? "";
			int bonus = int.Parse(userInput);
			ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);_goals.Add(checklistGoal);
		} else if (numberOption == 3) {
			EternalGoal eternalGoal = new EternalGoal(name, description, points);
			_goals.Add(eternalGoal);
		}
	}
	public void RecordEvent() {
		string userInput = "";
		Console.WriteLine("What Goal Have You Completed?");
		for (int i = 0; i < _goals.Count; i++) {
			Console.WriteLine($"{i + 1}) {_goals[i].GetShortName()}");
		}
		userInput = Console.ReadLine() ?? "";
		int numberOption = int.Parse(userInput);
		
		_score += _goals[numberOption - 1].RecordEvent();
	}
	public void SaveGoals() {
		string filename = "goals.txt";
		List<string> goals = new List<string>();
		
		goals.Add($"{_score}");
		
		foreach (Goal goal in _goals) {
			goals.Add(goal.GetStringRepresentation());
		};
		
		File.WriteAllText(filename, string.Join("\n", goals));
	}
	public void LoadGoals() {
		string filename = "goals.txt";
		
		List<string> goals = File.ReadAllText(filename).Split('\n').ToList();
		goals.Add($"{_score}");
		
		foreach (string goal in goals) {
			List<string> splitGoal = goal.Split(',').ToList();
			
			if (splitGoal[0] == "SimpleGoal") {
				SimpleGoal simpleGoal = new SimpleGoal(splitGoal[1], splitGoal[2], int.Parse(splitGoal[3]));
				_goals.Add(simpleGoal);
			} else if (splitGoal[0] == "ChecklistGoal") {
				ChecklistGoal checklistGoal = new ChecklistGoal(splitGoal[1], splitGoal[2], int.Parse(splitGoal[3]), int.Parse(splitGoal[4]), int.Parse(splitGoal[5]));
				_goals.Add(checklistGoal);
			} else if (splitGoal[0] == "EternalGoal") {
				EternalGoal eternalGoal = new EternalGoal(splitGoal[1], splitGoal[2], int.Parse(splitGoal[3]));
				_goals.Add(eternalGoal);
			}
		};
		
	}
}
