
public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // Constructor
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }
    
    // Getters and Setters
    public double GetLength()
    {
        return _length;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetLength(double length)
    {
        _length = length;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }

    // Method to calculate area
    public override double GetArea()
    {
        return _length * _width;
    }
}