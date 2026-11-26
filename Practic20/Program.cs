using System;

interface ILeft
{
    void Execute();
}

interface IRight
{
    void Execute();
}

class Controller : ILeft, IRight
{
    void ILeft.Execute()
    {
        Console.WriteLine("Виконання методу з інтерфейсу ILeft.");
    }

    void IRight.Execute()
    {
        Console.WriteLine("Виконання методу з інтерфейсу IRight.");
    }
}

class Program
{
    static void Main()
    {
        Controller controller = new Controller();

        ILeft left = controller;
        IRight right = controller;

        left.Execute();
        right.Execute();
    }
}