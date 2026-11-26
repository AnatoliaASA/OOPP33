using System;

interface IDrawable
{
    void Draw();
}

class Point : IDrawable
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Draw()
    {
        Console.WriteLine($"Малювання точки з координатами ({X}, {Y})");
    }
}

class Circle : IDrawable
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine($"Малювання кола з радіусом {Radius}");
    }
}

class Program
{
    static void Main()
    {
        Point point = new Point(5, 10);
        Circle circle = new Circle(7);

        point.Draw();
        circle.Draw();
    }
}