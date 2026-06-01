using System;
/*
Class: Product
Attributes:
* name : string
* id : string
* price : double
* quantity : int

Behaviors:
* CalculateCost() : double
* GetName() : string
* GetId() : string
*/
public class Product
{
	private string _name;
	private string _id;
	private double _price;
	private int _quantity;

	public Product(string name, string id, double price, int quantity)
	{
		_name = name;
		_id = id;
		_price = price;
		_quantity = quantity;
	}
	public double CalculateCost()
	{
		return _quantity * _price;
	}
	public string GetName()
	{
		return _name;
	}
	public string GetId()
	{
		return _id;
	}
}
