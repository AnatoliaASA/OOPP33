
using System;

abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
}

class Circle : Shape
{
    public double Radius { get; set; }

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

    public void ChangeRadius(double newRadius)
    {
        Radius = newRadius;
        Console.WriteLine($"Новий радіус кола: {Radius}");
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
            new Rectangle(4, 6),
            new Circle(3),
            new Rectangle(3, 7)
        };

        foreach (Shape shape in shapes)
        {
            if (shape is Circle circle)
            {
                circle.ChangeRadius(10);
            }
        }

        Console.WriteLine("\nПлощі фігур після зміни радіуса:");

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
        }
    }
}
