using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private string orderId;
    private Customer customer;

    public Order(string orderId, Customer customer)
    {
        this.orderId = orderId;
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetShippingCost()
    {
        if (customer.GetAddress().IsFromUSA())
        {
            return 5.00;
        }
        else
        {
            return 35.00;
        }
    }

    public double GetOrderTotal()
    {
        double total = 0;

        foreach (Product product in products)
        {
            total += product.GetTotalCost();
        }

        total += GetShippingCost();

        return total;
    }

    public void DisplayOrderSummary()
    {
        Console.WriteLine($"Order: {orderId}");
        Console.WriteLine($"Customer: {customer.GetName()}");

        foreach (Product product in products)
        {
            Console.WriteLine(
                $"{product.GetName()} (ID: {product.GetProductId()}) - " +
                $"${product.GetPrice():F2} x {product.GetQuantity()} = ${product.GetTotalCost():F2}"
            );
        }

        Console.WriteLine($"Shipping Cost: ${GetShippingCost():F2}");
        Console.WriteLine($"Order Total: ${GetOrderTotal():F2}");
    }
}