using System;

struct StructPoint
{
    public int X;
    public int Y;

    public StructPoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
}

class Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
}

class Program
{
    static void Main()
    {
        StructPoint point1 = new StructPoint(5, 10);
        StructPoint point2 = point1;

        point2.X = 20;

        Console.WriteLine("Структури:");
        Console.Write("Перша точка: ");
        point1.ShowInfo();

        Console.Write("Друга точка: ");
        point2.ShowInfo();

        Point classPoint1 = new Point(5, 10);
        Point classPoint2 = classPoint1;

        classPoint2.X = 20;

        Console.WriteLine("\nКласи:");
        Console.Write("Перша точка: ");
        classPoint1.ShowInfo();

        Console.Write("Друга точка: ");
        classPoint2.ShowInfo();
    }
}