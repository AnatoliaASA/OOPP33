
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

class Program
{
    static void Main()
    {
        Shape[] shapes =
        {
            new Circle(5),
            new Circle(3),
            new Rectangle(4, 6),
            new Rectangle(3, 7)
        };

        Console.WriteLine("Площі геометричних фігур:");

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
        }

        double totalPerimeter = 0;

        foreach (Shape shape in shapes)
        {
            totalPerimeter += shape.GetPerimeter();
        }

        Console.WriteLine("\nЗагальний периметр усіх фігур: "
            + totalPerimeter);
    }
}
