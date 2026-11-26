using System;

interface IDrawable
{
    void Draw();
}

interface IScalable
{
    void Scale(double factor);
}

class Point : IDrawable, IScalable
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void Draw()
    {
        Console.WriteLine($"Точка: ({X}, {Y})");
    }

    public void Scale(double factor)
    {
        X *= factor;
        Y *= factor;
    }
}

class Circle : IDrawable, IScalable
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine($"Коло з радіусом {Radius}");
    }

    public void Scale(double factor)
    {
        Radius *= factor;
    }
}

class Program
{
    static void Main()
    {
        Point point = new Point(5, 10);
        Circle circle = new Circle(4);

        Console.WriteLine("Початкові розміри:");

        point.Draw();
        circle.Draw();

        point.Scale(2);
        circle.Scale(2);

        Console.WriteLine("\nПісля масштабування:");

        point.Draw();
        circle.Draw();
    }
}