public class Order
{
    private List<Product> _product;
    private Customer _customer;

    // Constructor
    public Order(List<Product> product, Customer customer)
    {
        _product = product;
        _customer = customer;
    }
    
    // Getters and setters
    public List<Product> GetProduct()
    {
        return _product;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetProduct(List<Product> product)
    {
        _product = product;
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    // Function to return total order cost
    public double TotalOrderCost()
    {
        double totalCost = 0;
        foreach (Product product in _product)
        {
            totalCost += product.GetTotalPrice();
        }
        return totalCost;
    }
    
    // Function to calculate the shipping cost
    public double ShippingCost()
    {
        double shippingCost = 0;
        if (_customer.IsFromUSA())
        {
            shippingCost = 5.00;
        }
        else
        {
            shippingCost = 35.00;
        }
        return shippingCost;

    }
    

    // Function to determine packing label
    public void PackingLabel()
    {
        foreach (Product product in _product)
        {
            Console.WriteLine($"Product Name: {product.GetName()} \nQuantity: {product.GetQuantity()}\nProduct ID: {product.GetProductId()} \nOrder Total: ${product.GetTotalPrice()}\n");
        }
    }
    public void ShippingLabel()
{
    Console.WriteLine($"Customer Name: {_customer.GetName()}");
    Console.WriteLine($"Address: {_customer.GetAddress()}");
    Console.WriteLine($"Total Order Cost: ${TotalOrderCost() + ShippingCost()}");
}
}