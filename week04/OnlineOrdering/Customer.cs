public class Customer
{
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Getters and setters
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetAddress(Address Address)
    {
        _address = Address;
    }

    // Member Function to determine if the customer is from USA
    public bool IsFromUSA()
    {
        return _address.IsFromUSA();
    }
}