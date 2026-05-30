using System;

class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }

    public double GetPrice()
    {
        return price;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product: {name}");
        Console.WriteLine($"Product ID: {productId}");
        Console.WriteLine($"Price per Unit: ${price:F2}");
        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Total Cost: ${GetTotalCost():F2}");
    }
}
