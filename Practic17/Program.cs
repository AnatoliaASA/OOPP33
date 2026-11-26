using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Тварина видає звук.");
    }
}

class Mammal : Animal
{
    public sealed override void MakeSound()
    {
        Console.WriteLine("Ссавець видає звук.");
    }
}

class Dog : Mammal
{
}

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        Mammal mammal = new Mammal();
        Dog dog = new Dog();

        animal.MakeSound();
        mammal.MakeSound();
        dog.MakeSound();
    }
}