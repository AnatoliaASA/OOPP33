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

    class Student
    {
        public string Name;
        public double AverageGrade;

        public Student(string name, double averageGrade)
        {
            Name = name;
            AverageGrade = averageGrade;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Студент: {Name}, середній бал: {AverageGrade}");
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

            Student[] students = new Student[]
            {
                new Student("Олександр", 4.5),
                new Student("Марія", 5.0),
                new Student("Іван", 3.8),
                new Student("Олена", 4.2),
                new Student("Андрій", 4.9)
            };

            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - 1 - i; j++)
                {
                    if (students[j].AverageGrade < students[j + 1].AverageGrade)
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\n--- Студенти за спаданням середнього балу ---");
            foreach (Student student in students)
            {
                student.ShowInfo();
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}