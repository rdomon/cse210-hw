// // Square class
// public class Square : Shape
// {
//     // Private side field
//     private float _side;

//     // Constructor
//     public Square(string color, float side) : base(color)
//     {
//         _side = side;
//     }

//     // Override GetArea method
//     public override float GetArea()
//     {
//         return _side * _side;
//     }
// }

// // Rectangle class
// public class Rectangle : Shape
// {
//     // Private length and width fields
//     private float _length;
//     private float _width;

//     // Constructor
//     public Rectangle(string color, float length, float width) : base(color)
//     {
//         _length = length;
//         _width = width;
//     }

//     // Override GetArea method
//     public override float GetArea()
//     {
//         return _length * _width;
//     }
// }

// // Circle class
// public class Circle : Shape
// {
//     // Private radius field
//     private float _radius;

//     // Constructor
//     public Circle(string color, float radius) : base(color)
//     {
//         _radius = radius;
//     }

//     // Override GetArea method
//     public override float GetArea()
//     {
//         return MathF.PI * _radius * _radius;
//     }
// }