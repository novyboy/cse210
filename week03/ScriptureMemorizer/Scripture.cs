using System;
/*
Class: Scripture
Attributes:
* reference : Reference
* words : List<Word>
* original : string

Constructors:
* Scripture(reference: Reference, text: string)

Behaviors:
* HideRandomWords(numberToHide: int) : void
* GetDisplayText() : string
* IsCompletelyHidden() : bool
* ShowAll() : void
* GetOriginalText() : string
*/
public class Scripture
{
	private Reference _reference;
	private List<Word> _words;
	private string _original;

	public Scripture(Reference reference, string text)
	{
		_reference = reference;
		_words = new List<Word>();
		List<string> words = text.Split(" ").ToList();
		
		_original = $"{_reference.GetDisplayText()}:";
		foreach (string word in words) {
			_original += $" {word}";
			_words.Add(new Word(word));
		}
	}
	
	public void HideRandomWords(int numberToHide)
	{
		Random randomGenerator = new Random();
		for (int i = 0; i < numberToHide; i++)
		{
			int hideIndex = randomGenerator.Next(0, _words.Count);
			_words[hideIndex].Hide();
		}
	}
	public void ShowAll()
	{
		foreach (Word word in _words) {
			word.Show();
		}
	}
	public string GetOriginalText()
	{
		return _original;
	}
	public string GetDisplayText()
	{
		string displayText = $"{_reference.GetDisplayText()}:";
		foreach (Word word in _words) {
			displayText += $" {word.GetDisplayText()}";
		}
		return displayText;
	}
	public bool IsCompletelyHidden()
	{
		foreach (Word word in _words) {
			if (word.IsHidden() == false) return false;
		}
		return true;
	}
}
