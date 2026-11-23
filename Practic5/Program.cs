using System;

namespace OOP_Lesson9
{
    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static bool operator ==(Point a, Point b)
        {
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return ReferenceEquals(a, b);
            }
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            Point other = obj as Point;
            return !ReferenceEquals(other, null) && this == other;
        }

        public override int GetHashCode()
        {
            return X * 31 + Y;
        }


        public static Point operator *(Point p, int k)
        {
            return new Point(p.X * k, p.Y * k);
        }

        public static Point operator *(int k, Point p)
        {
            return new Point(p.X * k, p.Y * k);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Точка: ({X}; {Y})");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Point p1 = new Point(2, 3);
            Point p2 = new Point(4, 5);
            Point p3 = new Point(2, 3);

            Console.WriteLine("--- Точки ---");
            p1.ShowInfo();
            p2.ShowInfo();
            p3.ShowInfo();

            Console.WriteLine("\n--- Додавання (p1 + p2) ---");
            Point sum = p1 + p2;
            sum.ShowInfo();

            Console.WriteLine("\n--- Порівняння ---");
            Console.WriteLine($"p1 == p2: {p1 == p2}");
            Console.WriteLine($"p1 == p3: {p1 == p3}");
            Console.WriteLine($"p1 != p2: {p1 != p2}");
            Console.WriteLine($"p1 != p3: {p1 != p3}");

            Console.WriteLine("\n--- Множення на число ---");
            Point mult1 = p1 * 3;
            Point mult2 = 2 * p2;
            Console.Write("p1 * 3 -> ");
            mult1.ShowInfo();
            Console.Write("2 * p2 -> ");
            mult2.ShowInfo();

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}