// Beginner/SyntaxBasics.cs
// This file demonstrates basic C# syntax and features.

using System;

class SyntaxBasics
{
    static void Main()
    {
        // Variables and Data Types
        int number = 10;
        double pi = 3.14;
        string message = "Hello, C#!";
        bool isLearning = true;

        // Printing to the Console
        Console.WriteLine("Number: " + number);
        Console.WriteLine("Pi: " + pi);
        Console.WriteLine("Message: " + message);
        Console.WriteLine("Is Learning: " + isLearning);

        // Conditional Statements
        if (isLearning)
        {
            Console.WriteLine("Keep up the good work!");
        }
        else
        {
            Console.WriteLine("Start learning C# today!");
        }

        // Loops
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Loop iteration: " + i);
        }

        // Arrays
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int num in numbers)
        {
            Console.WriteLine("Array element: " + num);
        }

        // Functions
        int Add(int a, int b)
        {
            return a + b;
        }

        Console.WriteLine("Sum: " + Add(5, 7));
    }
}