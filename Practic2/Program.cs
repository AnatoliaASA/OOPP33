using System;

namespace PointApp
{
    class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set
            {
                if (double.IsNaN(value) || double.IsInfinity(value))
                {
                    Console.WriteLine("Помилка: координата X має бути скінченним числом. Значення не змінено.");
                }
                else
                {
                    x = value;
                }
            }
        }

        public double Y
        {
            get { return y; }
            set
            {
                if (double.IsNaN(value) || double.IsInfinity(value))
                {
                    Console.WriteLine("Помилка: координата Y має бути скінченним числом. Значення не змінено.");
                }
                else
                {
                    y = value;
                }
            }
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Координати точки: ({X}; {Y})");
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Point p1 = new Point(3, 4);
            Point p2 = new Point(-5.5, 2.2);
            Point p3 = new Point(0, -7);

            Point[] points = { p1, p2, p3 };

            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"Точка {i + 1}:");
                points[i].ShowInfo();
                Console.WriteLine($"Відстань до початку координат: {points[i].DistanceToOrigin():F2}");
                Console.WriteLine();
            }
            //Домашнє завдання
            Console.WriteLine("Спроба встановити некоректне значення X для точки 1:");
            p1.X = double.NaN;

            Console.WriteLine("\nСтан точки 1 після спроби зміни:");
            p1.ShowInfo();
            Console.WriteLine($"Відстань до початку координат: {p1.DistanceToOrigin():F2}");

            Console.ReadKey();
        }
    }
}