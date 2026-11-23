using System;

namespace OOP_Lesson8
{
    class Rectangle
    {
        public double Width;
        public double Height;

        public double GetArea()
        {
            return Width * Height;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Прямокутник: {Width} x {Height}, площа: {GetArea()}");
        }
    }

    class Program
    {
        static double ReadDouble(string message)
        {
            double value;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.Write("Некоректне значення. Введіть додатне число: ");
            }
            return value;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Rectangle[] rectangles = new Rectangle[5];

            for (int i = 0; i < rectangles.Length; i++)
            {
                Console.WriteLine($"\nПрямокутник №{i + 1}");
                rectangles[i] = new Rectangle();
                rectangles[i].Width = ReadDouble("Ширина: ");
                rectangles[i].Height = ReadDouble("Висота: ");
            }

            Rectangle largest = rectangles[0];
            foreach (Rectangle rect in rectangles)
            {
                if (rect.GetArea() > largest.GetArea())
                {
                    largest = rect;
                }
            }

            Console.WriteLine("\n--- Прямокутник з найбільшою площею ---");
            largest.ShowInfo();

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}