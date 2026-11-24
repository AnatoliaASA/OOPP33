
using System;

class Shape
{
    public virtual double GetArea()
    {
        return 0;
    }
}

class Circle : Shape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Triangle : Shape
{
    public double Base;
    public double Height;

    public Triangle(double baseLength, double height)
    {
        Base = baseLength;
        Height = height;
    }

    public override double GetArea()
    {
        return Base * Height / 2;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);
        Triangle triangle = new Triangle(8, 6);

        Console.WriteLine("Площа кола: " + circle.GetArea());
        Console.WriteLine("Площа прямокутника: " + rectangle.GetArea());
        Console.WriteLine("Площа трикутника: " + triangle.GetArea());
    }
}
