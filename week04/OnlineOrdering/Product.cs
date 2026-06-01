public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Getters and setters
    public string GetName()
    {
        return _name;
    }
    public int GetProductId()
    {
        return _productId;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetProductId(int productId)
    {
        _productId = productId;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    // Member Functions
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}