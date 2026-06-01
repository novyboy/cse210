using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1518 Auld Lane Unit 1", "Honolulu", "Hawaii", "USA");
        Address address2 = new Address("中区倉田264-18 ラ・ヴュー", "岡山市", "岡山県", "日本");
        Customer john = new Customer("John", address1);
        Customer tanaka = new Customer("田中", address2);
        Product soap = new Product("Soap", "SO", 5.49, 30);
        Product candle = new Product("Candle", "CA", 2.29, 100);
        Product wallet = new Product("Wallet", "WA", 23.49, 15);
        Product phone = new Product("Phone", "PH", 950, 40);
        Product laptop = new Product("Laptop", "LA", 2100, 20);
        
        Order order1 = new Order([soap, candle, wallet], john);
        Order order2 = new Order([phone, laptop], tanaka);
        
        Console.WriteLine("Order 1 Packing Label");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Order 1 Total Cost");
        Console.WriteLine(order1.CalculateCost());
        Console.WriteLine("Order 2 Packing Label");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Order 2 Total Cost");
        Console.WriteLine(order2.CalculateCost());
    }
}