public class Address
{
    private string _Street;
    private string _city;
    private string _state;
    private string _country;

    // constructor
    public Address(string Street, string city, string state, string country)
    {
        _Street = Street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Mutators and accessors
    public string GetStreet()
    {
        return _Street;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetState()
    {
        return _state;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetStreet(string Street)
    {
        _Street = Street;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }

    // Member Functions to display address information
    public void DisplayAddress()
    {
        Console.WriteLine($"{_Street}, {_city}, {_state}, {_country}\n");
    }

    public override string ToString()
    {
        return $"{_Street}, {_city}, {_state}, {_country}";
    }

    // Function to determine whether the address is from USA or not
    public bool IsFromUSA()
    {
        return _country.ToLower() == "usa";
    }
}