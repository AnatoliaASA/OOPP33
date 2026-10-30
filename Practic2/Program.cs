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
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Координати точки: ({x}; {y})");
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
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

            Console.ReadKey();
        }
    }
}