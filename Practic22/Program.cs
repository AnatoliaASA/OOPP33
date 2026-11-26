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

    public StructPoint()
    {
        X = 0;
        Y = 0;
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
        StructPoint point2 = new StructPoint();

        Console.WriteLine("Точка з параметрами:");
        point1.ShowInfo();

        Console.WriteLine("\nТочка без параметрів:");
        point2.ShowInfo();
    }
}