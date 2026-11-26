using System;

interface IDrawable
{
    void Draw();
}

interface IScalable
{
    void Scale(double factor);
}

interface IIdentifiable
{
    string Id { get; set; }
}

class Rectangle : IDrawable, IScalable, IIdentifiable
{
    public double Width { get; set; }
    public double Height { get; set; }
    public string Id { get; set; }

    public Rectangle(double width, double height, string id)
    {
        Width = width;
        Height = height;
        Id = id;
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
        Rectangle rectangle = new Rectangle(4, 6, "RECT-001");

        IDrawable drawable = rectangle;
        IScalable scalable = rectangle;
        IIdentifiable identifiable = rectangle;

        Console.WriteLine("Ідентифікатор об'єкта: " + identifiable.Id);

        Console.WriteLine("\nПочаткові розміри:");
        drawable.Draw();

        scalable.Scale(2);

        Console.WriteLine("\nПісля масштабування:");
        drawable.Draw();

        Console.WriteLine("\nІдентифікатор після масштабування: " + identifiable.Id);
    }
}