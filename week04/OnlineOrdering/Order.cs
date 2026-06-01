public class Order
{
    private List<Product> _product;
    private List<Customer> _customer;

    // Constructor
    public Order(List<Product> product, List<Customer> customer)
    {
        _product = product;
        _customer = customer;
    }
    
    // Getters and setters
    public List<Product> GetProduct()
    {
        return _product;
    }
    public List<Customer> GetCustomer()
    {
        return _customer;
    }
    public void SetProduct(List<Product> product)
    {
        _product = product;
    }
    public void SetCustomer(List<Customer> customer)
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
        foreach (Customer customer in _customer)
        {
            if (customer.IsFromUSA())
            {
                shippingCost += 5.00;
            }
            else
            {
                shippingCost += 35.00;
            }
        }
        return shippingCost;

    }
    

    // Function to determine packing label
    public void PackingLabel()
    {
        foreach (Product product in _product)
        {
            Console.WriteLine($"Product Name: {product.GetName()} \nQuantity: {product.GetQuantity()}\nProduct ID: {product.GetProductId()} \nOrder Total: ${product.GetTotalPrice()} \nShipping Cost: ${ShippingCost()}");
        }
    }
    public void ShippingLabel()
    {
        foreach(Customer customer in _customer)
        {
            Console.WriteLine($"Customer Name: {customer.GetName()} \n{customer.GetAddress()} \nTotal Order Cost: ${TotalOrderCost() + ShippingCost()}");
        }
    }
}