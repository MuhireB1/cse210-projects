public class Circle : Shape
{
    private double _radius;

    // Constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Getters and Setters
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    // Method to calculate area of a circle
    public override double GetArea()
    {
        return 3.14 * _radius * _radius;
    }
}
