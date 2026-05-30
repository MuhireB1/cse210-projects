using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address(
    "123 Main St",
    "New York",
    "NY",
    "USA"
);

Customer customer = new Customer(
    "John Smith",
    address,
    "john@email.com"
);

Order order = new Order("ORD001", customer);

order.AddProduct(new Product("Laptop", "P001", 1000, 1));
order.AddProduct(new Product("Mouse", "P002", 25, 2));

order.DisplayOrderSummary();
    }
}
