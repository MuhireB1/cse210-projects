using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Create objects
        Square square = new Square("Yellow", 12.5);
        Rectangle rectangle = new Rectangle("Red", 12.3, 5.67);
        Circle circle = new Circle("Blue", 8.21);

        // Create List
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // Get Area(s) for shapes
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()}: {shape.GetArea():F2}");
        }


    }
}