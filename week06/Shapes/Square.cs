using System;
/*
Class: Square
Attributes:
* side : double

Behaviors:
* GetArea() : double
*/
public class Square : Shape
{
	private double _side;

	public Square(string color, double side) : base(color)
	{
		_side = side;
	}
	public override double GetArea() {
		return _side * _side;
	} 
}
