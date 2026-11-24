
using System;

abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
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

    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
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

    public override double GetPerimeter()
    {
        return 2 * (Width + Height);
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

    public override double GetPerimeter()
    {
        double side = Math.Sqrt(
            (Base / 2) * (Base / 2) + Height * Height
        );

        return Base + 2 * side;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);
        Triangle triangle = new Triangle(8, 6);

        Console.WriteLine("Коло:");
        Console.WriteLine("Площа: " + circle.GetArea());
        Console.WriteLine("Периметр: " + circle.GetPerimeter());

        Console.WriteLine("\nПрямокутник:");
        Console.WriteLine("Площа: " + rectangle.GetArea());
        Console.WriteLine("Периметр: " + rectangle.GetPerimeter());

        Console.WriteLine("\nТрикутник:");
        Console.WriteLine("Площа: " + triangle.GetArea());
        Console.WriteLine("Периметр: " + triangle.GetPerimeter());
    }
}
