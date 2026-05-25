using System;
/*
Class: Word
Attributes:
* text : string
* isHidden : bool

Constructors:
* Word(text: string)

Behaviors:
* Hide() : void
* Show() : void
* IsHidden() : bool
* GetDisplayText() : string
*/
public class Word
{
	private string _text;
	private bool _isHidden;

	public Word(string text)
	{
		_text = text;
	}
	
	public void Hide()
	{
		_isHidden = true;
	}
	public void Show()
	{
		_isHidden = false;
	}
	public bool IsHidden()
	{
		return _isHidden;
	}
	public string GetDisplayText()
	{
		if (_isHidden) {
			return new string('_', _text.Length);
		} else {
			return _text;
		}
	}
}
