using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Circle
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public double GetArea()
    {
        double area = Math.PI * radius * radius;
        return area;
    }
}


class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Whorld");

        // double x = 10;
        Circle myCircle = new Circle(10);

        Console.WriteLine($"The area of the circle is :{(myCircle.GetArea())}");


        Circle myCircle2 = new Circle(20);

        Console.WriteLine($"The area of the circle is :{(myCircle2.GetArea())}");

    }
}