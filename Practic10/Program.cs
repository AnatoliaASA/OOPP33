
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

    public void ShowInfo()
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

    public void ShowStudentInfo()
    {
        ShowInfo();
        Console.WriteLine("Факультет: " + Faculty);
        Console.WriteLine("Курс: " + Course);
    }
}

class Teacher : Person
{
    public string Department;
    public double Salary;

    public Teacher(string name, int age, string department, double salary)
        : base(name, age)
    {
        Department = department;
        Salary = salary;
    }

    public void ShowTeacherInfo()
    {
        ShowInfo();
        Console.WriteLine("Кафедра: " + Department);
        Console.WriteLine("Заробітна плата: " + Salary + " грн");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("Олександр", 35);

        Student student = new Student(
            "Денис", 18, "Комп'ютерних наук", 2
        );

        Teacher teacher = new Teacher(
            "Іван", 45, "Інформатики", 5000
        );

        Console.WriteLine("Інформація про персону:");
        person.ShowInfo();

        Console.WriteLine("\nІнформація про студента:");
        student.ShowStudentInfo();

        Console.WriteLine("\nІнформація про викладача:");
        teacher.ShowTeacherInfo();
    }
}
