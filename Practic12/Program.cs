
using System;

class Vehicle
{
    protected int Speed;

    public Vehicle(int speed)
    {
        Speed = speed;
    }

    public void Start()
    {
        Console.WriteLine("Транспортний засіб починає рух.");
        Console.WriteLine("Швидкість: " + Speed + " км/год");
    }
}

class Car : Vehicle
{
    public Car(int speed) : base(speed)
    {
    }

    public new void Start()
    {
        Console.WriteLine("Автомобіль починає рух.");
        Console.WriteLine("Швидкість автомобіля: " + Speed + " км/год");
    }
}

class Program
{
    static void Main()
    {
        Vehicle vehicle = new Vehicle(50);
        Car car = new Car(100);

        Console.WriteLine("Інформація про транспортний засіб:");
        vehicle.Start();

        Console.WriteLine("\nІнформація про автомобіль:");
        car.Start();
        Vehicle vehicleReference = new Car(120);

        Console.WriteLine("\nВиклик через посилання базового класу:");
        vehicleReference.Start();
    }
}
