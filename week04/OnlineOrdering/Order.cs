using System;
/*
Class: Order
Attributes:
* products : List<Product>
* customer : Customer

Behaviors:
* CalculateCost() : double
* GetPackingLabel() : string
* GetShippingLabel() : string
*/
public class Order
{
	private List<Product> _products;
	private Customer _customer;

	public Order(List<Product> products, Customer customer)
	{
		_products = products;
		_customer = customer;
	}
	public double CalculateCost()
	{
		double productTotal = 0;
		int shipping = (_customer.InUSA()) ? 5 : 35;
		foreach (Product product in _products) {
			productTotal += product.CalculateCost();
		}
		return productTotal + shipping;
	}
	public string GetPackingLabel()
	{
		string packingLabel = "";
		foreach (Product product in _products) {
			packingLabel += $"{product.GetName()} {product.GetId()}\n";
		}
		return packingLabel;
	}
	public string GetShippingLabel()
	{
		return $"{_customer.GetName()}: {_customer.GetAddress()}";
	}
}
