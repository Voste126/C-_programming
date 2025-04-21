// Intermediate/OOPExample.cs
// This file demonstrates object-oriented programming in C#.

using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person { Name = "Alice", Age = 30 };
        person.Introduce();
    }
}