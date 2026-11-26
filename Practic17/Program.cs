using System;

sealed class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }
}

class Square : Rectangle
{
    public Square(double side) : base(side, side)
    {
    }
}

class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle(4, 6);

        Console.WriteLine("Площа прямокутника: " + rectangle.GetArea());
    }
}