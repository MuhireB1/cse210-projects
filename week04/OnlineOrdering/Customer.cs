public class Customer
{
    // Attributes
    private string _name;
    private Address _address;
    private string _email;

    // Constructor
    public Customer(string name, Address address, string email)
    {
        _name = name;
        _address = address;
        _email = email;
    }

    // Mutators and Accessors
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    public string GetEmail()
    {
        return _email;
    }
    public void SetEmail(string email)
    {
        _email = email;
    }

    // Methods
    public string GetCountryStatus()
    {
        if (_address.IsFromUSA())
        {
            return "Customer is from USA";
        }
        return "Customer is not from USA";
    }
}