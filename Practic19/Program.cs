using System;

interface IDrawable
{
    void Draw();
}

interface IScalable
{
    void Scale(double factor);
}

class Rectangle : IDrawable, IScalable
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public void Draw()
    {
        Console.WriteLine($"Прямокутник: ширина = {Width}, висота = {Height}");
    }

    public void Scale(double factor)
    {
        Width *= factor;
        Height *= factor;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle(4, 6);

        IDrawable drawable = rectangle;
        IScalable scalable = rectangle;

        Console.WriteLine("Початкові розміри:");
        drawable.Draw();

        scalable.Scale(2);

        Console.WriteLine("\nПісля масштабування:");
        drawable.Draw();
    }
}