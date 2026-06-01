using System;
/*
Class: Video
Attributes:
* title: string
* author: string
* length: int
* comments: List<Comment>

Behaviors:
* Display() : void
* SetComments(comments: List<Comment>) : void
* GetNumberOfComments(): int
*/
public class Video
{
	private string _title;
	private string _author;
	private int _length;
	private List<Comment> _comments;

	public Video(string title, string author, int length)
	{
		_title = title;
		_author = author;
		_length = length;
	}
	
	public void Display()
	{
		Console.WriteLine($"{_title} by {_author} ({_length}s)");
	}
	public void DisplayComments()
	{
		foreach (Comment comment in _comments) {
			comment.Display();
		}
	}
	public void SetComments(List<Comment> comments) {
		_comments = comments;
	}
	public int GetNumberOfComments() {
		return _comments.Count;
	}
}
