// using System;
// using System.Reflection.Metadata;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // list oof shapes
//         List<ArrayShape> shapes = new List<Shape>();
        
//         // Add diffreent shapes to the list
//         shapes.Add(new Square("Red", 5));
//         shapes.Add(new Rectangle("Blue", 4, 6));
//         shapes.Add(new Circle("Green", 3));

//         // Iterate throught the list and sisplay color and area
//         foreach(ArrayShape shpae in shapes)
//         {
//         Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
//         }
//     }
// }



// Base Shape class
public abstract class Shape
{
    // Private color field
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getter for color
    public string GetColor()
    {
        return _color;
    }

    // Virtual method for calculating area
    public abstract float GetArea();
}

// Square class
public class Square : Shape
{
    // Private side field
    private float _side;

    // Constructor
    public Square(string color, float side) : base(color)
    {
        _side = side;
    }

    // Override GetArea method
    public override float GetArea()
    {
        return _side * _side;
    }
}

// Rectangle class
public class Rectangle : Shape
{
    // Private length and width fields
    private float _length;
    private float _width;

    // Constructor
    public Rectangle(string color, float length, float width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override GetArea method
    public override float GetArea()
    {
        return _length * _width;
    }
}

// Circle class
public class Circle : Shape
{
    // Private radius field
    private float _radius;

    // Constructor
    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }

    // Override GetArea method
    public override float GetArea()
    {
        return MathF.PI * _radius * _radius;
    }
}

// Main Program
public class Program
{
    public static void Main(string[] args)
    {
        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();

        // Add different shapes to the list
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        // Iterate through the list and display color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}