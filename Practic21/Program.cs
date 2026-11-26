using System;

class Student : IComparable<Student>
{
    public string Name { get; set; }
    public double AverageGrade { get; set; }

    public Student(string name, double averageGrade)
    {
        Name = name;
        AverageGrade = averageGrade;
    }

    public int CompareTo(Student other)
    {
        if (other == null)
            return 1;

        return AverageGrade.CompareTo(other.AverageGrade);
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Ім'я: {Name}, середній бал: {AverageGrade}");
    }
}

class Program
{
    static void Main()
    {
        Student[] students =
        {
            new Student("Олександр", 85.5),
            new Student("Марія", 95.2),
            new Student("Іван", 78.4),
            new Student("Анна", 90.0)
        };

        Console.WriteLine("До сортування:");

        foreach (Student student in students)
        {
            student.ShowInfo();
        }

        Array.Sort(students);

        Console.WriteLine("\nПісля сортування за середнім балом:");

        foreach (Student student in students)
        {
            student.ShowInfo();
        }
    }
}