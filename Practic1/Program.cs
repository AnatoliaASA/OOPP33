using System;

namespace OOP_Lesson1
{
    class Student
    {
        private static int studentCount = 0;

        public string Name;
        public int Age;
        public double AverageGrade;
        public Student()
        {
            studentCount++;
        }
        public Student(string name, int age, double averageGrade)
        {
            Name = name;
            Age = age;
            AverageGrade = averageGrade;
            studentCount++;
        }

        public static int GetStudentCount()
        {
            return studentCount;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Студент: {Name}, Вік: {Age} років, Середній бал: {AverageGrade}");
        }
    }
    static class MathUtils
    {
        public static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Факторіал визначений лише для невід'ємних чисел.");
            }

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- Створення студентів ---");

            Student student1 = new Student();
            student1.Name = "Олександр";
            student1.Age = 18;
            student1.AverageGrade = 4.5;

            Student student2 = new Student("Марія", 19, 5.0);

            Console.WriteLine("\n--- Інформація про студентів ---");

            student1.ShowInfo();
            student2.ShowInfo();

            Console.WriteLine($"\nВсього створено студентів: {Student.GetStudentCount()}");

            Console.WriteLine($"Факторіал числа 5: {MathUtils.Factorial(5)}");

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}