using System;

namespace RectangleApp
{
    public class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double GetArea()
        {
            return width * height;
        }

        public double GetPerimeter()
        {
            return 2 * (width + height);
        }
        public bool IsSquare()
        {
            return width == height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Rectangle[] rectangles = new Rectangle[2];

            for (int i = 0; i < rectangles.Length; i++)
            {
                Console.WriteLine($"--- Прямокутник №{i + 1} ---");

                Console.Write("Введіть ширину: ");
                double w = double.Parse(Console.ReadLine()!);

                Console.Write("Введіть висоту: ");
                double h = double.Parse(Console.ReadLine()!);

                rectangles[i] = new Rectangle(w, h);
                Console.WriteLine();
            }

            Console.WriteLine("=== Результати ===");
            for (int i = 0; i < rectangles.Length; i++)
            {
                Rectangle r = rectangles[i];
                Console.WriteLine($"Прямокутник №{i + 1}:");
                Console.WriteLine($"  Ширина:   {r.Width:F2}");
                Console.WriteLine($"  Висота:   {r.Height:F2}");
                Console.WriteLine($"  Площа:    {r.GetArea():F2}");
                Console.WriteLine($"  Периметр: {r.GetPerimeter():F2}");
                Console.WriteLine($"  Це квадрат: {r.IsSquare()}");
            }

            Console.ReadKey();
        }
    }
}