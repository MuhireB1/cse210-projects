public class Fraction
{
    private double _top;
    private double _bottom;

    // Constructors
    public Fraction(double nominator, double denominator)
    {
       _top = nominator;
       _bottom = denominator;
    }

    // Getters and setter/ Accessors and mutatos
    public double GetTopNumber()
    {
        return _top;
    }
    public void SetTopNumber(double top)
    {
        _top = top;
    }
    public double GetBottomNumber()
    {
        return _bottom;
    }

    // Member methods
    public double GetDecimalValue()
    {
        double decimoNumber = _top / _bottom;
        return decimoNumber;
    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
}