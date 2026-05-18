public class Fraction
{
    // Member Attributes
    private double _top;
    private double _bottom;

    // Constructors
    // public Fraction()
    // {
    //     _top = 1;
    //     _bottom = 1;
    // }
    // public Fraction(int top, int bottom=1)
    // {
    //     _top = top;
    //     _bottom = bottom;
    // }
    public Fraction(double top, double botttom)
    {
        _top = top;
        _bottom = botttom;
    }

    ///Getters and setters (accessors and Mutators)
    public double GetTop()
    {
        return _top;
    }
    public void SetTop(int nominator)
    {
        _top = nominator;
    }
    public double GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int denominator)
    {
        _bottom = denominator;
    }

    //Member Methods/
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
       double divisionValue = _top / _bottom;
        return divisionValue;
    }

}