// Advanced/AsyncExample.cs
// This file demonstrates asynchronous programming in C#.

using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting...");
        await Task.Delay(2000); // Simulate an asynchronous operation
        Console.WriteLine("Finished after 2 seconds.");
    }
}