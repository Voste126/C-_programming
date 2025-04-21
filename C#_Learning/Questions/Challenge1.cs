// Questions/Challenge1.cs
// This file contains a challenge to reverse a string in C#.

using System;

class Challenge1
{
    static void Main()
    {
        Console.WriteLine("Enter a string to reverse:");
        string input = Console.ReadLine();
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine("Reversed string: " + new string(charArray));
    }
}