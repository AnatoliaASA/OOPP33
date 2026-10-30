using System;

namespace OOP_Lesson1
{
    class Student
    {
        public string Name;      // Ім'я
        public int Age;          // Вік
        public double AverageGrade; // Середній бал 

        public void ShowInfo()
        {
            Console.WriteLine($"Студент: {Name}, Вік: {Age} років, Середній бал: {AverageGrade}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Щоб українська мова нормально відображалась

            Console.WriteLine("--- Створення студентів ---");

            Student student1 = new Student();
            student1.Name = "Олександр";
            student1.Age = 18;
            student1.AverageGrade = 4.5;

            Student student2 = new Student();
            student2.Name = "Марія";
            student2.Age = 19;
            student2.AverageGrade = 5.0;


            Console.WriteLine("\n--- Інформація про студентів ---");
            
            student1.ShowInfo(); 
            student2.ShowInfo(); 
            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}