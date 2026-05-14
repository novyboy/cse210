using System;
using System.Text.Json;
/*
Class: Journal
Attributes:
* entries : List<Entry>

Behaviors:
* Display() : void
* Load() : void
* Save() : void
*/
public class Journal
{
	public List<Entry> _entries = new List<Entry>();

	public Journal()
	{
	}
	public void Display()
	{
		foreach (Entry entry in _entries) {
			Console.WriteLine($"{entry._date} {entry._prompt}");
			Console.WriteLine(entry._response);
		}
	}
	public void Load(string filename)
	{
		string json = File.ReadAllText(filename);
		_entries = JsonSerializer.Deserialize<List<Entry>>(json, new JsonSerializerOptions
		{
				IncludeFields = true
		});
	}
	public void Save(string filename)
	{
		string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions
		{
			WriteIndented = true,
			IncludeFields = true
		});
		
		File.WriteAllText(filename, json);
	}
}
