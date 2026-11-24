
using System;

class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("Ім'я: " + Name);
        Console.WriteLine("Вік: " + Age);
    }
}

class Student : Person
{
    public string Faculty;
    public int Course;

    public Student(string name, int age, string faculty, int course)
        : base(name, age)
    {
        Faculty = faculty;
        Course = course;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Факультет: " + Faculty);
        Console.WriteLine("Курс: " + Course);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введіть ім'я: ");
        string name = Console.ReadLine();

        Console.Write("Введіть вік: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть факультет: ");
        string faculty = Console.ReadLine();

        Console.Write("Введіть курс: ");
        int course = Convert.ToInt32(Console.ReadLine());

        Student student = new Student(name, age, faculty, course);

        Console.WriteLine("\nІнформація про студента:");
        student.ShowInfo();
    }
}
