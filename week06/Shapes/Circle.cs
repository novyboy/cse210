using System;
/*
Class: Circle
Attributes:
* length : double
* width: double

Behaviors:
* GetArea() : double
*/
public class Circle : Shape
{
	private double _radius;

	public Circle(string color, double radius) : base(color)
	{
		_radius = radius;
	}
	public override double GetArea() {
		return  Math.PI * _radius * _radius;
	} 
}
