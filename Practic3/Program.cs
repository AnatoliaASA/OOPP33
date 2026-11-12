using System;
namespace CircleApp
{
    public class Circle
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }
        public void MultiplyRadius(double factor)
        {
            radius *= factor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть радіус кола: ");
            double r = double.Parse(Console.ReadLine()!);
            Circle circle = new Circle(r);
            Console.WriteLine($"Площа кола:        {circle.GetArea():F4}");
            Console.WriteLine($"Довжина кола:      {circle.GetCircumference():F4}");

            Console.Write("У скільки разів збільшити радіус? ");
            double k = double.Parse(Console.ReadLine()!);

            circle.MultiplyRadius(k);

            Console.WriteLine($"\nНовий радіус:      {circle.Radius:F4}");
            Console.WriteLine($"Нова площа:        {circle.GetArea():F4}");
            Console.WriteLine($"Нова довжина:      {circle.GetCircumference():F4}");
            Console.ReadKey();
        }
    }
}