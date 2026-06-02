using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("iPhone15", 101, 1000.00, 2);
        Product product2 = new Product("AirPods Pro", 102, 250.00, 1);

        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        List<Product> order1Products = new List<Product> { product1, product2 };
        Order order1 = new Order(order1Products, customer1);

        // Products for order 2
        Product product3 = new Product("Laptop", 201, 1500.00, 1);
        Product product4 = new Product("Mouse", 202, 40.00, 1);

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        List<Product> order2Products = new List<Product> { product3, product4 };
        Order order2 = new Order(order2Products, customer2);

        // Display packing and shipping labels for order 1
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine("PACKING LABEL:");
        order1.PackingLabel();

        Console.WriteLine();
        Console.WriteLine("SHIPPING LABEL:");
        order1.ShippingLabel();

        Console.WriteLine();
        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine("PACKING LABEL:");
        order2.PackingLabel();

        Console.WriteLine();
        Console.WriteLine("SHIPPING LABEL:");
        order2.ShippingLabel();

    }
}
