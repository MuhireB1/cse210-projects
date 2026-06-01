using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("iPhone15", 101, 1000.00, 2);
        
        // Create some addresses
        Address address = new Address("123 Main St", "New York", "NY", "USA");

        // Create some customers
        Customer customer1 = new Customer("John Doe", address);

        // Create an order
        List<Product> products = new List<Product> { product1 };

        // Create a list of customers for the order
        List<Customer> customers = new List<Customer> { customer1 };
        Order order1 = new Order(products, customers);
        // display the order details
        // Display packing label
        Console.WriteLine("PACKING LABEL:");
        order1.PackingLabel();
        // Display shipping label
        Console.WriteLine("SHIPPING LABEL:");
        order1.ShippingLabel();
    }   
}
